import { TestBed } from '@angular/core/testing';

import { RestCountriesServiceService } from './rest-countries-service.service';

describe('RestCountriesServiceService', () => {
  let service: RestCountriesServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RestCountriesServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
