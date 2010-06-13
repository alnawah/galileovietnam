using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
//Add references
using System.Xml;
using System.Text;
using System.Net;
using System.IO;

namespace SearchHotelPrice.Controls
{
    public partial class SearchHotelPriceControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string DownloadRoomTypeXml()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Request>"
                         + "<Source> "
                         + "  <RequestorID Client=\"73\" EMailAddress=\"XML@GALILEOVIETNAM.COM\" Password=\"PASS\"/>"
                         + "  <RequestorPreferences Language=\"en\">"
                         + "      <RequestMode>SYNCHRONOUS</RequestMode>"
                         + "  </RequestorPreferences>"
                         + "</Source>"
                         + "<RequestDetails>"
                         + "    <SearchRoomTypeRequest />"
                         + "</RequestDetails>"
                         + "</Request>";
            return xml;
        }

        protected void btnSearch1_Click(object sender, EventArgs e)
        {
            string XMLReqest = DownloadRoomTypeXml();
            string InterfaceURL = "https://interface.demo.gta-travel.com/rbsthapi/RequestListenerServlet";// "https://interface.demo.gta-travel.com/gtaapi/hInfo";

            // Get request XML
            byte[] requestXML = new UTF8Encoding().GetBytes(XMLReqest);

            // Set Request Headers to specify the content type and allow the response to be gzip compressed
            HttpWebRequest HttpWReq = (HttpWebRequest)HttpWebRequest.Create(InterfaceURL);
            HttpWReq.ContentType = "text/xml";
            //HttpWReq.Headers["Accept-Encoding"] = "gzip";
            HttpWReq.Method = "POST";


            // Sending the request to the server
            HttpWReq.Timeout = 600000;
            Stream StreamData = HttpWReq.GetRequestStream();
            StreamData.Write(requestXML, 0, requestXML.Length);
            StreamData.Close();

            // Process the response from the server
            HttpWebResponse HttpWRes = (HttpWebResponse)HttpWReq.GetResponse();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            /*
            XmlDocument XMLDoc = new XmlDocument();
            XmlElement XMLRequest;
            XmlElement XMLHeader;
            XmlElement XMLBody;
            XmlElement XMLNode;
            XmlElement XMLChildNode;
            XmlElement XMLGrandChild;
            String ClientID = txtClientID.Text;
            String Language = txtClientLanguage.Text;
            String EmailAddress = txtClientEmail.Text;
            String ClientPassword = txtClientPassword.Text;
            //String InterfaceURL = "https://interface.demo.gta-travel.com/gtaapi/RequestListenerServlet";
            String InterfaceURL = "https://interface.demo.gta-travel.com/rbsthapi/RequestListenerServlet";
            String ResponseURL = "https://10.100.21.131/receiveRequest.asp";

            //Create XML
            //Create request
            XMLRequest = XMLDoc.CreateElement("Request");
            XMLHeader = XMLDoc.CreateElement("Source");
            //Client details node
            XMLNode = XMLDoc.CreateElement("RequestorID");
            XMLNode.SetAttribute("Client", ClientID);
            XMLNode.SetAttribute("EMailAddress", EmailAddress);
            XMLNode.SetAttribute("Password", ClientPassword);
            XMLHeader.AppendChild(XMLNode);
            //Client preference node
            XMLNode = XMLDoc.CreateElement("RequestorPreferences");
            XMLNode.SetAttribute("Language", Language);
            XMLChildNode = XMLDoc.CreateElement("RequestMode");
            XMLChildNode.InnerText = "SYNCHRONOUS";
            XMLNode.AppendChild(XMLChildNode);
            XMLHeader.AppendChild(XMLNode);
            //Create request body
            XMLBody = XMLDoc.CreateElement("RequestDetails");
            XMLNode = XMLDoc.CreateElement("SearchHotelPriceRequest");
            XMLChildNode = XMLDoc.CreateElement("ItemDestination");
            XMLChildNode.SetAttribute("DestinationType", "city");
            XMLChildNode.SetAttribute("DestinationCode", txtDestinationCode.Text.ToUpper());
            XMLNode.AppendChild(XMLChildNode);
            XMLChildNode = XMLDoc.CreateElement("PeriodOfStay");
            XMLGrandChild = XMLDoc.CreateElement("CheckInDate");
            XMLGrandChild.InnerText = txtCheckInDate.Text;
            XMLChildNode.AppendChild(XMLGrandChild);
            XMLGrandChild = XMLDoc.CreateElement("Duration");
            XMLGrandChild.InnerText = "2";
            XMLChildNode.AppendChild(XMLGrandChild);
            XMLNode.AppendChild(XMLChildNode);
            XMLChildNode = XMLDoc.CreateElement("Rooms");
            XMLGrandChild = XMLDoc.CreateElement("Room");
            XMLGrandChild.SetAttribute("Code", txtRoomType.Text.ToLower());
            XMLGrandChild.SetAttribute("NumberOfRooms", txtNumOfRoom.Text);
            XMLChildNode.AppendChild(XMLGrandChild);
            XMLNode.AppendChild(XMLChildNode);
            XMLBody.AppendChild(XMLNode);
            //Create XML document
            XMLRequest.AppendChild(XMLHeader);
            XMLRequest.AppendChild(XMLBody);
            XMLDoc.AppendChild(XMLRequest);
            //Post document 
            ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            Byte[] byte1 = encoding.GetBytes(XMLDoc.OuterXml);
             * */
            string xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>"
                + "<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">"
                + "<soap:Body>"
               + "<Register xmlns=\"http://tempuri.org/\">"
                  + "<user>"
                   + " <UserName>phamhai</UserName>"
                    + "<Password>3456732</Password>"
                    + "<FirstName>Pham</FirstName>"
                    + "<LastName>Hong Hai</LastName>"
                    + "<Address>Viet Tri</Address>"
                    + "<Email>test@yahoo.com</Email>"
                    + "<TotalScore>4587</TotalScore>"
                    + "<Credit>77777</Credit>"
                    + "<Turn>79</Turn>"
                    + "<Turned>79</Turned>"
                    + "<Status>OK</Status>"
                  + "</user>"
                + "</Register>"
                + "</soap:Body>"
                + " </soap:Envelope>";


            byte[] requestXML = new UTF8Encoding().GetBytes(xml);






            String InterfaceURL = "http://localhost:1847/SanFoxServices.asmx?op=Register";
            HttpWebRequest HttpWReq = (HttpWebRequest)HttpWebRequest.Create(InterfaceURL);
            
            HttpWReq.ContentType = "text/xml";
            HttpWReq.Headers["Accept-Encoding"] = "gzip";
            HttpWReq.Method = "POST";


            // Sending the request to the server
            HttpWReq.Timeout = 600000;
            Stream StreamData = HttpWReq.GetRequestStream();
            StreamData.Write(requestXML, 0, requestXML.Length);
            StreamData.Close();
            /*
            HttpWReq.ContentType = "text/xml";
            HttpWReq.ContentLength = XMLDoc.OuterXml.Length;
            HttpWReq.Method = "POST";

            HttpWReq.Timeout = 600000;
            Stream StreamData = HttpWReq.GetRequestStream();
            StreamData.Write(byte1, 0, byte1.Length);
            StreamData.Close();

            XMLDoc.Save("D:\\request.xml");
            */
            //Get response
            HttpWebResponse HttpWRes = (HttpWebResponse)HttpWReq.GetResponse();
            Stream receiveStream = HttpWRes.GetResponseStream();

            StreamReader reader = new StreamReader(receiveStream);
            // Read the content.
            //reader.en
            string responseFromServer = reader.ReadToEnd();
            //XmlDocument xml = new XmlDocument();
            //xml.
        }
    }
}