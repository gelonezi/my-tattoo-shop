import { RouterOutletComponent } from '@abp/ng.core';
import { Routes } from '@angular/router';

export const SOCIAL_ENGAGEMENT_ROUTES: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: RouterOutletComponent,
    children: [
      {
        path: '',
        loadComponent: () =>
          import('./components/social-engagement.component').then(c => c.SocialEngagementComponent),
      },
    ],
  },
];
