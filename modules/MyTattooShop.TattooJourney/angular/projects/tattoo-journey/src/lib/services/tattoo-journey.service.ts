import { inject, Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class TattooJourneyService {
  apiName = 'TattooJourney';

  private restService = inject(RestService);

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/tattoo-journey/example' },
      { apiName: this.apiName }
    );
  }
}
