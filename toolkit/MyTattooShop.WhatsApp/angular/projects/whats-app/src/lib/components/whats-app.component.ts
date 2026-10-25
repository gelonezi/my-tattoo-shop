import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { WhatsAppService } from '../services/whats-app.service';

@Component({
  selector: 'lib-whats-app',
  template: ` <p>whats-app works!</p> `,
  changeDetection: ChangeDetectionStrategy.Eager,
})
export class WhatsAppComponent {
  protected readonly service = inject(WhatsAppService);

  constructor() {
    this.service.sample().subscribe(console.log);
  }
}
