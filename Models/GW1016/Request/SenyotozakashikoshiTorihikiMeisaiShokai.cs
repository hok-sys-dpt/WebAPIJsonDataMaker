using WebAPIJsonDataMaker.Models.GW1016;

namespace WebAPIJsonDataMaker.Models.GW1016.Request
{
    public class SenyotozakashikoshiTorihikiMeisaiShokai
    {
        public int keiyakushaId { get; set; }
        public int riyoshaId { get; set; }
        public int temban { get; set; }
        public int kamokuCode { get; set; }
        public int cifBango { get; set; }
        public int toriatsukaiBango { get; set; }
        public KurikaeshiSeigyo KurikaeshiSeigyo { get; set; }
    }
}