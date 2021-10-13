using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;
using DocuSign.eSign.Api;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using DocuSign.eSign.Client.Auth;
using System.Text;
using System.Linq;
using SdkTestsNet462;

namespace SdkTests462
{
    [TestClass]
    public class AccountsApiUnitTests
    {
        TestConfig testConfig = new TestConfig();
        [TestInitialize()]
        [TestMethod]
        public void JwtLoginTest()
        {
            testConfig.ApiClient = new ApiClient(testConfig.Host);

            Assert.IsNotNull(testConfig.PrivateKey);

            byte[] privateKeyStream = testConfig.PrivateKey;

            List<string> scopes = new List<string>();
            scopes.Add(OAuth.Scope_SIGNATURE);
            scopes.Add(OAuth.Scope_IMPERSONATION);

            OAuth.OAuthToken tokenInfo = testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKey, testConfig.UserId, testConfig.OAuthBasePath, privateKeyStream, testConfig.ExpiresInHours, scopes);

            // the authentication api uses the apiClient (and X-DocuSign-Authentication header) that are set in Configuration object
            OAuth.UserInfo userInfo = testConfig.ApiClient.GetUserInfo(tokenInfo.access_token);

            Assert.IsNotNull(userInfo);
            Assert.IsNotNull(userInfo.Accounts);

            foreach (var item in userInfo.Accounts)
            {
                if (item.IsDefault == "true")
                {
                    testConfig.AccountId = item.AccountId;
                    testConfig.ApiClient.SetBasePath(item.BaseUri + "/restapi");
                    break;
                }
            }

            Assert.IsNotNull(testConfig.AccountId);
        }

        [TestMethod]
        public void JwtListBrandTest()
        {
            AccountsApi accApi = new AccountsApi(testConfig.ApiClient);
            var brandsResponse = accApi.ListBrands(testConfig.AccountId);

            Assert.IsNotNull(brandsResponse);
        }

        [TestMethod]
        public void JwtUploadBrandLogoTest()
        {
            AccountsApi accApi = new AccountsApi(testConfig.ApiClient);

            if (string.IsNullOrEmpty(testConfig.BrandId))
            {
                CreateBrandTest();
            }

            try
            {
                byte[] brandLogoByteArray = Convert.FromBase64String(testConfig.BrandLogo);
                accApi.UpdateBrandLogoByType(testConfig.AccountId, testConfig.BrandId, "primary", brandLogoByteArray);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void JwtGetBrandLogoByBrandIdTest()
        {
            AccountsApi accApi = new AccountsApi(testConfig.ApiClient);
            if (string.IsNullOrEmpty(testConfig.BrandId))
            {
                CreateBrandTest();
            }

            byte[] brandLogoByteArray = Convert.FromBase64String(testConfig.BrandLogo);

            //Check if C# png just got uploaded
            Stream stream = accApi.GetBrandLogoByType(testConfig.AccountId, testConfig.BrandId, "primary");

            Assert.IsNotNull(stream);

            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                byte[] brandLogofromApi = ms.ToArray();
                Assert.AreEqual(Convert.ToBase64String(brandLogoByteArray), Convert.ToBase64String(brandLogofromApi));
            }
        }

        private void CreateBrandTest()
        {
            AccountsApi accApi = new AccountsApi(testConfig.ApiClient);
            Brand brand = new Brand
            {
                BrandName = "C# Brand"
            };

            var brands = accApi.CreateBrand(testConfig.AccountId, brand);

            foreach (var brnds in brands.Brands)
            {
                if (brnds.BrandName == brand.BrandName)
                {
                    testConfig.BrandId = brnds.BrandId;
                }
            }
        }

        [TestMethod]
        public void JwtGetAccountInformationTest()
        {
            AccountsApi accountsApi = new AccountsApi(testConfig.ApiClient);
            AccountInformation accountInformation = accountsApi.GetAccountInformation(testConfig.AccountId);
            Assert.IsNotNull(accountInformation);
            Assert.IsNotNull(accountInformation.AccountIdGuid);
            Assert.IsNotNull(accountInformation.AccountName);
            Assert.IsNotNull(accountInformation.BillingProfile);
        }
    }
}
