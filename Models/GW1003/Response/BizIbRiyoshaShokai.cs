namespace WebAPIJsonDataMaker.Models.GW1003.Response
{
    public class BizIbRiyoshaShokai
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public int temban { get; set; }
        public int kamokuCode { get; set; }
        public int kozabango { get; set; }
        public int karenTemban { get; set; }
        public int kanrenKamokuCode { get; set; }
        public int kanrenKozabango { get; set; }
        public int riyoshasu { get; set; }
        public RiyoshaJoho[] RiyoshaJoho { get; set; }

        public BizIbRiyoshaShokai()
        {
            const int MaxItemCount = 100;
            RiyoshaJoho = new RiyoshaJoho[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                RiyoshaJoho[count] = new RiyoshaJoho();
            }
        }
    }


}