namespace WebAPIJsonDataMaker.Models.GW1024.Response
{
    public class BizIbTeikiJyokyoShokai
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public TorihikiJoho TorihikiJoho { get; set; }
        public TorihikiShosaiJoho TorihikiShosaiJoho { get; set; }
        public RisokuKeisansho RisokuKeisansho { get; set; }
    }
}