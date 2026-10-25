import { inject, Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class CustomerChatService {
  apiName = 'CustomerChat';

  private restService = inject(RestService);

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/customer-chat/example' },
      { apiName: this.apiName }
    );
  }
}
