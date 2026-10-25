import { RouterOutletComponent } from '@abp/ng.core';
import { Routes } from '@angular/router';

export const CALENDAR_ROUTES: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: RouterOutletComponent,
    children: [
      {
        path: '',
        loadComponent: () =>
          import('./components/calendar.component').then(c => c.CalendarComponent),
      },
    ],
  },
];
