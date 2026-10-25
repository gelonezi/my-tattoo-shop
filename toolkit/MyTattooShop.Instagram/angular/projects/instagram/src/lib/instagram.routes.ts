import { RouterOutletComponent } from '@abp/ng.core';
import { Routes } from '@angular/router';

export const INSTAGRAM_ROUTES: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: RouterOutletComponent,
    children: [
      {
        path: '',
        loadComponent: () =>
          import('./components/instagram.component').then(c => c.InstagramComponent),
      },
    ],
  },
];
