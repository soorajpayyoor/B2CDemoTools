﻿using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsProviderOwinAuth
{
    public class ClaimsProviderAuthenticationOptions : AuthenticationOptions
    {
        public ClaimsProviderAuthenticationOptions(string userName, string userId)
            : base(Constants.DefaultAuthenticationType)
        {
            Description.Caption = Constants.DefaultAuthenticationType;
            CallbackPath = new PathString("/signin-ClaimsProvider");
            AuthenticationMode = AuthenticationMode.Passive;
            UserName = userName;
            UserId = userId;
        }

        public PathString CallbackPath { get; set; }

        public string UserName { get; set; }

        public string UserId { get; set; }

        public string SignInAsAuthenticationType { get; set; }

        public ISecureDataFormat<AuthenticationProperties> StateDataFormat { get; set; }
    }
}
