namespace Course.Core.exceptions;

public class CustomException
{
    public string Message { get; set; }
    public string StackTrace { get; set; }
    public List<string> Errors { get; set; }
    
    public CustomException(Exception ex)
    {
        Message = ex.Message;
        StackTrace = ex.StackTrace;
        Errors = ex.InnerException?.Message != null ? new List<string> { ex.InnerException.Message } : new List<string>();
    }
}