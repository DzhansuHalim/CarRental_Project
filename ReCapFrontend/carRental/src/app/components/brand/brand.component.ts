import { Component, OnInit } from '@angular/core';
import { Brand } from 'src/app/models/brand';
import { BrandService } from 'src/app/services/brand.service';

@Component({
  selector: 'app-brand',
  templateUrl: './brand.component.html',
  styleUrls: ['./brand.component.css']
})
export class BrandComponent implements OnInit {

  brands : Brand[] = [];
  currentBrand: Brand;  
  brandAdd = false;
  
  constructor( private brandService:BrandService) { }

  ngOnInit(): void {
    this.getBrands();
  }

  getBrands(){
    this.brandService.getBrands().subscribe(response => {
      this.brands = response.data;
    })
  }

  addBrand(){
    this.brandAdd = true;
  }

  setCurrentBrand( brand : Brand){
    this.currentBrand = brand;
  }

  getCurrentBrandClass(brand : Brand){
    if(brand == this.currentBrand){
      return "list-group-item active list-group-item-action"
    }else{
      return "list-group-item list-group-item-action"
    }
  }


  getAllBrandClass(){ 
    if(!this.currentBrand){
      return "list-group-item active list-group-item-action"
    }else{
      return "list-group-item list-group-item-action"
    }
  }

}
