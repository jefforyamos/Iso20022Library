﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentScenario2Code.  ISO2002 ID# _lZ0UwHYkEei7x9Ux0Cio1w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the payment scenario used for a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lZ0UwHYkEei7x9Ux0Cio1w")]
[Description(@"Describes the payment scenario used for a payment transaction.")]
[DerivedFrom(typeof(PaymentScenarioCode))]
public enum PaymentScenario2Code
{
    /// <summary>
    /// Indicates customer credit transfer(s).
    /// Encoded/decoded by serializers as "CCTR".
    /// </summary>
    [EnumMember(Value = "CCTR")]
    [IsoId("_pmo6gXYkEei7x9Ux0Cio1w")]
    [Description(@"Indicates customer credit transfer(s).")]
    CustomerCreditTransfer = PaymentScenarioCode.CustomerCreditTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates cover payment(s).
    /// Encoded/decoded by serializers as "COVE".
    /// </summary>
    [EnumMember(Value = "COVE")]
    [IsoId("_qYxiEXYkEei7x9Ux0Cio1w")]
    [Description(@"Indicates cover payment(s).")]
    Cover = PaymentScenarioCode.Cover, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates customer credit transfer(s) and cover(s).
    /// Encoded/decoded by serializers as "CTCO".
    /// </summary>
    [EnumMember(Value = "CTCO")]
    [IsoId("_rCIoIXYkEei7x9Ux0Cio1w")]
    [Description(@"Indicates customer credit transfer(s) and cover(s).")]
    CustomerCreditTransferAndCover = PaymentScenarioCode.CustomerCreditTransferAndCover, // same ordinal as derivation source for type conversions
    
}
