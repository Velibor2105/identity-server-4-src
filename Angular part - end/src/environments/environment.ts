// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `.angular-cli.json`.

export const environment = {
  production: false,
  urlAddress: 'https://localhost:44343',
  openIdConnectSettings: {
    authority: 'https://localhost:44306/',
    client_id: 'accountownerangular',
    redirect_uri: 'https://localhost:4200/signin-oidc',
    scope: 'openid profile',
    response_type: 'id_token',
    post_logout_redirect_uri: 'https://localhost:4200/',
  }
};

