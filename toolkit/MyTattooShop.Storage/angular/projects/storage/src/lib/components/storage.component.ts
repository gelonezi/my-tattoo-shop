import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { StorageService } from '../services/storage.service';

@Component({
  selector: 'lib-storage',
  template: ` <p>storage works!</p> `,
  changeDetection: ChangeDetectionStrategy.Eager,
})
export class StorageComponent {
  protected readonly service = inject(StorageService);

  constructor() {
    this.service.sample().subscribe(console.log);
  }
}
