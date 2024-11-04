namespace ThymeAssessment.Models
{
    public class ResponseModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public List<object> Data { get; set; }
    
    }
}
