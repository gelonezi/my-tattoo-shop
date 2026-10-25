import { eLayoutType, RoutesService } from '@abp/ng.core';
import {
  EnvironmentProviders,
  inject,
  makeEnvironmentProviders,
  provideAppInitializer,
} from '@angular/core';
import { eCustomerJourneyRouteNames } from '../enums/route-names';

export const CUSTOMER_JOURNEY_ROUTE_PROVIDERS = [
  provideAppInitializer(() => {
    configureRoutes();
  }),
];

export function configureRoutes() {
  const routesService = inject(RoutesService);
  routesService.add([
    {
      path: '/customer-journey',
      name: eCustomerJourneyRouteNames.CustomerJourney,
      iconClass: 'fas fa-book',
      layout: eLayoutType.application,
      order: 3,
    },
  ]);
}

const CUSTOMER_JOURNEY_PROVIDERS: EnvironmentProviders[] = [...CUSTOMER_JOURNEY_ROUTE_PROVIDERS];

export function provideCustomerJourney() {
  return makeEnvironmentProviders(CUSTOMER_JOURNEY_PROVIDERS);
}
