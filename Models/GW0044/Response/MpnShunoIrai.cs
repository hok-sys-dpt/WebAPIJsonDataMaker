namespace WebAPIJsonDataMaker.Models.GW0044.Response
{
    public class MpnShunoIrai
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public int shunokikanShubetsu { get; set; }
        public int nohuHoshiki { get; set; }
        public int haraikomisakiHyojiKubun { get; set; }
        public string shunokikanmeiKana { get; set; }
        public string shunokikanmeiKanji { get; set; }
        public int riyoshameiHyojiKubun { get; set; }
        public string riyoshameiKana { get; set; }
        public string riyoshameiKanji { get; set; }
        public string minkanOkyakusamaBango { get; set; }
        public string minkanKakuninBango { get; set; }
        public int minkanSeikyuNaiyoHyojiKubun { get; set; }
        public string minkanSeikyuNaiyoKana { get; set; }
        public string minkanSeikyuNaiyoKanji { get; set; }
        public long minkanHaraikomiGokeiKingaku { get; set; }
        public long minkanSeikyuGokeiKingaku { get; set; }
        public long minkanSeikyuKingaku { get; set; }
        public string minkanSeikyuBango { get; set; }
        public int minkanShohizeigakuHyojiKubun { get; set; }
        public long minkanShohizei { get; set; }
        public int minkanEntaikinHyojiKubun { get; set; }
        public int minkanEntaikin { get; set; }
        public int minkanTesuryoHyojiKubun { get; set; }
        public long minkanRiyoshaHutanTesuryo { get; set; }
        public int minkanRenraku1HyojiKubun { get; set; }
        public string minkanRenrakuJiko1Kana { get; set; }
        public string minkanRenrakuJiko1Kanji { get; set; }
        public int minkanRenraku2HyojiKubun { get; set; }
        public string minkanRenrakuJiko2Kana { get; set; }
        public string minkanRenrakuJiko2Kanji { get; set; }
        public string chikotaiNohuBango { get; set; }
        public string chikotaiKakuninBango { get; set; }
        public string chikotaiNohuKubun { get; set; }
        public int chikotaiNohuNaiyoHyojiKubun { get; set; }
        public string chikotaiNohuNaiyoKana { get; set; }
        public string chikotaiNohuNaiyoKanji { get; set; }
        public long chikotaiHaraikomiGokeiKingaku { get; set; }
        public long chikotaiNohuGokeiKingaku { get; set; }
        public long chikotaiNohuKingaku { get; set; }
        public string chikotaiShikibetsuBango { get; set; }
        public int chikotaiEntaikinHyojiKubun { get; set; }
        public int chikotaiEntaikin { get; set; }
        public int chikotaiTesuryoHyojiKubun { get; set; }
        public long chikotaiRiyoshaHutanTesuryo { get; set; }
        public int chikotaiRenraku1HyojiKubun { get; set; }
        public string chikotaiRenrakuJiko1Kana { get; set; }
        public string chikotaiRenrakuJiko1Kanji { get; set; }
        public int chikotaiRenraku2HyojiKubun { get; set; }
        public string chikotaiRenrakuJiko2Kana { get; set; }
        public string chikotaiRenrakuJiko2Kanji { get; set; }
        public string kokkokinNohuBango { get; set; }
        public string kokkokinKakuninBango { get; set; }
        public string kokkokinNohuKubun { get; set; }
        public int kokkokinNohuNaiyoHyojiKubun { get; set; }
        public string kokkokinNohuNaiyoKana { get; set; }
        public string kokkokinNohuNaiyoKanji { get; set; }
        public long kokkokinHaraikomigokeiKingaku { get; set; }
        public long kokkokinNohugokeiKingaku { get; set; }
        public long kokkokinNohuKingaku { get; set; }
        public int kokkokinEntaikinHyojiKubun { get; set; }
        public long kokkokinNaiEntaikin { get; set; }
        public int kokkokinTesuryoHyojiKubun { get; set; }
        public long kokkokinnaiTesuryo { get; set; }
        public ShukkinKoza ShukkinKoza { get; set; }

        public MpnShunoIrai()
        {
            ShukkinKoza = new ShukkinKoza();
        }
    }
}