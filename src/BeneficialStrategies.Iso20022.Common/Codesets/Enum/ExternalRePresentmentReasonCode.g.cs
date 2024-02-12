﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalRePresentmentReasonCode.  ISO2002 ID# _BypvwLf9Eee9KIDjEHK7ZQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external representment reason code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BypvwLf9Eee9KIDjEHK7ZQ")]
[Description(@"Specifies the external representment reason code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.")]
[Derivations(typeof(ExternalRePresentmentReason1Code))]
public enum ExternalRePresentmentReasonCode
{
    /// <summary>
    /// Amount corrected due to proof of transaction
    /// Encoded/decoded by serializers as "AMCR".
    /// </summary>
    [EnumMember(Value = "AMCR")]
    [IsoId("_uOP6afRYEeuLhpyIdtJzwg")]
    [Description(@"Amount corrected due to proof of transaction")]
    AmountCorrected,
    
    /// <summary>
    /// Liability Shift to acquirer due to missing card authentication method denied
    /// Encoded/decoded by serializers as "CLSD".
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_uOZEUPRYEeuLhpyIdtJzwg")]
    [Description(@"Liability Shift to acquirer due to missing card authentication method denied")]
    CardAuthenticationLiabilityShiftDenied,
    
    /// <summary>
    /// Credit previously issued
    /// Encoded/decoded by serializers as "CRPI".
    /// </summary>
    [EnumMember(Value = "CRPI")]
    [IsoId("_uOZEU_RYEeuLhpyIdtJzwg")]
    [Description(@"Credit previously issued")]
    CreditPreviouslyIssued,
    
    /// <summary>
    /// Original transaction was valid
    /// Encoded/decoded by serializers as "OTVA".
    /// </summary>
    [EnumMember(Value = "OTVA")]
    [IsoId("_uOZEVvRYEeuLhpyIdtJzwg")]
    [Description(@"Original transaction was valid")]
    OriginalTransactionValid,
    
    /// <summary>
    /// Liability Shift to acquirer due to missing cardholder verification method denied
    /// Encoded/decoded by serializers as "VLSD".
    /// </summary>
    [EnumMember(Value = "VLSD")]
    [IsoId("_uOZEWfRYEeuLhpyIdtJzwg")]
    [Description(@"Liability Shift to acquirer due to missing cardholder verification method denied")]
    VerificationLiabilityShiftDenied,
    
}
