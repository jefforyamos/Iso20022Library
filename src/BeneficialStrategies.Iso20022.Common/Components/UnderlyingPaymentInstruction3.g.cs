﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnderlyingPaymentInstruction3.  ISO2002 ID# _X0dqgWXpEeap-P22vGV91g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference information concerning the original payment initiation, to which the investigation message refers.
/// </summary>
[DataContract]
[XmlType]
public partial record UnderlyingPaymentInstruction3
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original message.
    /// </summary>
    [DataMember]
    public UnderlyingGroupInformation1? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [DataMember]
    public IsoMax35Text? OriginalPaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [DataMember]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [DataMember]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
    /// </summary>
    [DataMember]
    public required IsoActiveOrHistoricCurrencyAndAmount OriginalInstructedAmount { get; init; } 
    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment. |Usage: This is the date on which the debtor's account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    [DataMember]
    public DateAndDateTimeChoice_? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date at which the creditor requests the amount of money to be collected from the debtor.
    /// </summary>
    [DataMember]
    public IsoISODate? RequestedCollectionDate { get; init; } 
    
    #nullable disable
}
