import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Country } from '../_models/country';

@Injectable({
  providedIn: 'root'
})
export class RestCountriesServiceService {
  constructor(private http: HttpClient) { }

  getCountries(){
    return this.http.get<Country[]>(environment.restCountriesApiUrl + "/all");
  }
}
