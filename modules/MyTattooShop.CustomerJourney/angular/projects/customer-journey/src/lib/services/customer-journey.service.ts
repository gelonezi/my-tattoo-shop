import { inject, Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class CustomerJourneyService {
  apiName = 'CustomerJourney';

  private restService = inject(RestService);

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/customer-journey/example' },
      { apiName: this.apiName }
    );
  }
}
