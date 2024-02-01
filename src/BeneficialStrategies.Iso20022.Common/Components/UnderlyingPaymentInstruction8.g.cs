﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnderlyingPaymentInstruction8.  ISO2002 ID# _3y0OsXfIEe2A6pitLvwC_g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the original payment initiation, to which the investigation message refers.
/// </summary>
public partial record UnderlyingPaymentInstruction8
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original message.
    /// </summary>
    public UnderlyingGroupInformation1? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    public IsoMax35Text? OriginalPaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    public IsoUUIDv4Identifier? OriginalUETR { get; init; } 
    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; } 
    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment. |Usage: This is the date on which the debtor's account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date at which the creditor requests the amount of money to be collected from the debtor.
    /// </summary>
    public IsoISODate? RequestedCollectionDate { get; init; } 
    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    public OriginalTransactionReference35? OriginalTransactionReference { get; init; } 
    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    public ServiceLevel8Choice_? OriginalServiceLevel { get; init; } 
    
    #nullable disable
}
