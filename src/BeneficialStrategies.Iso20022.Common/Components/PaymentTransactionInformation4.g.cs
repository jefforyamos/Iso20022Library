﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransactionInformation4.  ISO2002 ID# _Pr6kbtp-Ed-ak6NoX_4Aeg_2146802204.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference and status information concerning the original transactions, included in the original instruction, to which the reversal message applies.
/// </summary>
[DataContract]
[XmlType]
public partial record PaymentTransactionInformation4
{
    #nullable enable
    
    /// <summary>
    /// Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the reversed transaction.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ReversalIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of the original payment information block as assigned by the original sending party.
    /// </summary>
    [DataMember]
    public IsoMax35Text? OriginalPaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Original unique instruction identification as assigned by an instructing party for an instructed party to unambiguously identify the original instruction.||Usage: the original instruction identification is the original point to point reference used between the instructing party and the instructed party to refer to the original instruction.
    /// </summary>
    [DataMember]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Original unique identification assigned by the initiating party to unambiguously identify the original transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
    /// </summary>
    [DataMember]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency as ordered by the initiating party in the original transaction.
    /// </summary>
    [DataMember]
    public IsoCurrencyAndAmount? OriginalInstructedAmount { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the reversed transaction.
    /// </summary>
    [DataMember]
    public IsoCurrencyAndAmount? ReversedInstructedAmount { get; init; } 
    /// <summary>
    /// Specifies if the creditor and/or debtor will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the reversal message, not to the original instruction.
    /// </summary>
    [DataMember]
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Detailed information on the reversal reason.
    /// </summary>
    [DataMember]
    public ValueList<ReversalReasonInformation1> ReversalReasonInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of key elements of the original transaction being referred to.
    /// </summary>
    [DataMember]
    public OriginalTransactionReference1? OriginalTransactionReference { get; init; } 
    
    #nullable disable
}
