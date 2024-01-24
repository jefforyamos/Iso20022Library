﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardDataReading4Code.  ISO2002 ID# _CRJTMIn7EeShMpas3885ww.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Capabilities of the ATM terminal performing the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CRJTMIn7EeShMpas3885ww")]
[Description(@"Capabilities of the ATM terminal performing the transaction.")]
[DerivedFrom(typeof(CardDataReadingCode))]
public enum CardDataReading4Code
{
    /// <summary>
    /// Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).
    /// Encoded/decoded by serializers as "ECTL".
    /// </summary>
    [EnumMember(Value = "ECTL")]
    [IsoId("_KJE4wYn7EeShMpas3885ww")]
    [Description(@"Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).")]
    EMVProximityReader = CardDataReadingCode.EMVProximityReader, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.
    /// Encoded/decoded by serializers as "CICC".
    /// </summary>
    [EnumMember(Value = "CICC")]
    [IsoId("_KP7HoYn7EeShMpas3885ww")]
    [Description(@"ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.")]
    ICC = CardDataReadingCode.ICC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Magnetic stripe.
    /// Encoded/decoded by serializers as "MGST".
    /// </summary>
    [EnumMember(Value = "MGST")]
    [IsoId("_KX-QYYn7EeShMpas3885ww")]
    [Description(@"Magnetic stripe.")]
    MagneticStripe = CardDataReadingCode.MagneticStripe, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contactless proximity reader.
    /// Encoded/decoded by serializers as "CTLS".
    /// </summary>
    [EnumMember(Value = "CTLS")]
    [IsoId("_LaEmkYn7EeShMpas3885ww")]
    [Description(@"Contactless proximity reader.")]
    ProximityReader = CardDataReadingCode.ProximityReader, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardDataReading4CodeMetadataExtensions
{
    private static readonly CardDataReading4CodeDropdownSource _dropdownSource = new CardDataReading4CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardDataReading4CodeDropdownRow GetMetadata(this CardDataReading4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


