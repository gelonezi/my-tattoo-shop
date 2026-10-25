import { eLayoutType, RoutesService } from '@abp/ng.core';
import {
  EnvironmentProviders,
  inject,
  makeEnvironmentProviders,
  provideAppInitializer,
} from '@angular/core';
import { eCalendarRouteNames } from '../enums/route-names';

export const CALENDAR_ROUTE_PROVIDERS = [
  provideAppInitializer(() => {
    configureRoutes();
  }),
];

export function configureRoutes() {
  const routesService = inject(RoutesService);
  routesService.add([
    {
      path: '/calendar',
      name: eCalendarRouteNames.Calendar,
      iconClass: 'fas fa-book',
      layout: eLayoutType.application,
      order: 3,
    },
  ]);
}

const CALENDAR_PROVIDERS: EnvironmentProviders[] = [...CALENDAR_ROUTE_PROVIDERS];

export function provideCalendar() {
  return makeEnvironmentProviders(CALENDAR_PROVIDERS);
}
