import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { CustomerJourneyService } from '../services/customer-journey.service';

@Component({
  selector: 'lib-customer-journey',
  template: ` <p>customer-journey works!</p> `,
  changeDetection: ChangeDetectionStrategy.Eager,
})
export class CustomerJourneyComponent {
  protected readonly service = inject(CustomerJourneyService);

  constructor() {
    this.service.sample().subscribe(console.log);
  }
}
