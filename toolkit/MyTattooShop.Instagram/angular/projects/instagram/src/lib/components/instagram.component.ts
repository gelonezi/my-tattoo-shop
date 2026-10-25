import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { InstagramService } from '../services/instagram.service';

@Component({
  selector: 'lib-instagram',
  template: ` <p>instagram works!</p> `,
  changeDetection: ChangeDetectionStrategy.Eager,
})
export class InstagramComponent {
  protected readonly service = inject(InstagramService);

  constructor() {
    this.service.sample().subscribe(console.log);
  }
}
