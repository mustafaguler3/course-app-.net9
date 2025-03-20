namespace Course.Business.DTOs.Response;

public class AuthResponseDto
{
    public bool Success { get; set; }
    public string? Token { get; set; }
    public string? Message { get; set; }
    public List<string>? Errors { get; set; }
}