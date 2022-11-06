using Hotel_Managment_Studio.Models;
using Hotel_Managment_Studio.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace SimpleTrader.FinancialModelingPrepAPI.Services
{
    public class MajorIndexService : IMajorIndexService
    {
        public async Task<MajorIndex> GetMajorIndex(MajorIndexType indexType)
        {
            using (HttpClient client = new HttpClient())
            {
                string uri = "https://financialmodelingprep.com/api/v3/nasdaq_constituent?apikey=e6702fecf306ae6209e7c2a574a545b2"+GetUriSuffix(indexType);

                HttpResponseMessage response = await client.GetAsync($"{uri}?apikey=e6702fecf306ae6209e7c2a574a545b2");
                string jsonResponse = await response.Content.ReadAsStringAsync();

                MajorIndex majorIndex = JsonConvert.DeserializeObject<MajorIndex>(jsonResponse);
                majorIndex.Type = indexType;

                return majorIndex;
            }
        }

        private string GetUriSuffix(MajorIndexType indexType)
        {
            switch (indexType)
            {
                case MajorIndexType.DowJones:
                    return ".DJI";
                case MajorIndexType.Nasdaq:
                    return "IXic";
                case MajorIndexType.SP500:
                    return ".INX";
                default:
                    return ".DJI";
            }
        }
    }
}