﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentMethod2Code.  ISO2002 ID# _Z0aeYNp-Ed-ak6NoX_4Aeg_-15953636.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transfer method that will be used to transfer the cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z0aeYNp-Ed-ak6NoX_4Aeg_-15953636")]
[Description(@"Specifies the transfer method that will be used to transfer the cash.")]
[DerivedFrom(typeof(PaymentMethodCode))]
public enum PaymentMethod2Code
{
    /// <summary>
    /// Collection of an amount of money from the debtor's bank account by the creditor. The amount of money and dates of collections may vary.
    /// Encoded/decoded by serializers as "DD".
    /// </summary>
    [EnumMember(Value = "DD")]
    [IsoId("_Z0aeYdp-Ed-ak6NoX_4Aeg_-15953576")]
    [Description(@"Collection of an amount of money from the debtor's bank account by the creditor. The amount of money and dates of collections may vary.")]
    DirectDebit = PaymentMethodCode.DirectDebit, // same ordinal as derivation source for type conversions
    
}
