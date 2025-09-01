using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class SocComGooSpec
{
    public long CommentId { get; set; }

    public long GooSpeId { get; set; }

    public long GroGooSpeId { get; set; }

    public decimal Qty { get; set; }
}
