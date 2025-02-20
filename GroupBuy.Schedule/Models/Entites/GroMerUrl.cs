using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 團組社群賣場網址
/// </summary>
public partial class GroMerUrl
{
    /// <summary>
    /// 團組Id
    /// </summary>
    public long GroupId { get; set; }

    /// <summary>
    /// 商家社群Id(0:預設)
    /// </summary>
    public int MerSocChaId { get; set; }

    /// <summary>
    /// 賣場網址
    /// </summary>
    public string Url { get; set; } = null!;

    /// <summary>
    /// 0: 原始版本 hashids(不支援負數) /1:改良版 hashids (支援負數)
    /// </summary>
    public byte Version { get; set; }
}
