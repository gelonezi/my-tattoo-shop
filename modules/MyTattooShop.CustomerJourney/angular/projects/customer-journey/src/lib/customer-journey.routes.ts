import { RouterOutletComponent } from '@abp/ng.core';
import { Routes } from '@angular/router';

export const CUSTOMER_JOURNEY_ROUTES: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: RouterOutletComponent,
    children: [
      {
        path: '',
        loadComponent: () =>
          import('./components/customer-journey.component').then(c => c.CustomerJourneyComponent),
      },
    ],
  },
];
