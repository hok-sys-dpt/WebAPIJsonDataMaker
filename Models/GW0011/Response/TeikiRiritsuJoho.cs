namespace WebAPIJsonDataMaker.Models.GW0011.Response
{
    public class TeikiRiritsuJoho
    {
        public int teikiRiritsuKingakubetsuKakunosu { get; set; }
        public TeikiRiritsuKingakubetsu[] TeikiRiritsuKingakubetsu { get; set; }

        public TeikiRiritsuJoho()
        {
            const int MaxItemCount = 10;
            TeikiRiritsuKingakubetsu = new TeikiRiritsuKingakubetsu[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                TeikiRiritsuKingakubetsu[count] = new TeikiRiritsuKingakubetsu();
            }
        }
    }
}