namespace WebAPIJsonDataMaker.Models.GW0020.Request
{
    public class HurikomiJikkoYokyu
    {
        public int kakuninJikkoKubun { get; set; }
        public string hurikomiShiteibi { get; set; }
        public long hurikomiKingaku { get; set; }
        public int tesuryoSashihikiHyoji { get; set; }
        public int tesuryokonoHyoji { get; set; }
        public int hurikomisakitorokuyoHyoji { get; set; }
        public int uketorininShiteiKubun { get; set; }
        public int uketorininTenyuryokuHyoji { get; set; }
        public long kakuninjiTesuryoKingaku { get; set; }
        public string chokkinkozakakuninTRXID { get; set; }
        public int torokuBango { get; set; }
        public IraininJoho IraininJoho { get; set; }
        public UketorininJoho UketorininJoho { get; set; }
    }
}