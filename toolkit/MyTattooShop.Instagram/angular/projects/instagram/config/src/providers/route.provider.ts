import { eLayoutType, RoutesService } from '@abp/ng.core';
import {
  EnvironmentProviders,
  inject,
  makeEnvironmentProviders,
  provideAppInitializer,
} from '@angular/core';
import { eInstagramRouteNames } from '../enums/route-names';

export const INSTAGRAM_ROUTE_PROVIDERS = [
  provideAppInitializer(() => {
    configureRoutes();
  }),
];

export function configureRoutes() {
  const routesService = inject(RoutesService);
  routesService.add([
    {
      path: '/instagram',
      name: eInstagramRouteNames.Instagram,
      iconClass: 'fas fa-book',
      layout: eLayoutType.application,
      order: 3,
    },
  ]);
}

const INSTAGRAM_PROVIDERS: EnvironmentProviders[] = [...INSTAGRAM_ROUTE_PROVIDERS];

export function provideInstagram() {
  return makeEnvironmentProviders(INSTAGRAM_PROVIDERS);
}
