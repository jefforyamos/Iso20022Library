﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ShareRankingCode.  ISO2002 ID# _ZOkmaNp-Ed-ak6NoX_4Aeg_1801695812.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the shares are ranking for dividend or pari passu.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZOkmaNp-Ed-ak6NoX_4Aeg_1801695812")]
[Description(@"Specifies whether the shares are ranking for dividend or pari passu.")]
[Derivations(typeof(ShareRanking1Code))]
public enum ShareRankingCode
{
    /// <summary>
    /// Payable on the date specified.
    /// Encoded/decoded by serializers as "DIVI".
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_ZOtwUNp-Ed-ak6NoX_4Aeg_1834017233")]
    [Description(@"Payable on the date specified.")]
    Dividend,
    
    /// <summary>
    /// Pari Passu. With equal rights as other shares of the company.
    /// Encoded/decoded by serializers as "PARI".
    /// </summary>
    [EnumMember(Value = "PARI")]
    [IsoId("_ZOtwUdp-Ed-ak6NoX_4Aeg_1889429406")]
    [Description(@"Pari Passu. With equal rights as other shares of the company.")]
    PariPassu,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ShareRankingCodeMetadataExtensions
{
    private static readonly ShareRankingCodeDropdownSource _dropdownSource = new ShareRankingCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IShareRankingCodeDropdownRow GetMetadata(this ShareRankingCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


