﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralisationIndicatorCode.  ISO2002 ID# _9l5ZMC48EeK7-OZOLIksSw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the transaction is collateralised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9l5ZMC48EeK7-OZOLIksSw")]
[Description(@"Specifies whether the transaction is collateralised.")]
public enum CollateralisationIndicatorCode
{
    /// <summary>
    /// Transaction is fully collateralised.
    /// Encoded/decoded by serializers as "FULL".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_Ze1M8C5TEeK7-OZOLIksSw")]
    [Description(@"Transaction is fully collateralised.")]
    FullyCollateralised,
    
    /// <summary>
    /// Transaction is one-way collateralised.
    /// Encoded/decoded by serializers as "ONEW".
    /// </summary>
    [EnumMember(Value = "ONEW")]
    [IsoId("_hq8SwC5TEeK7-OZOLIksSw")]
    [Description(@"Transaction is one-way collateralised.")]
    OneWayCollateralised,
    
    /// <summary>
    /// Transaction is partially collateralised.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_k7rDsC5TEeK7-OZOLIksSw")]
    [Description(@"Transaction is partially collateralised.")]
    PartiallyCollateralised,
    
    /// <summary>
    /// Transaction is uncollateralised.
    /// Encoded/decoded by serializers as "UNCO".
    /// </summary>
    [EnumMember(Value = "UNCO")]
    [IsoId("_oNARkC5TEeK7-OZOLIksSw")]
    [Description(@"Transaction is uncollateralised.")]
    Uncollateralised,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralisationIndicatorCodeMetadataExtensions
{
    private static readonly CollateralisationIndicatorCodeDropdownSource _dropdownSource = new CollateralisationIndicatorCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralisationIndicatorCodeDropdownRow GetMetadata(this CollateralisationIndicatorCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

