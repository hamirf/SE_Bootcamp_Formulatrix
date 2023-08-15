using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Checkers.Database.AutoModels;

public partial class Color
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("color")]
    public long Color1 { get; set; }

    [InverseProperty("Color")]
    public virtual ICollection<Piece> Pieces { get; set; } = new List<Piece>();
}
