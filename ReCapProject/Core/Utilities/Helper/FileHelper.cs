﻿using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helper
{
    public class FileHelper
    {
        public static string Add(IFormFile file)
        {
            string path = Environment.CurrentDirectory + @"\wwwroot";
            var sourcepath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var stream = new FileStream(sourcepath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            var result = newPath(file);
            File.Move(sourcepath, path + result);
            return result.Replace("\\", "/");
        }




        public static IResult Delete(string path)
        {
            string path2 = Environment.CurrentDirectory + @"\wwwroot";
            path = path.Replace("/", "\\");
            try
            {
                File.Delete(path2 + path);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }
        public static string Update(string sourcePath, IFormFile file)
        {
            string path = Environment.CurrentDirectory + @"\wwwroot";
            var result = newPath(file);
            if (sourcePath.Length > 0)
            {
                using (var stream = new FileStream(path + result, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            File.Delete(path + sourcePath);
            return result.Replace("\\", "/");

            //return result.Path2;
        }




        public static string newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName);
            string fileExtension = ff.Extension;


            var newPath = Guid.NewGuid().ToString() + fileExtension;


            return @"\Images\" + newPath;
        }





    }
}
