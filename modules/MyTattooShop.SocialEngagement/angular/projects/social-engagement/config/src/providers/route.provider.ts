import { eLayoutType, RoutesService } from '@abp/ng.core';
import {
  EnvironmentProviders,
  inject,
  makeEnvironmentProviders,
  provideAppInitializer,
} from '@angular/core';
import { eSocialEngagementRouteNames } from '../enums/route-names';

export const SOCIAL_ENGAGEMENT_ROUTE_PROVIDERS = [
  provideAppInitializer(() => {
    configureRoutes();
  }),
];

export function configureRoutes() {
  const routesService = inject(RoutesService);
  routesService.add([
    {
      path: '/social-engagement',
      name: eSocialEngagementRouteNames.SocialEngagement,
      iconClass: 'fas fa-book',
      layout: eLayoutType.application,
      order: 3,
    },
  ]);
}

const SOCIAL_ENGAGEMENT_PROVIDERS: EnvironmentProviders[] = [...SOCIAL_ENGAGEMENT_ROUTE_PROVIDERS];

export function provideSocialEngagement() {
  return makeEnvironmentProviders(SOCIAL_ENGAGEMENT_PROVIDERS);
}
