using SenateCore.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Services
{
    public class BasicPayScaleService:IBasicPayScaleService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ICommonUtils _commonUtilities;
        private string APIUrl;
        
        public BasicPayScaleService(IHttpClientFactory httpClientFactory,ICommonUtils commonUtilities)
        {
            _httpClientFactory = httpClientFactory;
            _commonUtilities = commonUtilities;
            APIUrl= _commonUtilities.GetAPIUrl();

        }
        public async Task<string> GetBasicPayScaleAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetStringAsync(APIUrl + "/api/BasicPayScale");
            return response;
        }
    }
}
