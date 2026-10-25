import { inject, Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class TikTokService {
  apiName = 'TikTok';

  private restService = inject(RestService);

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/tik-tok/example' },
      { apiName: this.apiName }
    );
  }
}
