using AutoMapper;

namespace Application;

public class LookupDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    private class Mapping : Profile
    {
        public Mapping()
        {
        // TODO: Add mapping configuration
        
        }
    }
}
