namespace CvSystem.Api.Response
{

    public class PersonalInformationDto
    {
       public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string CityName { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public string? EmailAddress { get; set; }
    }
}