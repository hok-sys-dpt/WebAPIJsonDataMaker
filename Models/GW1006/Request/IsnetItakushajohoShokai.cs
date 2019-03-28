using WebAPIJsonDataMaker.Models.GW1006;

namespace WebAPIJsonDataMaker.Models.GW1006.Request
{
    public class IsnetItakushajohoShokai
    {
        public int keiyakushaId { get; set; }
        public int riyoshaId { get; set; }
        public KurikaeshiSeigyo KurikaeshiSeigyo { get; set; }
    }
}