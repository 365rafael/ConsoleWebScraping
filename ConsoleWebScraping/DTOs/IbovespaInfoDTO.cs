namespace ConsoleWebScraping.DTOs
{
    public class IbovespaInfoDTO
    {
        public IbovespaInfoDTO()
        {
        }

        public IbovespaInfoDTO(string totalPoints, string percentageVariation)
        {
            TotalPoints = totalPoints;
            PercentageVariation = percentageVariation;
        }

        public string TotalPoints { get; set; }

        public string PercentageVariation { get; set; }
    }
}
