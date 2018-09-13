using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CodeMaze.IDP
{
    public static class Config
    {
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "A8ED4CB8-69D6-4972-ACC7-1DAA3DEC8ED8",
                    Username = "Max",
                    Password = "Pass@Max",
                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "Max"),
                        new Claim("family_name", "Cook"),
                        new Claim("role", "Administrator")
                    }
                },
                new TestUser
                {
                    SubjectId = "7962762C-E6C4-497A-B0AE-C0B7CA70B56E",
                    Username = "Lee",
                    Password = "Pass@Lee",
                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "Lee"),
                        new Claim("family_name", "Adams"),
                        new Claim("role", "User")
                    }
                }
            };
        }

        public static List<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
               new IdentityResources.OpenId(),
               new IdentityResources.Profile(),
               new IdentityResource("roles", "Your role(s)", new []{"role"}),
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new[] {
                new ApiResource("accountownerapi", "Account Owner API", new[] { "role" })
            };
        }

        public static List<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientName = "Account Owner Angular",
                    ClientId="accountownerangular",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    RequireConsent = false,
                    AllowAccessTokensViaBrowser = true,
                    
                    RedirectUris =new List<string>
                    {
                        "https://localhost:4200/signin-oidc"
                    },
                    AccessTokenLifetime = 180,
                    PostLogoutRedirectUris = new[]{
                        "https://localhost:4200/"
                    },
                    AllowedScopes = new []
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "roles",
                        "accountownerapi"
                    }
                }
            };
        }
    }
}
