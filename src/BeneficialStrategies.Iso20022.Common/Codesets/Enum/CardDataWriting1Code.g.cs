﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardDataWriting1Code.  ISO2002 ID# _0hem4UepEee9r7QjOdsbFw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Card  writing capabilities of the terminal performing the transaction. 
///  ISO 8583:93 bit 22-10, ISO 8583:2003 bit 27-8_9
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0hem4UepEee9r7QjOdsbFw")]
[Description(@"Card  writing capabilities of the terminal performing the transaction.   ISO 8583:93 bit 22-10, ISO 8583:2003 bit 27-8_9")]
[DerivedFrom(typeof(CardDataReadingCode))]
public enum CardDataWriting1Code
{
    /// <summary>
    /// ICC contactless proximity
    /// Encoded/decoded by serializers as "ICCProximity".
    /// </summary>
    [EnumMember(Value = "ICPY")]
    [IsoId("_0rnaU0epEee9r7QjOdsbFw")]
    [Description(@"ICC contactless proximity")]
    ICCProximity,
    
    /// <summary>
    /// Magnetic stripe.
    /// Encoded/decoded by serializers as "MagneticStripe".
    /// </summary>
    [EnumMember(Value = "MGST")]
    [IsoId("_0rnaVUepEee9r7QjOdsbFw")]
    [Description(@"Magnetic stripe.")]
    MagneticStripe,
    
    /// <summary>
    /// ICC contact capability
    /// Encoded/decoded by serializers as "ICCContact".
    /// </summary>
    [EnumMember(Value = "ICCY")]
    [IsoId("_0rnaV0epEee9r7QjOdsbFw")]
    [Description(@"ICC contact capability")]
    ICCContact,
    
    /// <summary>
    /// Magstripe image contactless proximity
    /// Encoded/decoded by serializers as "MSIProximity".
    /// </summary>
    [EnumMember(Value = "MSIP")]
    [IsoId("_0rnaX0epEee9r7QjOdsbFw")]
    [Description(@"Magstripe image contactless proximity")]
    MSIProximity,
    
    /// <summary>
    /// Other national capability type assigned at national level.
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_0rnaY0epEee9r7QjOdsbFw")]
    [Description(@"Other national capability type assigned at national level.")]
    OtherNational,
    
    /// <summary>
    /// Unspecified capability.
    /// Encoded/decoded by serializers as "Unspecified".
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_0rnaZ0epEee9r7QjOdsbFw")]
    [Description(@"Unspecified capability.")]
    Unspecified,
    
    /// <summary>
    /// Other card reading capability assigned on a private basis.
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_0rnaaUepEee9r7QjOdsbFw")]
    [Description(@"Other card reading capability assigned on a private basis.")]
    OtherPrivate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardDataWriting1CodeMetadataExtensions
{
    private static readonly CardDataWriting1CodeDropdownSource _dropdownSource = new CardDataWriting1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardDataWriting1CodeDropdownRow GetMetadata(this CardDataWriting1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


