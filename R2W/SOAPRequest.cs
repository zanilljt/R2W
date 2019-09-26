﻿using System;
using System.IO;
using System.Net;
using System.Xml;

namespace R2W
{
    public class SOAPRequest
    {

        //public static string CallWebService()
        //{
        //    var _url = "https://r2wmobile4.running2win.com/api.asmx/l";
        //    var _action = "https://r2wmobile4.running2win.com/api.asmx/login";

        //    XmlDocument soapEnvelopeXml = CreateSoapEnvelope();
        //    HttpWebRequest webRequest = CreateWebRequest(_url, _action);
        //    InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

        //    // begin async call to web request.
        //    IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

        //    // suspend this thread until call is complete. You might want to
        //    // do something usefull here like update your UI.
        //    asyncResult.AsyncWaitHandle.WaitOne();

        //    // get the response from the completed web request.
        //    string soapResult;
        //    //using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
        //    //{
        //    //    using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
        //    //    {
        //    //        soapResult = rd.ReadToEnd();
        //    //    }
        //    //    return soapResult;
        //    //}
        //    //return "Hello World";
        //}

        private static HttpWebRequest CreateWebRequest(string url, string action)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("SOAPAction", action);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        private static XmlDocument CreateSoapEnvelope()
        {
            XmlDocument soapEnvelopeDocument = new XmlDocument();
            soapEnvelopeDocument.LoadXml(@"<SOAP-ENV:Envelope xmlns:SOAP-ENV=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:xsi=""http://www.w3.org/1999/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/1999/XMLSchema""><SOAP-ENV:Body>
                            <HelloWorld xmlns=""http://tempuri.org/"" SOAP-ENV:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
                                <int1 xsi:type=""xsd:integer"">12</int1>
                                <int2 xsi:type=""xsd:integer"">32</int2>
                            </HelloWorld>
                            </SOAP-ENV:Body>
                            </SOAP-ENV:Envelope>");
            return soapEnvelopeDocument;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }
    }
}
