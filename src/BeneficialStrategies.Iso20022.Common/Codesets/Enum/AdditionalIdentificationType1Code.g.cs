﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdditionalIdentificationType1Code.  ISO2002 ID# _H-KG4C7SEemIy6A-26wnAg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the additional identification type, for example NAICS, etc.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_H-KG4C7SEemIy6A-26wnAg")]
[Description(@"Contains the additional identification type, for example NAICS, etc.")]
[DerivedFrom(typeof(AdditionalIdentificationTypeCode))]
public enum AdditionalIdentificationType1Code
{
    /// <summary>
    /// Other Additional Identification defined at a private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_JyUzMS7SEemIy6A-26wnAg")]
    [Description(@"Other Additional Identification defined at a private level.")]
    OtherPrivate = AdditionalIdentificationTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other Additional Identification defined at a national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_J2Pp4S7SEemIy6A-26wnAg")]
    [Description(@"Other Additional Identification defined at a national level.")]
    OtherNational = AdditionalIdentificationTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contains the North American Industry Classification System (NAICS) code assigned to the card acceptor.
    /// Encoded/decoded by serializers as "ICSN".
    /// </summary>
    [EnumMember(Value = "ICSN")]
    [IsoId("_J38TAS7SEemIy6A-26wnAg")]
    [Description(@"Contains the North American Industry Classification System (NAICS) code assigned to the card acceptor.")]
    NAICS = AdditionalIdentificationTypeCode.NAICS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contains the Austin-Tetra Number assigned to the card acceptor.
    /// Encoded/decoded by serializers as "ATNU".
    /// </summary>
    [EnumMember(Value = "ATNU")]
    [IsoId("_J7TwES7SEemIy6A-26wnAg")]
    [Description(@"Contains the Austin-Tetra Number assigned to the card acceptor.")]
    AustinTetra = AdditionalIdentificationTypeCode.AustinTetra, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AdditionalIdentificationType1CodeMetadataExtensions
{
    private static readonly AdditionalIdentificationType1CodeDropdownSource _dropdownSource = new AdditionalIdentificationType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAdditionalIdentificationType1CodeDropdownRow GetMetadata(this AdditionalIdentificationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


