using KYSProjectApi.Services.TCKimlikService;
using Microsoft.Extensions.Primitives;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

public class TCKimlikService : ITCKimlikService
{
    public async Task<bool> VerifyTcKimlikNoAsync(string tcKimlikNo, string ad, string soyad, DateTime dogumTarihi)
    {
        var longTc = long.Parse(tcKimlikNo);
        var dogumYili = (int)dogumTarihi.Year;
        string soapMessage = $@"
                <soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                    <soap:Body>
                        <TCKimlikNoDogrula xmlns=""http://tckimlik.nvi.gov.tr/WS"">
                            <TCKimlikNo>{longTc}</TCKimlikNo>
                            <Ad>{ad}</Ad>
                            <Soyad>{soyad}</Soyad>
                            <DogumYili>{dogumYili}</DogumYili>
                        </TCKimlikNoDogrula>
                    </soap:Body>
                </soap:Envelope>"
                ;

        // SOAP isteği gönderme
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx");
        request.Headers.Add("SOAPAction", "\"http://tckimlik.nvi.gov.tr/WS/TCKimlikNoDogrula\"");
        request.ContentType = "text/xml;charset=\"utf-8\"";
        request.Accept = "text/xml";
        request.Method = "POST";

        using (Stream stream = request.GetRequestStream())
        {
            byte[] soapBytes = Encoding.UTF8.GetBytes(soapMessage);
            stream.Write(soapBytes, 0, soapBytes.Length);
        }

        using (WebResponse response = request.GetResponse())
        {
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string result = reader.ReadToEnd();
                if (result.Contains("<TCKimlikNoDogrulaResult>true</TCKimlikNoDogrulaResult>"))
                    return true;
                
                return false;
            }
        }
    }
}



