import { eLayoutType, RoutesService } from '@abp/ng.core';
import {
  EnvironmentProviders,
  inject,
  makeEnvironmentProviders,
  provideAppInitializer,
} from '@angular/core';
import { eWhatsAppRouteNames } from '../enums/route-names';

export const WHATS_APP_ROUTE_PROVIDERS = [
  provideAppInitializer(() => {
    configureRoutes();
  }),
];

export function configureRoutes() {
  const routesService = inject(RoutesService);
  routesService.add([
    {
      path: '/whats-app',
      name: eWhatsAppRouteNames.WhatsApp,
      iconClass: 'fas fa-book',
      layout: eLayoutType.application,
      order: 3,
    },
  ]);
}

const WHATS_APP_PROVIDERS: EnvironmentProviders[] = [...WHATS_APP_ROUTE_PROVIDERS];

export function provideWhatsApp() {
  return makeEnvironmentProviders(WHATS_APP_PROVIDERS);
}
