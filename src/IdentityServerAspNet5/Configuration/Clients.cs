﻿namespace IdentityServerAspNet5.Configuration
{
    using System.Collections.Generic;

    using IdentityServer4.Core.Models;

    public class Clients
    {
        public static List<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientName = "aspnetcoreidclient3",
                    ClientId = "aspnetcoreidclient3",
                    Flow = Flows.Implicit,
                    RedirectUris = new List<string>
                    {
                        "http://localhost:56873/signin-oidc"
                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        "http://localhost:56873/"
                    },
                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:56873"
                    },
                    AllowedScopes = new List<string>
                    {
                        "openid",
                        "email",
                        "profile",
                        "dataEventRecords",
                        "aReallyCoolScope",
                        "securedFiles",
                        "role"
                    }
                },
                new Client
                {
                    ClientName = "angularclient",
                    ClientId = "angularclient",
                    Flow = Flows.Implicit,
                    RedirectUris = new List<string>
                    {
                        "https://localhost:44347/authorized"
                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        "https://localhost:44347/unauthorized.html"
                    },
                    AllowedCorsOrigins = new List<string>
                    {
                        "https://localhost:44347"
                    },
                    AllowedScopes = new List<string>
                    {
                        "openid",
                        "email",
                        "profile",
                        "dataEventRecords",
                        "aReallyCoolScope",
                        "securedFiles",
                        "role"
                    }
                },
                new Client
                {
                    ClientName = "angular2client",
                    ClientId = "angular2client",
                    Flow = Flows.Implicit,
                    RedirectUris = new List<string>
                    {
                        "https://localhost:44311"

                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        "https://localhost:44311/Unauthorized.html"
                    },
                    AllowedCorsOrigins = new List<string>
                    {
                        "https://localhost:44311",
                        "http://localhost:44311"
                    },
                    AllowedScopes = new List<string>
                    {
                        "openid",
                        "dataEventRecords",
                        "securedFiles",
                        "role"
                    }
                }
            };
        }
    }
}