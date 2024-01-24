﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalReversalReasonCode.  ISO2002 ID# _UBzAwLf9Eee9KIDjEHK7ZQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reversal reason, as published in an external reversal reason code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UBzAwLf9Eee9KIDjEHK7ZQ")]
[Description(@"Specifies the reversal reason, as published in an external reversal reason code list.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalReversalReason1Code))]
public enum ExternalReversalReasonCode
{
    /// <summary>
    /// Wrong IBAN in  SCT
    /// Encoded/decoded by serializers as "AC03".
    /// </summary>
    [EnumMember(Value = "AC03")]
    [IsoId("_t8gqIPRYEeuLhpyIdtJzwg")]
    [Description(@"Wrong IBAN in  SCT")]
    InvalidCreditorAccountNumber,
    
    /// <summary>
    /// Account number specified has been closed on the Receiver's books
    /// Encoded/decoded by serializers as "AC04".
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_t8gqI_RYEeuLhpyIdtJzwg")]
    [Description(@"Account number specified has been closed on the Receiver's books")]
    ClosedAccountNumber,
    
    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver
    /// Encoded/decoded by serializers as "AG02".
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_t8gqJvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver")]
    InvalidBankOperationCode,
    
    /// <summary>
    /// Duplication
    /// Encoded/decoded by serializers as "AM05".
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_t8gqKfRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication")]
    Duplication,
    
    /// <summary>
    /// Wrong amount in SCT
    /// Encoded/decoded by serializers as "AM09".
    /// </summary>
    [EnumMember(Value = "AM09")]
    [IsoId("_t8qbIPRYEeuLhpyIdtJzwg")]
    [Description(@"Wrong amount in SCT")]
    WrongAmount,
    
    /// <summary>
    /// No Mandate
    /// Encoded/decoded by serializers as "MD01".
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_t8qbI_RYEeuLhpyIdtJzwg")]
    [Description(@"No Mandate")]
    NoMandate,
    
    /// <summary>
    /// Creditor or creditor's agent should not have collected the direct debit
    /// Encoded/decoded by serializers as "MD05".
    /// </summary>
    [EnumMember(Value = "MD05")]
    [IsoId("_t8qbJvRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor or creditor's agent should not have collected the direct debit")]
    CollectionNotDue,
    
    /// <summary>
    /// Reason has not been specified by end customer
    /// Encoded/decoded by serializers as "MS02".
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_t8qbKfRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by end customer")]
    NotSpecifiedReasonCustomerGenerated,
    
    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as "MS03".
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_t8qbLPRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated,
    
    /// <summary>
    /// Wrong BIC in SCT
    /// Encoded/decoded by serializers as "RC07".
    /// </summary>
    [EnumMember(Value = "RC07")]
    [IsoId("_t8zlEPRYEeuLhpyIdtJzwg")]
    [Description(@"Wrong BIC in SCT")]
    InvalidCreditorBICIdentifier,
    
    /// <summary>
    /// Associated message was received after agreed processing cut-off time.
    /// Encoded/decoded by serializers as "TM01".
    /// </summary>
    [EnumMember(Value = "TM01")]
    [IsoId("_t8zlE_RYEeuLhpyIdtJzwg")]
    [Description(@"Associated message was received after agreed processing cut-off time.")]
    CutOffTime,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalReversalReasonCodeMetadataExtensions
{
    private static readonly ExternalReversalReasonCodeDropdownSource _dropdownSource = new ExternalReversalReasonCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalReversalReasonCodeDropdownRow GetMetadata(this ExternalReversalReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


