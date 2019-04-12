using WebAPIJsonDataMaker.Models.GW1008;

namespace WebAPIJsonDataMaker.Models.GW1008.Request
{
    public class BizIbNyushukkinMeisaiShokai : IKurikaeshiSeigyo
    {
        public int keiyakushaId{ get; set; }
        public int temban{ get; set; }
        public int kamokuCode{ get; set; }
        public int kozabango{ get; set; }
        public string kaishibi{ get; set; }
        public string shuryobi{ get; set; }
        public string torihikibi{ get; set; }
        public int sequence{ get; set; }
        public KurikaeshiSeigyo KurikaeshiSeigyo { get; set; }
        public int otoKensu { get; set; }
    }
}