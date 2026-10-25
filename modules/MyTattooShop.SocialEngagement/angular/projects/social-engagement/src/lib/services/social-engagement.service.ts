import { inject, Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class SocialEngagementService {
  apiName = 'SocialEngagement';

  private restService = inject(RestService);

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/social-engagement/example' },
      { apiName: this.apiName }
    );
  }
}
