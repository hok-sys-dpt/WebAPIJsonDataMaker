namespace WebAPIJsonDataMaker.Models.GW0044.Request
{
    public class KokkokinNohuJoho
    {
        public string kokkokinNohuNaiyoKana { get; set; }
        public string kokkokinNohuNaiyoKanji { get; set; }
        public long kokkokinHaraikomigokeiKingaku { get; set; }
        public long kokkokinNohugokeiKingaku { get; set; }
        public long kokkokinNohuKingaku { get; set; }
        public int kokkokinnaiEntaikinHyojiKubun { get; set; }
        public long kokkokinNaiEntaikin { get; set; }
        public int kokkokinnaiTesuryoHyojiKubun { get; set; }
        public long kokkokinnaiTesuryo { get; set; }
        public int kokkokinGamenKubun { get; set; }
    }
}