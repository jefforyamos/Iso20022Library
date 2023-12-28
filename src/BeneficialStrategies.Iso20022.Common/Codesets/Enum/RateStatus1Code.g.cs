﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RateStatus1Code.  ISO2002 ID# _ZY_ts9p-Ed-ak6NoX_4Aeg_1472885519.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZY_ts9p-Ed-ak6NoX_4Aeg_1472885519")]
[Description(@"Specifies the type of rate.")]
[DerivedFrom(typeof(RateStatusCode))]
public enum RateStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ActualRate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZY_ttNp-Ed-ak6NoX_4Aeg_1472885768")]
    [Description(@"??")]
    ActualRate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IndicativeRate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZY_ttdp-Ed-ak6NoX_4Aeg_1472885797")]
    [Description(@"??")]
    IndicativeRate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RateStatus1CodeMetadataExtensions
{
    private static readonly RateStatus1CodeDropdownSource _dropdownSource = new RateStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRateStatus1CodeDropdownRow GetMetadata(this RateStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

