namespace TaskManagerAPI.Web.Dtos.BaseDto
{
    public class PersonRequest
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public IFormFile File { get; set; }
    }
}
