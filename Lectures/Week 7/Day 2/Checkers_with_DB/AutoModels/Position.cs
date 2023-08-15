using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Checkers.Database.AutoModels;

public partial class Position
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("row")]
    public long Row { get; set; }

    [Column("column")]
    public long Column { get; set; }

    [InverseProperty("Position")]
    public virtual ICollection<Piece> Pieces { get; set; } = new List<Piece>();
}
