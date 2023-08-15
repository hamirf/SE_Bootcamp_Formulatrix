using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CheckersGame.Model;

public partial class Rank
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("rank", TypeName = "ntext")]
    public string? Variety { get; set; } = null!;

    [InverseProperty("Rank")]
    public virtual ICollection<Piece> Pieces { get; set; } = new List<Piece>();
}
