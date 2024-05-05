using ControllerGUI.Data;

namespace ControllerGUI
{
    public class DataAccessLayer
    {
        udp UDP_PID1 = new udp();
        Sql_db db_Con = new Sql_db();

        public string hostIP = "192.168.9.10";
        public int hostPort = 20001;
        public int timeOutMS = 5000;

        public bool ConOK() => UDP_PID1.PingDevice(hostIP, timeOutMS);
        public void Send_UDP_Package(string message)
        {
            UDP_PID1.SendUdpMessage(message, hostIP, hostPort, timeOutMS);
            WriteDb(UDP_PID1.Pv, "TT01");
            WriteDb(UDP_PID1.Sp, "PID1_SP");
            WriteDb(UDP_PID1.Cv, "PID1_CV");
        }
        private void WriteDb(double value, string tagName) => db_Con.WriteDb(value, tagName);
        public string getTagValue(string tagName) => db_Con.ReadLastSample(tagName);

        public (List<double>, List<string>) GetDataList(int numSamples, string TagName) => db_Con.GetDataList(numSamples, TagName);
    }
}
