import { RouterOutletComponent } from '@abp/ng.core';
import { Routes } from '@angular/router';

export const CUSTOMER_CHAT_ROUTES: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: RouterOutletComponent,
    children: [
      {
        path: '',
        loadComponent: () =>
          import('./components/customer-chat.component').then(c => c.CustomerChatComponent),
      },
    ],
  },
];
