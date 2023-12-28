﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ShareRanking1Code.  ISO2002 ID# _ZOkmZdp-Ed-ak6NoX_4Aeg_1470328796.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the shares are ranking for dividend or pari passu.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZOkmZdp-Ed-ak6NoX_4Aeg_1470328796")]
[Description(@"Specifies whether the shares are ranking for dividend or pari passu.")]
[DerivedFrom(typeof(ShareRankingCode))]
public enum ShareRanking1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Dividend".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZOkmZtp-Ed-ak6NoX_4Aeg_1470328798")]
    [Description(@"??")]
    Dividend,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PariPassu".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZOkmZ9p-Ed-ak6NoX_4Aeg_1470328827")]
    [Description(@"??")]
    PariPassu,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ShareRanking1CodeMetadataExtensions
{
    private static readonly ShareRanking1CodeDropdownSource _dropdownSource = new ShareRanking1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IShareRanking1CodeDropdownRow GetMetadata(this ShareRanking1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


