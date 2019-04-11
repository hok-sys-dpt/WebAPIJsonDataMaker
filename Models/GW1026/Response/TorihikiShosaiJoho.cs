namespace WebAPIJsonDataMaker.Models.GW1026.Response
{
    public class TorihikiShosaiJoho
    {
        public int shukkinKozaTemban{ get; set; }
        public string shukkinKozaTenmei{ get; set; }
        public int shukkinKozaKamokuCode{ get; set; }
        public int shukkinKozaKozabango{ get; set; }
        public string shukkinKozaTsukaCode{ get; set; }
        public int nyukinKozaTemban{ get; set; }
        public string nyukinKozaTenmei{ get; set; }
        public int nyukinKozaKamokuCode{ get; set; }
        public int nyukinKozaKozabango{ get; set; }
        public string nyukinKozaTsukaCode{ get; set; }
        public TorihikiKekka TorihikiKekka{ get; set; }

        public TorihikiShosaiJoho()
        {
            TorihikiKekka = new TorihikiKekka();
        }
    }
}