using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using DocuSign.eSign.Model;
using DocuSign.eSign.Api;
using System.IO;

namespace SdkTests462
{
    [TestClass]
    public class AccountsApiUnitTests
    {
        private TestConfig _testConfig = new TestConfig();

        public AccountsApiUnitTests()
        {
            JwtLoginMethod.RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
        }

        [TestMethod]
        public void ListBrands_CorrectAccountId_ReturnsBrandsResponse()
        {
            AccountsApi accountsApi = new AccountsApi(_testConfig.ApiClient);
            var brandsResponse = accountsApi.ListBrands(_testConfig.AccountId);

            Assert.IsNotNull(brandsResponse);
        }

        [TestMethod]
        public void UpdateBrandLogoByType_CorectInputs_ReturnsNoErrors()
        {
            AccountsApi accountsApi = new AccountsApi(_testConfig.ApiClient);
            var logoType = "primary";
            if (string.IsNullOrEmpty(_testConfig.BrandId))
            {
                CreateBrand_CorrectAccountIdAndBrand_ReturnBrandsResponse();
            }

            byte[] brandLogoByteArray = Convert.FromBase64String(_testConfig.BrandLogo);
            accountsApi.UpdateBrandLogoByType(_testConfig.AccountId, _testConfig.BrandId, logoType, brandLogoByteArray);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetBrandLogoByType_CorrectInputParameters_ReturnStream()
        {
            AccountsApi accountsApi = new AccountsApi(_testConfig.ApiClient);
            if (string.IsNullOrEmpty(_testConfig.BrandId))
            {
                CreateBrand_CorrectAccountIdAndBrand_ReturnBrandsResponse();
            }
            var logoType = "primary";
            byte[] brandLogoByteArray = Convert.FromBase64String(_testConfig.BrandLogo);

            Stream stream = accountsApi.GetBrandLogoByType(_testConfig.AccountId, _testConfig.BrandId, logoType);

            Assert.IsNotNull(stream);

            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                byte[] brandLogoFromApi = ms.ToArray();
                Assert.AreEqual(Convert.ToBase64String(brandLogoByteArray), Convert.ToBase64String(brandLogoFromApi));
            }
        }

        private void CreateBrand_CorrectAccountIdAndBrand_ReturnBrandsResponse()
        {
            AccountsApi accountsApi = new AccountsApi(_testConfig.ApiClient);
            Brand brand = new Brand
            {
                BrandName = "C# Brand"
            };

            var brands = accountsApi.CreateBrand(_testConfig.AccountId, brand);

            foreach (var singleBrand in brands.Brands)
            {
                if (singleBrand.BrandName == brand.BrandName)
                {
                    _testConfig.BrandId = singleBrand.BrandId;
                }
            }
        }

        [TestMethod]
        public void GetAccountInformation_CorrectAccountId_ReturnAccountInformation()
        {
            AccountsApi accountsApi = new AccountsApi(_testConfig.ApiClient);
            AccountInformation accountInformation = accountsApi.GetAccountInformation(_testConfig.AccountId);

            Assert.IsNotNull(accountInformation);
            Assert.IsNotNull(accountInformation.AccountIdGuid);
            Assert.IsNotNull(accountInformation.AccountName);
            Assert.IsNotNull(accountInformation.BillingProfile);
        }
    }
}
