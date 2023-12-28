﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardDataReading1Code.  ISO2002 ID# _TSXNcQEcEeCQm6a_G2yO_w_2087394966.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of reading of the card data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TSXNcQEcEeCQm6a_G2yO_w_2087394966")]
[Description(@"Type of reading of the card data.")]
[DerivedFrom(typeof(CardDataReadingCode))]
public enum CardDataReading1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Tag".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSXNcgEcEeCQm6a_G2yO_w_1877381084")]
    [Description(@"??")]
    Tag,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Physical".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSXNcwEcEeCQm6a_G2yO_w_-764781715")]
    [Description(@"??")]
    Physical,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BarCode".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSXNdAEcEeCQm6a_G2yO_w_1172443458")]
    [Description(@"??")]
    BarCode,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MagneticStripe".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSXNdQEcEeCQm6a_G2yO_w_-439664208")]
    [Description(@"??")]
    MagneticStripe,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ICC".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSXNdgEcEeCQm6a_G2yO_w_-1892344504")]
    [Description(@"??")]
    ICC,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountData".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSXNdwEcEeCQm6a_G2yO_w_44880669")]
    [Description(@"??")]
    AccountData,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProximityReader".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSXNeAEcEeCQm6a_G2yO_w_1689489202")]
    [Description(@"??")]
    ProximityReader,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EMVProximityReader".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSXNeQEcEeCQm6a_G2yO_w_-154379787")]
    [Description(@"??")]
    EMVProximityReader,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardDataReading1CodeMetadataExtensions
{
    private static readonly CardDataReading1CodeDropdownSource _dropdownSource = new CardDataReading1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardDataReading1CodeDropdownRow GetMetadata(this CardDataReading1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


