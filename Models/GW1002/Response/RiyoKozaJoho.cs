namespace WebAPIJsonDataMaker.Models.GW1002.Response
{
    public class RiyoKozaJoho
    {
        public int daihyoKozaHyoji { get; set; }
        public int temban { get; set; }
        public string tenmeiKana { get; set; }
        public string tenmeiKanji { get; set; }
        public int kamokuCode { get; set; }
        public int kamokuCodeUchiwake { get; set; }
        public string kamokumeiKanji { get; set; }
        public int kozabango { get; set; }
        public int cifBango { get; set; }
        public long orgId { get; set; }
        public string kozameigiKana { get; set; }
        public string sakuinyoKozameigiKana { get; set; }
        public string kozameigiKanji { get; set; }
        public string tsukaCode { get; set; }
        public int furikomiNyukinTsuchiHyoji { get; set; }
        public string kozaMemo { get; set; }
    }
}