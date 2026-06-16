using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoardGameApi.Models;

public class Game
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int BggId { get; set; }

    [Required, MaxLength(255)]
    public string Title { get; set; } = string.Empty;

    public string? ImageUrl { get; set; }
    public int MinPlayers { get; set; }
    public int MaxPlayers { get; set; }
}