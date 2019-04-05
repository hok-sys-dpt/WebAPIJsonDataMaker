namespace WebAPIJsonDataMaker.Models.GW0022.Request
{
    public class GaikaFurikae
    {
        public int sokujiyoyakuKubun{ get; set; }
        public int kakuninJikkoKubun{ get; set; }
        public int shukkinKozaTemban{ get; set; }
        public int shukkinKozaKamokuCode{ get; set; }
        public int shukkinKozaKozabango{ get; set; }
        public string shukkinKozaTsukaCode{ get; set; }
        public int nyukinKozaTemban{ get; set; }
        public int nyukinKozaKamokuCode{ get; set; }
        public int nyukinKozaKozabango{ get; set; }
        public string nyukinKozaTsukaCode{ get; set; }
        public int baibaiKubun{ get; set; }
        public string kohyoKawaseSobaTsukaCode{ get; set; }
        public decimal? kohyoKawaseSoba{ get; set; }
        public string torihikiKingakuTsukaCode{ get; set; }
        public long enkagaku{ get; set; }
        public decimal? gaikagaku{ get; set; }
        public int moshikomiCancelKubun{ get; set; }
        public decimal? moshikomiCancelSobaHaba{ get; set; }
        public KensaKomoku KensaKomoku{ get; set; }
    }
}