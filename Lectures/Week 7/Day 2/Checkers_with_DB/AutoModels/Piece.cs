using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Checkers.Database.AutoModels;

public partial class Piece
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("positionId")]
    public long PositionId { get; set; }

    [Column("rankId")]
    public long RankId { get; set; }

    [Column("colorId")]
    public long ColorId { get; set; }

    [Column("playerId")]
    public long? PlayerId { get; set; }

    [Column("isEaten")]
    public long? IsEaten { get; set; }

    [Column("isKinged")]
    public long? IsKinged { get; set; }

    [ForeignKey("ColorId")]
    [InverseProperty("Pieces")]
    public virtual Color Color { get; set; } = null!;

    [ForeignKey("PlayerId")]
    [InverseProperty("Pieces")]
    public virtual Player? Player { get; set; }

    [ForeignKey("PositionId")]
    [InverseProperty("Pieces")]
    public virtual Position Position { get; set; } = null!;

    [ForeignKey("RankId")]
    [InverseProperty("Pieces")]
    public virtual Rank Rank { get; set; } = null!;
}
