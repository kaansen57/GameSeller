using GameSeller.Abstracts;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Adapters
{
    public class MernisPersonCheck : IGamerMernisCheckService
    {

        public bool GamerCheck(Gamer gamer)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            
            TCKimlikNoDogrulaRequestBody body = new TCKimlikNoDogrulaRequestBody(
                (Convert.ToInt64(gamer.TcNo)), 
                gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(), 
                gamer.DateOfBirth.Year);
            TCKimlikNoDogrulaRequest req = new TCKimlikNoDogrulaRequest(body);

            return  client.TCKimlikNoDogrulaAsync(req).Result.Body.TCKimlikNoDogrulaResult;

        }


    }
}
