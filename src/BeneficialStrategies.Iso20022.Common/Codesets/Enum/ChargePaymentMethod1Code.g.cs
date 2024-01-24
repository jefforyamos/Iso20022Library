﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ChargePaymentMethod1Code.  ISO2002 ID# _ZFE3gBXyEeOBE-jZfcm4KQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how expenses are paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFE3gBXyEeOBE-jZfcm4KQ")]
[Description(@"Specifies how expenses are paid.")]
[DerivedFrom(typeof(ChargePaymentMethodCode))]
public enum ChargePaymentMethod1Code
{
    /// <summary>
    /// Payment is with cash.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_T2UeMRXzEeOBE-jZfcm4KQ")]
    [Description(@"Payment is with cash.")]
    Cash = ChargePaymentMethodCode.Cash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Units are redeemed to cover payment.
    /// Encoded/decoded by serializers as "UNIT".
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_UAJIkRXzEeOBE-jZfcm4KQ")]
    [Description(@"Units are redeemed to cover payment.")]
    Unit = ChargePaymentMethodCode.Unit, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ChargePaymentMethod1CodeMetadataExtensions
{
    private static readonly ChargePaymentMethod1CodeDropdownSource _dropdownSource = new ChargePaymentMethod1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IChargePaymentMethod1CodeDropdownRow GetMetadata(this ChargePaymentMethod1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


