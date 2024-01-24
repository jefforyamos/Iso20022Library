﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceValueType12Code.  ISO2002 ID# _ETkqkAydEeuG8M5giQ2e0w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Price will not be paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ETkqkAydEeuG8M5giQ2e0w")]
[Description(@"Price will not be paid.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType12Code
{
    /// <summary>
    /// Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.
    /// Encoded/decoded by serializers as "DISC".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_HwDYgQydEeuG8M5giQ2e0w")]
    [Description(@"Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.")]
    Discount = PriceValueTypeCode.Discount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the face amount.
    /// Encoded/decoded by serializers as "PARV".
    /// </summary>
    [EnumMember(Value = "PARV")]
    [IsoId("_H7XQoQydEeuG8M5giQ2e0w")]
    [Description(@"Price is the face amount.")]
    Par = PriceValueTypeCode.Par, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.
    /// Encoded/decoded by serializers as "PREM".
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_I1Yo4QydEeuG8M5giQ2e0w")]
    [Description(@"Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.")]
    Premium = PriceValueTypeCode.Premium, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price must be interpreted as a negative amount of currency per unit or per share.
    /// Encoded/decoded by serializers as "NEGA".
    /// </summary>
    [EnumMember(Value = "NEGA")]
    [IsoId("_JUe_sQydEeuG8M5giQ2e0w")]
    [Description(@"Price must be interpreted as a negative amount of currency per unit or per share.")]
    NegativeActualAmount = PriceValueTypeCode.NegativeActualAmount, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriceValueType12CodeMetadataExtensions
{
    private static readonly PriceValueType12CodeDropdownSource _dropdownSource = new PriceValueType12CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriceValueType12CodeDropdownRow GetMetadata(this PriceValueType12Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


