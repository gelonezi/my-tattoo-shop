import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { TattooJourneyService } from '../services/tattoo-journey.service';

@Component({
  selector: 'lib-tattoo-journey',
  template: ` <p>tattoo-journey works!</p> `,
  changeDetection: ChangeDetectionStrategy.Eager,
})
export class TattooJourneyComponent {
  protected readonly service = inject(TattooJourneyService);

  constructor() {
    this.service.sample().subscribe(console.log);
  }
}
