import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { CustomerChatService } from '../services/customer-chat.service';

@Component({
  selector: 'lib-customer-chat',
  template: ` <p>customer-chat works!</p> `,
  changeDetection: ChangeDetectionStrategy.Eager,
})
export class CustomerChatComponent {
  protected readonly service = inject(CustomerChatService);

  constructor() {
    this.service.sample().subscribe(console.log);
  }
}
