import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { SocialEngagementService } from '../services/social-engagement.service';

@Component({
  selector: 'lib-social-engagement',
  template: ` <p>social-engagement works!</p> `,
  changeDetection: ChangeDetectionStrategy.Eager,
})
export class SocialEngagementComponent {
  protected readonly service = inject(SocialEngagementService);

  constructor() {
    this.service.sample().subscribe(console.log);
  }
}
