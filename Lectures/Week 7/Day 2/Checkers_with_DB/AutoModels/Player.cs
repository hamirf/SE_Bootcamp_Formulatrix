using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Checkers.Database.AutoModels;

public partial class Player
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name", TypeName = "ntext")]
    public string Name { get; set; } = null!;

    [InverseProperty("Player")]
    public virtual ICollection<Piece> Pieces { get; set; } = new List<Piece>();
}
