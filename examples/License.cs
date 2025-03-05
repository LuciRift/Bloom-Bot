
// This example demonstrates how to send a license request to the License Server

using System;
using System.Net;
using System.IO;

namespace CurlExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://<your_ip>:<port>/api/client";
            string apiKey = "API_KEY";
            string license = "<LICENSE>";
            string product = "<PRODUCT>";
            string version = "<VERSION>";

            string postData = "license=" + license + "&product=" + product + "&version=" + version;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Headers.Add("Authorization", apiKey);

            byte[] data = System.Text.Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);
            stream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            Console.WriteLine(responseString);
        }
    }
}

// To send the IP and HWID to the server

using System;
using System.Net;
using System.IO;

namespace CurlExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://<your_ip>:<port>/api/client";
            string apiKey = "API_KEY";
            string license = "<LICENSE>";
            string product = "<PRODUCT>";
            string version = "<VERSION>";
            string ip = "<IP>";
            string hwid = "<HWID>";

            string postData = "license=" + license + "&product=" + product + "&version=" + version + "&ip=" + ip + "&hwid=" + hwid;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Headers.Add("Authorization", apiKey);

            byte[] data = System.Text.Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);
            stream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            Console.WriteLine(responseString);
        }
    }
}
