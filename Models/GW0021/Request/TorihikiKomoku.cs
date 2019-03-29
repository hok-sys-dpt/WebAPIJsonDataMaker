namespace WebAPIJsonDataMaker.Models.GW0021.Request
{
    public class TorihikiKomoku
    {
        public string shikinIdobi { get; set; }
        public int kakuninJikkoKubun { get; set; }
        public int sokujiyoyakuKubun { get; set; }
        public ShukkinKoza ShukkinKoza { get; set; }
        public NyukinKoza NyukinKoza { get; set; }
        public long torihikiKingaku { get; set; }
    }
}