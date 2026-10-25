import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44366/',
  redirectUri: baseUrl,
  clientId: 'MyTattooShop_App',
  responseType: 'code',
  scope: 'offline_access MyTattooShop',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'MyTattooShop',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44366',
      rootNamespace: 'MyTattooShop',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
