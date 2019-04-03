namespace WebAPIJsonDataMaker.Models.GW1015.Request
{
    public class SenyotozakashikoshiKaishuYoyaku
    {
        public int kakuninJikkoKubun { get; set; }
        public int keiyakushaId { get; set; }
        public int riyoshaId { get; set; }
        public int temban { get; set; }
        public int cifBango { get; set; }
        public int kamokuCode { get; set; }
        public int toriatsukaiBango { get; set; }
        public int torokuKubun { get; set; }
        public string hensaiShiteibi { get; set; }
        public long hensaiMoshikomiKingaku { get; set; }
    }
}