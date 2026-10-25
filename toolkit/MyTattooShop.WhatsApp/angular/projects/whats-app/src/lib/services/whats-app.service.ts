import { inject, Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class WhatsAppService {
  apiName = 'WhatsApp';

  private restService = inject(RestService);

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/whats-app/example' },
      { apiName: this.apiName }
    );
  }
}
