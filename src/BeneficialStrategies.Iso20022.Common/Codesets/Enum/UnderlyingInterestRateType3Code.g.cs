﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnderlyingInterestRateType3Code.  ISO2002 ID# _NdyGMICmEea6KOHFXW8q7A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of an underlying contract for interest rate derivatives.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NdyGMICmEea6KOHFXW8q7A")]
[Description(@"Specifies the type of an underlying contract for interest rate derivatives.")]
[DerivedFrom(typeof(UnderlyingTypeV3Code))]
public enum UnderlyingInterestRateType3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Bond".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UWAiQYCmEea6KOHFXW8q7A")]
    [Description(@"??")]
    Bond,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BondFuture".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U0WrIYCmEea6KOHFXW8q7A")]
    [Description(@"??")]
    BondFuture,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InterestRate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_V2Q0EYCmEea6KOHFXW8q7A")]
    [Description(@"??")]
    InterestRate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InterestRateFutureFRA".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WVWj0YCmEea6KOHFXW8q7A")]
    [Description(@"??")]
    InterestRateFutureFRA,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnderlyingInterestRateType3CodeMetadataExtensions
{
    private static readonly UnderlyingInterestRateType3CodeDropdownSource _dropdownSource = new UnderlyingInterestRateType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnderlyingInterestRateType3CodeDropdownRow GetMetadata(this UnderlyingInterestRateType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

