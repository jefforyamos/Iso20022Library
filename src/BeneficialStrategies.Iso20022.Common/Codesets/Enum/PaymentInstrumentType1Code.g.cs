﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentInstrumentType1Code.  ISO2002 ID# _hi6RENxgEeioifFt1dhnJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of payment instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hi6RENxgEeioifFt1dhnJA")]
[Description(@"Type of payment instrument.")]
[DerivedFrom(typeof(PaymentInstrumentTypeCode))]
public enum PaymentInstrumentType1Code
{
    /// <summary>
    /// Payment card (credit or debit).
    /// Encoded/decoded by serializers as "CARD".
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_jjj6MdxgEeioifFt1dhnJA")]
    [Description(@"Payment card (credit or debit).")]
    Card = PaymentInstrumentTypeCode.Card, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash managed by a cash handling system.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_jmi8wdxgEeioifFt1dhnJA")]
    [Description(@"Cash managed by a cash handling system.")]
    Cash = PaymentInstrumentTypeCode.Cash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Paper check.
    /// Encoded/decoded by serializers as "CHCK".
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_jp2IYdxgEeioifFt1dhnJA")]
    [Description(@"Paper check.")]
    Check = PaymentInstrumentTypeCode.Check, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account using loyalty processing.
    /// Encoded/decoded by serializers as "LOYT".
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_jt13kdxgEeioifFt1dhnJA")]
    [Description(@"Account using loyalty processing.")]
    LoyaltyAccount = PaymentInstrumentTypeCode.LoyaltyAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account accessed by a stored value instrument such as a card or a certificate.
    /// Encoded/decoded by serializers as "SVAC".
    /// </summary>
    [EnumMember(Value = "SVAC")]
    [IsoId("_jxDjodxgEeioifFt1dhnJA")]
    [Description(@"Account accessed by a stored value instrument such as a card or a certificate.")]
    StoredValueAccount = PaymentInstrumentTypeCode.StoredValueAccount, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentInstrumentType1CodeMetadataExtensions
{
    private static readonly PaymentInstrumentType1CodeDropdownSource _dropdownSource = new PaymentInstrumentType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentInstrumentType1CodeDropdownRow GetMetadata(this PaymentInstrumentType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


