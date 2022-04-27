using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_ShopOnlineStore
{
    public class PaypalConfiguration
    {
        //Variables for storing the clientID and clientSecret key
        public readonly static string clientId;
        public readonly static string clientSecret;

        //Constructor
        static PaypalConfiguration()
        {
            var config = getconfig();
            clientId = "AUss0rfCYIgEP0tr0MJfKhYRQqQijMCQadLUyrn0Kwl2xSA8mXQsBLGY8JT5uzPZEnz4SDFlrLE4EfI-";
            clientSecret = "EN08M6v5PEFC7OSnpG-iaGs_L48rclwHKp0nnLDgdSPR-VwRBKBre_NktO2k48UyIsR1bfvh49Jvk7oc";
        }
        // getting properties from the web.config
        private static Dictionary<string, string> getconfig()
        {
            return PayPal.Api.ConfigManager.Instance.GetProperties();
        }
        // getting accesstocken from paypal
        private static string GetAccessToken()
        {
            string accessToken = new OAuthTokenCredential(clientId, clientSecret, getconfig()).GetAccessToken();
            return accessToken;
        }
        // return apicontext object by invoking it with the accesstoken
        public static APIContext GetAPIContext()
        {
            APIContext apicontext = new APIContext(GetAccessToken());
            apicontext.Config = getconfig();
            return apicontext;
        }
    }
}