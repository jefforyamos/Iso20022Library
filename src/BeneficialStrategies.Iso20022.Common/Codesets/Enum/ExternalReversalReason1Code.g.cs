﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalReversalReason1Code.  ISO2002 ID# _amolhNp-Ed-ak6NoX_4Aeg_1644342151.
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
[IsoId("_amolhNp-Ed-ak6NoX_4Aeg_1644342151")]
[Description(@"Specifies the reversal reason, as published in an external reversal reason code list. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalReversalReasonCode))]
public enum ExternalReversalReason1Code
{
    /// <summary>
    /// Wrong IBAN in  SCT
    /// Encoded/decoded by serializers as "InvalidCreditorAccountNumber".
    /// </summary>
    [EnumMember(Value = "AC03")]
    [IsoId("_t8gqIvRYEeuLhpyIdtJzwg")]
    [Description(@"Wrong IBAN in  SCT")]
    InvalidCreditorAccountNumber,
    
    /// <summary>
    /// Account number specified has been closed on the Receiver's books
    /// Encoded/decoded by serializers as "ClosedAccountNumber".
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_t8gqJfRYEeuLhpyIdtJzwg")]
    [Description(@"Account number specified has been closed on the Receiver's books")]
    ClosedAccountNumber,
    
    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver
    /// Encoded/decoded by serializers as "InvalidBankOperationCode".
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_t8gqKPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver")]
    InvalidBankOperationCode,
    
    /// <summary>
    /// Duplication
    /// Encoded/decoded by serializers as "Duplication".
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_t8gqK_RYEeuLhpyIdtJzwg")]
    [Description(@"Duplication")]
    Duplication,
    
    /// <summary>
    /// Wrong amount in SCT
    /// Encoded/decoded by serializers as "WrongAmount".
    /// </summary>
    [EnumMember(Value = "AM09")]
    [IsoId("_t8qbIvRYEeuLhpyIdtJzwg")]
    [Description(@"Wrong amount in SCT")]
    WrongAmount,
    
    /// <summary>
    /// No Mandate
    /// Encoded/decoded by serializers as "NoMandate".
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_t8qbJfRYEeuLhpyIdtJzwg")]
    [Description(@"No Mandate")]
    NoMandate,
    
    /// <summary>
    /// Creditor or creditor's agent should not have collected the direct debit
    /// Encoded/decoded by serializers as "CollectionNotDue".
    /// </summary>
    [EnumMember(Value = "MD05")]
    [IsoId("_t8qbKPRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor or creditor's agent should not have collected the direct debit")]
    CollectionNotDue,
    
    /// <summary>
    /// Reason has not been specified by end customer
    /// Encoded/decoded by serializers as "NotSpecifiedReasonCustomerGenerated".
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_t8qbK_RYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by end customer")]
    NotSpecifiedReasonCustomerGenerated,
    
    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as "NotSpecifiedReasonAgentGenerated".
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_t8qbLvRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated,
    
    /// <summary>
    /// Wrong BIC in SCT
    /// Encoded/decoded by serializers as "InvalidCreditorBICIdentifier".
    /// </summary>
    [EnumMember(Value = "RC07")]
    [IsoId("_t8zlEvRYEeuLhpyIdtJzwg")]
    [Description(@"Wrong BIC in SCT")]
    InvalidCreditorBICIdentifier,
    
    /// <summary>
    /// Associated message was received after agreed processing cut-off time.
    /// Encoded/decoded by serializers as "CutOffTime".
    /// </summary>
    [EnumMember(Value = "TM01")]
    [IsoId("_t8zlFfRYEeuLhpyIdtJzwg")]
    [Description(@"Associated message was received after agreed processing cut-off time.")]
    CutOffTime,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalReversalReason1CodeMetadataExtensions
{
    private static readonly ExternalReversalReason1CodeDropdownSource _dropdownSource = new ExternalReversalReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalReversalReason1CodeDropdownRow GetMetadata(this ExternalReversalReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


