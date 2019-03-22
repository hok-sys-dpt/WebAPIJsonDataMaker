namespace WebAPIJsonDataMaker.Models.GW1025.Response
{
    public class TorihikiShosaiJoho
    {
        public string hurikomiShiteibi { get; set; }
        public long hurikomiKingaku { get; set; }
        public long tesuryoKingaku { get; set; }
        public long tesuryoShohizeigaku { get; set; }
        public int tesuryoShubetsuKodo { get; set; }
        public int tesuryoSashihikiHyoji { get; set; }
        public int tesuryoChoshuKubun { get; set; }
        public int hurikomisakitorokuyoHyoji { get; set; }
        public int uketorininShiteiKubun { get; set; }
        public int uketorininTenyuryokuHyoji { get; set; }
        public string hasshimBango { get; set; }
        public int kiban { get; set; }
        public int uchidamechokusoKubun { get; set; }
        public int uketsukeRemban { get; set; }
        public int torokuBango { get; set; }
        public IraininJoho IraininJoho { get; set; }
        public UketorininJoho UketorininJoho { get; set; }
    }
}