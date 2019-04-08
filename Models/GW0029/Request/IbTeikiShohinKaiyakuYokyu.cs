namespace WebAPIJsonDataMaker.Models.GW0029.Request
{
    public class IbTeikiShohinKaiyakuYokyu
    {
        public int shohinShubetsu { get; set; }
        public int nyukinKozaTemban { get; set; }
        public int nyukinKozaKamokuCode { get; set; }
        public int nyukinKozabango { get; set; }
        public int teikiTemban { get; set; }
        public int teikiKamokuCode { get; set; }
        public int teikiKamokuCodechiwake { get; set; }
        public int teikiKozabango { get; set; }
        public int yonyuBango { get; set; }
        public long uketsukeKingaku { get; set; }
        public int kakuninJikkoKubun { get; set; }
        public string shiharaibi { get; set; }
    }
}