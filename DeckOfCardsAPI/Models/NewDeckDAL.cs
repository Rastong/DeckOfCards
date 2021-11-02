using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DeckOfCardsAPI.Models
{
    public class NewDeckDAL
    {
        public NewDeckModel GetData()
        {
            string url = $"https://deckofcardsapi.com/api/deck/new/";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            NewDeckModel result = JsonConvert.DeserializeObject<NewDeckModel>(JSON);

            return result;
        }
    }
}
