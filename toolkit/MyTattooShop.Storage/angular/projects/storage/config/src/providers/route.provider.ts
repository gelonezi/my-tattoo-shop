import { eLayoutType, RoutesService } from '@abp/ng.core';
import {
  EnvironmentProviders,
  inject,
  makeEnvironmentProviders,
  provideAppInitializer,
} from '@angular/core';
import { eStorageRouteNames } from '../enums/route-names';

export const STORAGE_ROUTE_PROVIDERS = [
  provideAppInitializer(() => {
    configureRoutes();
  }),
];

export function configureRoutes() {
  const routesService = inject(RoutesService);
  routesService.add([
    {
      path: '/storage',
      name: eStorageRouteNames.Storage,
      iconClass: 'fas fa-book',
      layout: eLayoutType.application,
      order: 3,
    },
  ]);
}

const STORAGE_PROVIDERS: EnvironmentProviders[] = [...STORAGE_ROUTE_PROVIDERS];

export function provideStorage() {
  return makeEnvironmentProviders(STORAGE_PROVIDERS);
}
