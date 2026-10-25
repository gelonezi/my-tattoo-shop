import { eLayoutType, RoutesService } from '@abp/ng.core';
import {
  EnvironmentProviders,
  inject,
  makeEnvironmentProviders,
  provideAppInitializer,
} from '@angular/core';
import { eTattooJourneyRouteNames } from '../enums/route-names';

export const TATTOO_JOURNEY_ROUTE_PROVIDERS = [
  provideAppInitializer(() => {
    configureRoutes();
  }),
];

export function configureRoutes() {
  const routesService = inject(RoutesService);
  routesService.add([
    {
      path: '/tattoo-journey',
      name: eTattooJourneyRouteNames.TattooJourney,
      iconClass: 'fas fa-book',
      layout: eLayoutType.application,
      order: 3,
    },
  ]);
}

const TATTOO_JOURNEY_PROVIDERS: EnvironmentProviders[] = [...TATTOO_JOURNEY_ROUTE_PROVIDERS];

export function provideTattooJourney() {
  return makeEnvironmentProviders(TATTOO_JOURNEY_PROVIDERS);
}
