﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FractionDispositionType11Code.  ISO2002 ID# _dafmQGSCEeKFfdK0gKYFLQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates that fractional value should be retained; no rounding.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dafmQGSCEeKFfdK0gKYFLQ")]
[Description(@"Indicates that fractional value should be retained; no rounding.")]
[DerivedFrom(typeof(FractionDispositionTypeV2Code))]
public enum FractionDispositionType11Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BuyUp".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_gXwooWSCEeKFfdK0gKYFLQ")]
    [Description(@"??")]
    BuyUp,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashInLieuOfFraction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ggtJQWSCEeKFfdK0gKYFLQ")]
    [Description(@"??")]
    CashInLieuOfFraction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IssueFraction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_g-qQkWSCEeKFfdK0gKYFLQ")]
    [Description(@"??")]
    IssueFraction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RoundDown".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hv_m4WSCEeKFfdK0gKYFLQ")]
    [Description(@"??")]
    RoundDown,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RoundToNearest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_h4yWgWSCEeKFfdK0gKYFLQ")]
    [Description(@"??")]
    RoundToNearest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RoundUp".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_h7d3EWSCEeKFfdK0gKYFLQ")]
    [Description(@"??")]
    RoundUp,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FractionDispositionType11CodeMetadataExtensions
{
    private static readonly FractionDispositionType11CodeDropdownSource _dropdownSource = new FractionDispositionType11CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFractionDispositionType11CodeDropdownRow GetMetadata(this FractionDispositionType11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


