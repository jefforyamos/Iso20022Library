﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentInstrumentTypeCode.  ISO2002 ID# _MoMKoNxgEeioifFt1dhnJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of payment instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MoMKoNxgEeioifFt1dhnJA")]
[Description(@"Type of payment instrument.")]
[Derivations(typeof(PaymentInstrumentType1Code))]
public enum PaymentInstrumentTypeCode
{
    /// <summary>
    /// Payment card (credit or debit).
    /// Encoded/decoded by serializers as "CARD".
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_SadrQNxgEeioifFt1dhnJA")]
    [Description(@"Payment card (credit or debit).")]
    Card,
    
    /// <summary>
    /// Paper check.
    /// Encoded/decoded by serializers as "CHCK".
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_UlszwNxgEeioifFt1dhnJA")]
    [Description(@"Paper check.")]
    Check,
    
    /// <summary>
    /// Account accessed by a stored value instrument such as a card or a certificate.
    /// Encoded/decoded by serializers as "SVAC".
    /// </summary>
    [EnumMember(Value = "SVAC")]
    [IsoId("_Wh6BwNxgEeioifFt1dhnJA")]
    [Description(@"Account accessed by a stored value instrument such as a card or a certificate.")]
    StoredValueAccount,
    
    /// <summary>
    /// Cash managed by a cash handling system.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_aoljQNxgEeioifFt1dhnJA")]
    [Description(@"Cash managed by a cash handling system.")]
    Cash,
    
    /// <summary>
    /// Account using loyalty processing.
    /// Encoded/decoded by serializers as "LOYT".
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_ci9lQNxgEeioifFt1dhnJA")]
    [Description(@"Account using loyalty processing.")]
    LoyaltyAccount,
    
}
