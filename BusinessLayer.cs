using Newtonsoft.Json;
using System.Diagnostics;
namespace ControllerGUI
{
    public class BusinessLayer
    {
        DataAccessLayer Data_Layer = new DataAccessLayer();

        public decimal Kp;
        public decimal Ti;
        public decimal Td;
        public decimal Max_Sp;
        public decimal HH;
        public decimal H;
        public decimal L;
        public decimal LL;
        public bool AutoMode;
        public bool ManMode;
        public bool Start;
        public bool Stop;
        public bool AckAlm;
        public decimal Sp;
        public decimal Man_CV;

        public bool ConOK;
        private string BuildDataString()
        {
            var Data = new
            {
                Kp = Kp,
                Ti = Ti,
                Td = Td,
                Max_Sp = Max_Sp,
                HH = HH,
                H = H,
                L = L,
                LL = LL,
                AutoMode = AutoMode,
                ManMode = ManMode,
                Start = Start,
                Stop = Stop,
                AckAlm = AckAlm,
                Sp = Sp,
                Man_CV = Man_CV,
            };
           return JsonConvert.SerializeObject(Data);
        }
        public void CheckCon()
        {
            ConOK = Data_Layer.ConOK();
            Debug.WriteLine("Ping: " + ConOK);
            Debug.WriteLine(BuildDataString());
        }
        public void SendDatPackage()
        {
            Data_Layer.Send_UDP_Package(BuildDataString());
        }

        public string Get_PV() => Data_Layer.getTagValue("TT01");
        public string Get_CV() => Data_Layer.getTagValue("PID1_CV");
        public string Get_SP() => Data_Layer.getTagValue("PID1_SP");


        public (List<double>, List<string>) GetDataList(int numSamples, string TagName)
        {
            return Data_Layer.GetDataList(numSamples, TagName);
        }
    }
}
