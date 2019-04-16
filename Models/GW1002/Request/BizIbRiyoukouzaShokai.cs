using WebAPIJsonDataMaker.Models.GW1002;

namespace WebAPIJsonDataMaker.Models.GW1002.Request
{
    public class BizIbRiyoukozaShokai
    {
        public int keiyakushaId { get; set; }
        public int riyoshaId { get; set; }
        public int taishoKubun { get; set; }
        public KurikaeshiSeigyo KurikaeshiSeigyo { get; set; }
    }
}