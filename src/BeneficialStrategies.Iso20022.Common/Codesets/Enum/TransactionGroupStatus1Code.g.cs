﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionGroupStatus1Code.  ISO2002 ID# _YrZn49p-Ed-ak6NoX_4Aeg_-2100712417.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a group of payment transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YrZn49p-Ed-ak6NoX_4Aeg_-2100712417")]
[Description(@"Specifies the status of a group of payment transactions.")]
[DerivedFrom(typeof(PaymentStatusCode))]
public enum TransactionGroupStatus1Code
{
    /// <summary>
    /// Authentication and syntactical and semantical validation are successful.
    /// Encoded/decoded by serializers as "AcceptedTechnicalValidation".
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_YrZn5Np-Ed-ak6NoX_4Aeg_-2100712382")]
    [Description(@"Authentication and syntactical and semantical validation are successful.")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// Payment initiation has been received by the receiving agent.
    /// Encoded/decoded by serializers as "Received".
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_YrZn5dp-Ed-ak6NoX_4Aeg_-2100712357")]
    [Description(@"Payment initiation has been received by the receiving agent.")]
    Received,
    
    /// <summary>
    /// A number of transactions have been accepted, whereas another number of transactions have not yet achieved 'accepted' status.
    /// Encoded/decoded by serializers as "PartiallyAccepted".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_YrZn5tp-Ed-ak6NoX_4Aeg_-2100712322")]
    [Description(@"A number of transactions have been accepted, whereas another number of transactions have not yet achieved 'accepted' status.")]
    PartiallyAccepted,
    
    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation has been rejected.
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_YrZn59p-Ed-ak6NoX_4Aeg_-2100712032")]
    [Description(@"Payment initiation or individual transaction included in the payment initiation has been rejected.")]
    Rejected,
    
    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation is pending.  Further checks and status update will be performed.
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_YrZn6Np-Ed-ak6NoX_4Aeg_-2100712014")]
    [Description(@"Payment initiation or individual transaction included in the payment initiation is pending.  Further checks and status update will be performed.")]
    Pending,
    
    /// <summary>
    /// Preceding check of technical validation was successful. Customer profile check was also successful.
    /// Encoded/decoded by serializers as "AcceptedCustomerProfile".
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_YrjY4Np-Ed-ak6NoX_4Aeg_-2100711979")]
    [Description(@"Preceding check of technical validation was successful. Customer profile check was also successful.")]
    AcceptedCustomerProfile,
    
    /// <summary>
    /// All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.
    /// Encoded/decoded by serializers as "AcceptedSettlementInProcess".
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_YrjY4dp-Ed-ak6NoX_4Aeg_-2100711937")]
    [Description(@"All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.")]
    AcceptedSettlementInProcess,
    
    /// <summary>
    /// Settlement on the debtor's account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement
    /// Encoded/decoded by serializers as "AcceptedSettlementCompleted".
    /// </summary>
    [EnumMember(Value = "ACSC")]
    [IsoId("_YrjY4tp-Ed-ak6NoX_4Aeg_-2100711919")]
    [Description(@"Settlement on the debtor's account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement")]
    AcceptedSettlementCompleted,
    
    /// <summary>
    /// Cancellation is accepted.
    /// Encoded/decoded by serializers as "AcceptedCancellationRequest".
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("_YrjY49p-Ed-ak6NoX_4Aeg_-1715877559")]
    [Description(@"Cancellation is accepted.")]
    AcceptedCancellationRequest,
    
    /// <summary>
    /// Instruction is accepted but a change will be made, such as date or remittance not sent.
    /// Encoded/decoded by serializers as "AcceptedWithChange".
    /// </summary>
    [EnumMember(Value = "ACWC")]
    [IsoId("_YrjY5Np-Ed-ak6NoX_4Aeg_-1673394573")]
    [Description(@"Instruction is accepted but a change will be made, such as date or remittance not sent.")]
    AcceptedWithChange,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionGroupStatus1CodeMetadataExtensions
{
    private static readonly TransactionGroupStatus1CodeDropdownSource _dropdownSource = new TransactionGroupStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionGroupStatus1CodeDropdownRow GetMetadata(this TransactionGroupStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


