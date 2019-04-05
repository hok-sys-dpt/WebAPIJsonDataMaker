namespace WebAPIJsonDataMaker.Models.GW1026.Response
{
    public class TorihikiShosaiJoho
    {
        public int shukkinKozaTemban{ get; set; }
        public string shukkinKozaTenmei{ get; set; }
        public int shukkinKozaKamokuCode{ get; set; }
        public string shukkinKozaKamokuMeisho{ get; set; }
        public int shukkinKozaKozabango{ get; set; }
        public string shukkinKozaTsukaCode{ get; set; }
        public string shukkinKozaTsukaMeisho{ get; set; }
        public int nyukinKozaTemban{ get; set; }
        public string nyukinKozaTenmei{ get; set; }
        public int nyukinKozaKamokuCode{ get; set; }
        public string nyukinKozaKamokuMeisho{ get; set; }
        public int nyukinKozaKozabango{ get; set; }
        public string nyukinKozaTsukaCode{ get; set; }
        public string nyukinKozaTsukaMeisho{ get; set; }
        public Irainaiyo Irainaiyo{ get; set; }
        public TorihikiKekka TorihikiKekka{ get; set; }
        public int moshikomiCancelKubun{ get; set; }
        public decimal? moshikomiCancelSoba{ get; set; }
        public GaikateikiJoho GaikateikiJoho{ get; set; }

        public TorihikiShosaiJoho()
        {
            Irainaiyo = new Irainaiyo();
            TorihikiKekka = new TorihikiKekka();
            GaikateikiJoho = new GaikateikiJoho();
        }
    }
}