import { RouterOutletComponent } from '@abp/ng.core';
import { Routes } from '@angular/router';

export const STORAGE_ROUTES: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: RouterOutletComponent,
    children: [
      {
        path: '',
        loadComponent: () =>
          import('./components/storage.component').then(c => c.StorageComponent),
      },
    ],
  },
];
