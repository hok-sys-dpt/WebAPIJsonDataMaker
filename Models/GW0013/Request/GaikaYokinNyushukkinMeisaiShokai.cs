namespace WebAPIJsonDataMaker.Models.GW0013.Request
{
    public class GaikaYokinNyushukkinMeisaiShokai : IKurikaeshiSeigyo
    {
        public YokyuJoho YokyuJoho { get; set; }
        public int shokaiDaikoShokaiHyoji { get; set; }
        public KurikaeshiSeigyo KurikaeshiSeigyo { get; set; }
        public KensaKomoku KensaKomoku { get; set; } 
    }
}