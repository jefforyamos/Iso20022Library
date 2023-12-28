﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardDataReading5Code.  ISO2002 ID# _j7nYMY0REeWRYffwL7E13A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of reading of the card data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_j7nYMY0REeWRYffwL7E13A")]
[Description(@"Type of reading of the card data.")]
[DerivedFrom(typeof(CardDataReadingCode))]
public enum CardDataReading5Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Tag".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kGMQgY0REeWRYffwL7E13A")]
    [Description(@"??")]
    Tag,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Physical".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kGMQg40REeWRYffwL7E13A")]
    [Description(@"??")]
    Physical,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BarCode".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kGMQhY0REeWRYffwL7E13A")]
    [Description(@"??")]
    BarCode,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MagneticStripe".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kGMQh40REeWRYffwL7E13A")]
    [Description(@"??")]
    MagneticStripe,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ICC".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kGMQiY0REeWRYffwL7E13A")]
    [Description(@"??")]
    ICC,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountData".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kGMQi40REeWRYffwL7E13A")]
    [Description(@"??")]
    AccountData,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProximityReader".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kGMQjY0REeWRYffwL7E13A")]
    [Description(@"??")]
    ProximityReader,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EMVProximityReader".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kGMQj40REeWRYffwL7E13A")]
    [Description(@"??")]
    EMVProximityReader,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardOnFile".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_n7UH8Y0REeWRYffwL7E13A")]
    [Description(@"??")]
    CardOnFile,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardDataReading5CodeMetadataExtensions
{
    private static readonly CardDataReading5CodeDropdownSource _dropdownSource = new CardDataReading5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardDataReading5CodeDropdownRow GetMetadata(this CardDataReading5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

