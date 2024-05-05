using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace ControllerGUI.Data
{
    internal class udp
    {

        public double Sp;
        public double Cv;
        public double Pv;

        private void ParseData(string json)
        {
            var data = JsonConvert.DeserializeObject<dynamic>(json);
            if(data != null )
            {
                Sp = data.Sp;
                Cv = data.Cv;
                Pv = data.Pv;
                Debug.WriteLine($"Received response: {data}");
            }
        }
        public bool PingDevice(string host, int timeout)
        {
            try
            {
                using (Ping pinger = new Ping())
                {
                    PingReply reply = pinger.Send(host, timeout); // Timeout in milliseconds
                    if (reply.Status == IPStatus.Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (PingException ex)
            {
                // Handle any exceptions related to the Ping operation
                Debug.WriteLine($"Ping failed: {ex.Message}");
                return false;
            }
        }
        public void SendUdpMessage(string message, string serverIp, int serverPort, int timeout)
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    // Convert the message to bytes
                    byte[] messageBytes = Encoding.ASCII.GetBytes(message);
                    // Send the message
                    udpClient.Send(messageBytes, messageBytes.Length, serverIp, serverPort);
                    Debug.WriteLine($"Message sent to {serverIp}:{serverPort}");

                    // Receive a response from the server
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    // Blocks until a message returns on this socket from a remote host.
                    byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    ParseData(Encoding.UTF8.GetString(receiveBytes));
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                }
                finally
                {
                    // Close the connection
                    udpClient.Close();
                }
            }
        }
    }
}
