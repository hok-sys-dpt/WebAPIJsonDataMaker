namespace WebAPIJsonDataMaker.Models.GW0047.Request
{
    public class KokkokinNohuJoho
    {
        public string kokkokinNohuNaiyoKana { get; set; }
        public string kokkokinNohuNaiyoKanji { get; set; }
        public long kokkokinNohugokeiKingaku { get; set; }
        public long kokkokinNohuKingaku { get; set; }
        public int kokkokinnaiEntaikinHyojiKubun { get; set; }
        public long kokkokinNaiEntaikin { get; set; }
        public int kokkokinnaiTesuryoHyojiKubun { get; set; }
        public long kokkokinnaiTesuryo { get; set; }
        public int kokkokinGamenHyojiKubun { get; set; }
    }
}