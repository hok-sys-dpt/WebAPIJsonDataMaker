namespace WebAPIJsonDataMaker.Models.GW1027.Response
{
    public class BizIbMpnJokyoShokai
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public TorihikiJoho TorihikiJoho { get; set; }
        public TorihikiShosaiJoho TorihikiShosaiJoho { get; set; }
        public ShukkinKoza ShukkinKoza { get; set; }

        public BizIbMpnJokyoShokai()
        {
            TorihikiJoho = new TorihikiJoho();
            TorihikiShosaiJoho = new TorihikiShosaiJoho();
            ShukkinKoza = new ShukkinKoza();
        }
    }
}