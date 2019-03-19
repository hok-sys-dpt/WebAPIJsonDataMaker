namespace WebAPIJsonDataMaker.Models.GW0057.Response
{
    public class HurikomiJikkoOto
    {
        public int kakuninJikkoKubun { get; set; }
        public string hurikomiShiteibi { get; set; }
        public long hurikomiKingaku { get; set; }
        public long tesuryoKingaku { get; set; }
        public int konoKeiyakuHyoji { get; set; }
        public int meisaiBango { get; set; }
        public int tesuryoSashihikiHyoji { get; set; }
        public int tesuryokonoHyoji { get; set; }
        public int hurikomisakitorokuyoHyoji { get; set; }
        public int hurumaiShijiKodo { get; set; }
        public IraininJoho IraininJoho { get; set; }
        public UketorininJoho UketorininJoho { get; set; }
    }
}