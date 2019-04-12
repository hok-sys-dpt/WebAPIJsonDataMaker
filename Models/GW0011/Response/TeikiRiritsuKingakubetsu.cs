namespace WebAPIJsonDataMaker.Models.GW0011.Response
{
    public class TeikiRiritsuKingakubetsu
    {
        public decimal? teikiRiritsuKagenKingaku { get; set; }
        public decimal? teikiRiritsuJogenKingaku { get; set; }
        public int teikiRiritsuKikambetsuKakunosu { get; set; }
        public TeikiRiritsuKikambetsu[] TeikiRiritsuKikambetsu { get; set; }

        public TeikiRiritsuKingakubetsu()
        {
            const int MaxItemCount = 20;
            TeikiRiritsuKikambetsu = new TeikiRiritsuKikambetsu[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                TeikiRiritsuKikambetsu[count] = new TeikiRiritsuKikambetsu();
            }
        }
    }
}