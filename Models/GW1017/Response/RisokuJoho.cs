namespace WebAPIJsonDataMaker.Models.GW1017.Response
{
    public class RisokuJoho
    {
        public int risokuIriharaiKubun { get; set; }
        public long risoku { get; set; }
        public int risokuKeisanKikan { get; set; }
        public string keisanKaishibi { get; set; }
        public string keisanShuryobi { get; set; }
        public decimal riritsu { get; set; }
        public int teireibunRisokuKikan { get; set; }
        public string teireibunRisokuKikanKaishibi { get; set; }
        public string teireibunRisokuKikanShuryobi { get; set; }
        public int kijitsugoRisokuKikan { get; set; }
        public string kijitsugoRisokuKikanKaishibi { get; set; }
        public string kijitsugoRisokuKikanShuryobi { get; set; }
        public long teireibunRisoku { get; set; }
        public decimal teireibunRiritsu { get; set; }
        public long kijitsugoRisoku { get; set; }
        public decimal kijitsugoRiritsu { get; set; }
    }
}