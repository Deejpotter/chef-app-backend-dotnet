using System.ComponentModel.DataAnnotations;

namespace chef_app_backend_dotnet.Models;

public class Recipe
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<string>? Ingredients { get; set; }
    public List<string>? Steps { get; set; }
    [DataType(DataType.Date)]
    public DateTime LastUpdated { get; set; }
}