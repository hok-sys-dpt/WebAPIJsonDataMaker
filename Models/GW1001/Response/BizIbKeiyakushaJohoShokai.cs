namespace WebAPIJsonDataMaker.Models.GW1001.Response
{
       public class BizIbKeiyakushaJohoShokai
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public int keiyakushaId { get; set; }
        public int temban { get; set; }
        public int kamokuCode { get; set; }
        public int kozaBango { get; set; }
        public KokyakuJoho KokyakuJoho { get; set; }
        public BizIbKeiyakushaJoho BizIbKeiyakushaJoho { get; set; }
    }
}