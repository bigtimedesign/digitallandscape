using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using weWork.Models;

namespace weWork
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            OAuthWebSecurity.RegisterTwitterClient(
                consumerKey: "Qy4JnceELiYiyR96vrJauA",
                consumerSecret: "F2589boBH8ReOTRVqacydsHwf1BPOHlin1Zo9G68");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "477959512273331",
                appSecret: "9ee575ab6a6590b0fc3895bc281f8317");

            OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
