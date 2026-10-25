import { RouterOutletComponent } from '@abp/ng.core';
import { Routes } from '@angular/router';

export const WHATS_APP_ROUTES: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: RouterOutletComponent,
    children: [
      {
        path: '',
        loadComponent: () =>
          import('./components/whats-app.component').then(c => c.WhatsAppComponent),
      },
    ],
  },
];
