﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentMethod6Code.  ISO2002 ID# _Z0kPZtp-Ed-ak6NoX_4Aeg_1534180341.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method of payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z0kPZtp-Ed-ak6NoX_4Aeg_1534180341")]
[Description(@"Specifies the method of payment.")]
[DerivedFrom(typeof(PaymentMethodCode))]
public enum PaymentMethod6Code
{
    /// <summary>
    /// Direct method.
    /// Encoded/decoded by serializers as "DIRE".
    /// </summary>
    [EnumMember(Value = "DIRE")]
    [IsoId("_Z0kPZ9p-Ed-ak6NoX_4Aeg_1534180343")]
    [Description(@"Direct method.")]
    Direct = PaymentMethodCode.Direct, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Classical method.
    /// Encoded/decoded by serializers as "CLAS".
    /// </summary>
    [EnumMember(Value = "CLAS")]
    [IsoId("_Z0kPaNp-Ed-ak6NoX_4Aeg_1534180372")]
    [Description(@"Classical method.")]
    Classical = PaymentMethodCode.Classical, // same ordinal as derivation source for type conversions
    
}
