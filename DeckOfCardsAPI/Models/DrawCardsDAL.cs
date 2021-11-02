using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DeckOfCardsAPI.Models
{
    public class DrawCardsDAL
    {
        public DrawCardsModel GetData()
        {
            string url = $"https://deckofcardsapi.com/api/deck/new/draw/?count=5";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            DrawCardsModel result = JsonConvert.DeserializeObject<DrawCardsModel>(JSON);

            return result;
        }
    }
}
