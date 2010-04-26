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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
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
            String InterfaceURL = "https://interface.demo.gta-travel.com/gtaapi/RequestListenerServlet";
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
            WebRequest HttpWReq = WebRequest.Create(InterfaceURL);

            HttpWReq.ContentType = "text/xml";
            HttpWReq.ContentLength = XMLDoc.OuterXml.Length;
            HttpWReq.Method = "POST";

            Stream StreamData = HttpWReq.GetRequestStream();
            StreamData.Write(byte1, 0, byte1.Length);

            //XMLDoc.Save("F:\\request.xml");

            //Get response
            WebResponse HttpWRes = HttpWReq.GetResponse();
            Stream receiveStream = HttpWRes.GetResponseStream();
        }
    }
}