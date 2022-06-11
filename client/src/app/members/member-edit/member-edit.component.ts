import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { take } from 'rxjs/operators';;
import { Country } from 'src/app/_models/country';
import { Member } from 'src/app/_models/member';
import { User } from 'src/app/_models/user';
import { AccountService } from 'src/app/_services/account.service';
import { MembersService } from 'src/app/_services/members.service';
import { RestCountriesServiceService } from 'src/app/_services/rest-countries-service.service';

@Component({
  selector: 'app-member-edit',
  templateUrl: './member-edit.component.html',
  styleUrls: ['./member-edit.component.css']
})
export class MemberEditComponent implements OnInit {
  member: Member;
  user: User;
  countries: Country[];
  countriesNames: string[];
  selectedCountry: string;
  selectedGender: string;
  selectedLookingFor: string;

  constructor(private accountService: AccountService, 
              private memberService: MembersService,
              private restCountriesService: RestCountriesServiceService,
              private toastr: ToastrService) { 

    this.accountService.currentUser$.pipe(take(1)).subscribe(user => this.user = user); 

    this.countries = [{} as Country];
    this.countriesNames = [{} as string];
    this.member = {} as Member;
  }
  
  ngOnInit(): void {
    this.getMember();
    this.getCountries();
  }

  getMember(){
    this.memberService.getMember(this.user.username).subscribe(member => {
      this.member = member;
      this.selectedCountry = this.member.country;
      this.selectedGender = this.member.gender;
    });
  }

  getCountries(){
    this.restCountriesService.getCountries().subscribe(countries => {
        this.countries = countries;
        this.selectAllNamesFromCountries();
    });
  }

  updateUser(){
    this.memberService.updateUser(this.member).subscribe(member => {
      this.member = member;
      if(this.member){
        this.toastr.success("User updated succesfully!");
      }
    });
  }

  selectAllNamesFromCountries(){
    for(let i = 0; i < this.countries.length; i++){
      this.countriesNames[i] = this.countries[i].name.common;
    }
  }

  childrenSelected(obj: any){
    console.log(obj)
  }

}
