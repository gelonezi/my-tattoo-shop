import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { TikTokService } from '../services/tik-tok.service';

@Component({
  selector: 'lib-tik-tok',
  template: ` <p>tik-tok works!</p> `,
  changeDetection: ChangeDetectionStrategy.Eager,
})
export class TikTokComponent {
  protected readonly service = inject(TikTokService);

  constructor() {
    this.service.sample().subscribe(console.log);
  }
}
