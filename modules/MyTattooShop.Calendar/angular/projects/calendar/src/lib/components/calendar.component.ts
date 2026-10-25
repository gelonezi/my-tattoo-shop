import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { CalendarService } from '../services/calendar.service';

@Component({
  selector: 'lib-calendar',
  template: ` <p>calendar works!</p> `,
  changeDetection: ChangeDetectionStrategy.Eager,
})
export class CalendarComponent {
  protected readonly service = inject(CalendarService);

  constructor() {
    this.service.sample().subscribe(console.log);
  }
}
