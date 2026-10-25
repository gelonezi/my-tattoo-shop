import { RouterOutletComponent } from '@abp/ng.core';
import { Routes } from '@angular/router';

export const TIK_TOK_ROUTES: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: RouterOutletComponent,
    children: [
      {
        path: '',
        loadComponent: () =>
          import('./components/tik-tok.component').then(c => c.TikTokComponent),
      },
    ],
  },
];
