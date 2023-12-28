﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FractionDispositionType2Code.  ISO2002 ID# _arZwwtp-Ed-ak6NoX_4Aeg_157489623.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_arZwwtp-Ed-ak6NoX_4Aeg_157489623")]
[Description(@"Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.")]
[DerivedFrom(typeof(FractionDispositionTypeCode))]
public enum FractionDispositionType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IssueFraction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_arZww9p-Ed-ak6NoX_4Aeg_489032356")]
    [Description(@"??")]
    IssueFraction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RoundDown".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_arZwxNp-Ed-ak6NoX_4Aeg_513969161")]
    [Description(@"??")]
    RoundDown,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RoundUp".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_arZwxdp-Ed-ak6NoX_4Aeg_789176096")]
    [Description(@"??")]
    RoundUp,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RoundToNearest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_arZwxtp-Ed-ak6NoX_4Aeg_803952827")]
    [Description(@"??")]
    RoundToNearest,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FractionDispositionType2CodeMetadataExtensions
{
    private static readonly FractionDispositionType2CodeDropdownSource _dropdownSource = new FractionDispositionType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFractionDispositionType2CodeDropdownRow GetMetadata(this FractionDispositionType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


