import { eLayoutType, RoutesService } from '@abp/ng.core';
import {
  EnvironmentProviders,
  inject,
  makeEnvironmentProviders,
  provideAppInitializer,
} from '@angular/core';
import { eTikTokRouteNames } from '../enums/route-names';

export const TIK_TOK_ROUTE_PROVIDERS = [
  provideAppInitializer(() => {
    configureRoutes();
  }),
];

export function configureRoutes() {
  const routesService = inject(RoutesService);
  routesService.add([
    {
      path: '/tik-tok',
      name: eTikTokRouteNames.TikTok,
      iconClass: 'fas fa-book',
      layout: eLayoutType.application,
      order: 3,
    },
  ]);
}

const TIK_TOK_PROVIDERS: EnvironmentProviders[] = [...TIK_TOK_ROUTE_PROVIDERS];

export function provideTikTok() {
  return makeEnvironmentProviders(TIK_TOK_PROVIDERS);
}
