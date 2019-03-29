namespace WebAPIJsonDataMaker.Models.GW0026.Response
{
    public class IbTeikiMeisaiShokaiOto
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public int temban { get; set; }
        public string tenmei { get; set; }
        public int kamokuCode { get; set; }
        public int kamokuCodeUchiwake { get; set; }
        public string kamokumei { get; set; }
        public int kozabango { get; set; }
        public int otoKensu { get; set; }
        public MeisaiItem[] MeisaiItem { get; set; }
        public int keiyakushaId { get; set; }

        public IbTeikiMeisaiShokaiOto()
        {
            const int MaxItemCount = 60;
            MeisaiItem = new MeisaiItem[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                MeisaiItem[count] = new MeisaiItem();
            }
        }
    }
}