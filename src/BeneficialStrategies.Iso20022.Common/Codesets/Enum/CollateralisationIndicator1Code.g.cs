﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralisationIndicator1Code.  ISO2002 ID# _5CiEQC5TEeK7-OZOLIksSw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the transaction is collateralised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5CiEQC5TEeK7-OZOLIksSw")]
[Description(@"Specifies whether the transaction is collateralised.")]
[DerivedFrom(typeof(CollateralisationIndicatorCode))]
public enum CollateralisationIndicator1Code
{
    /// <summary>
    /// Transaction is fully collateralised.
    /// Encoded/decoded by serializers as "FULL".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_At8bUS5VEeKwTrPDLMbLxA")]
    [Description(@"Transaction is fully collateralised.")]
    FullyCollateralised = CollateralisationIndicatorCode.FullyCollateralised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is one-way collateralised.
    /// Encoded/decoded by serializers as "ONEW".
    /// </summary>
    [EnumMember(Value = "ONEW")]
    [IsoId("_Ax7jcS5VEeKwTrPDLMbLxA")]
    [Description(@"Transaction is one-way collateralised.")]
    OneWayCollateralised = CollateralisationIndicatorCode.OneWayCollateralised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is partially collateralised.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_A2-bgS5VEeKwTrPDLMbLxA")]
    [Description(@"Transaction is partially collateralised.")]
    PartiallyCollateralised = CollateralisationIndicatorCode.PartiallyCollateralised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is uncollateralised.
    /// Encoded/decoded by serializers as "UNCO".
    /// </summary>
    [EnumMember(Value = "UNCO")]
    [IsoId("_A7OpYS5VEeKwTrPDLMbLxA")]
    [Description(@"Transaction is uncollateralised.")]
    Uncollateralised = CollateralisationIndicatorCode.Uncollateralised, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralisationIndicator1CodeMetadataExtensions
{
    private static readonly CollateralisationIndicator1CodeDropdownSource _dropdownSource = new CollateralisationIndicator1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralisationIndicator1CodeDropdownRow GetMetadata(this CollateralisationIndicator1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


