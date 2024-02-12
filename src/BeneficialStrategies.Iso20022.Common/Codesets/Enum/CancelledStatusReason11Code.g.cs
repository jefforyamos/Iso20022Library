﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancelledStatusReason11Code.  ISO2002 ID# _QcaXgeJxEd-Q6MzBzY5WkA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QcaXgeJxEd-Q6MzBzY5WkA")]
[Description(@"Specifies the underlying reason for the cancellation of the associated transaction.")]
[DerivedFrom(typeof(CancelledStatusReasonV2Code))]
public enum CancelledStatusReason11Code
{
    /// <summary>
    /// Transaction is cancelled by yourself.
    /// Encoded/decoded by serializers as "CANI".
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_q2JGtmtdEeCY4-KZ9JEyUQ_-816468203")]
    [Description(@"Transaction is cancelled by yourself.")]
    CancelledByYourself = CancelledStatusReasonV2Code.CancelledByYourself, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is cancelled by a party other than the instructing party, for example, a market infrastructure such as a stock exchange.
    /// Encoded/decoded by serializers as "CANO".
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_q2S3sGtdEeCY4-KZ9JEyUQ_1372396382")]
    [Description(@"Transaction is cancelled by a party other than the instructing party, for example, a market infrastructure such as a stock exchange.")]
    CancelledByOther = CancelledStatusReasonV2Code.CancelledByOther, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is cancelled by the system.
    /// Encoded/decoded by serializers as "CANS".
    /// </summary>
    [EnumMember(Value = "CANS")]
    [IsoId("_q2S3sWtdEeCY4-KZ9JEyUQ_-1844550576")]
    [Description(@"Transaction is cancelled by the system.")]
    CancelledBySystem = CancelledStatusReasonV2Code.CancelledBySystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been cancelled by the agent due to an event deadline extension.
    /// Encoded/decoded by serializers as "CSUB".
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_q2S3smtdEeCY4-KZ9JEyUQ_1453344367")]
    [Description(@"Instruction has been cancelled by the agent due to an event deadline extension.")]
    CancelledByAgent = CancelledStatusReasonV2Code.CancelledByAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_q2S3s2tdEeCY4-KZ9JEyUQ_-486739620")]
    [Description(@"Other. See Narrative.")]
    Other = CancelledStatusReasonV2Code.Other, // same ordinal as derivation source for type conversions
    
}
