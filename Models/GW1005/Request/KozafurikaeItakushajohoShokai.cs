using WebAPIJsonDataMaker.Models.GW1005;

namespace WebAPIJsonDataMaker.Models.GW1005.Request
{
    public class KozafurikaeItakushajohoShokai
    {
        public int keiyakushaId { get; set; }
        public int riyoshaId { get; set; }
        public KurikaeshiSeigyo KurikaeshiSeigyo { get; set; }
    }
}