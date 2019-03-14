namespace WebAPIJsonDataMaker.Models.GW1001.Response
{
    public class BizIbKeiyakushaJoho
    {
        public int keiyakushaId { get; set; }
        public int saihakkoKaisu { get; set; }
        public int checkdigit { get; set; }
        public int keiyakuType { get; set; }
        public int sougoufurikomiKeiyakuHyoji { get; set; }
        public int kyuyofurikomiKeiyakuHyoji { get; set; }
        public int kozafurikaeKeiyakuHyoji { get; set; }
        public int chihozeiKeiyakuHyoji { get; set; }
        public int isnetKeiyakuHyoji { get; set; }
        public string renrakusakiDenwaBango { get; set; }
        public long hurikomiGendogaku { get; set; }
        public long hurikaeGendogaku { get; set; }
        public long mpnGendogaku { get; set; }
        public long teikiyokinGendogaku { get; set; }
        public long sougoufurikomiGendogaku { get; set; }
        public long kyuyofurikomiGendogaku { get; set; }
        public int jotaiKubun { get; set; }
        public string torokubi { get; set; }
        public string kaijyobi { get; set; }
        public int riyoKozasu { get; set; }
    }
}