﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentInstruction37.  ISO2002 ID# _iRC3UdolEembTrt_WixjyQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics that apply to the credit side of the payment transactions included in the direct debit initiation.
/// </summary>
[DataContract]
[XmlType]
public partial record PaymentInstruction37
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
    /// </summary>
    [DataMember]
    public required IsoMax35Text PaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    [DataMember]
    public required PaymentMethod2Code PaymentMethod { get; init; } 
    /// <summary>
    /// Type of advice details requested.
    /// </summary>
    [DataMember]
    public AdviceType1? RequestedAdviceType { get; init; } 
    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    [DataMember]
    public IsoBatchBookingIndicator? BatchBooking { get; init; } 
    /// <summary>
    /// Number of individual transactions contained in the payment information group.
    /// </summary>
    [DataMember]
    public IsoMax15NumericText? NumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the group, irrespective of currencies.
    /// </summary>
    [DataMember]
    public IsoDecimalNumber? ControlSum { get; init; } 
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [DataMember]
    public PaymentTypeInformation29? PaymentTypeInformation { get; init; } 
    /// <summary>
    /// Date and time at which the creditor requests that the amount of money is to be collected from the debtor.
    /// </summary>
    [DataMember]
    public required IsoISODate RequestedCollectionDate { get; init; } 
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [DataMember]
    public required PartyIdentification135 Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [DataMember]
    public required CashAccount38 CreditorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [DataMember]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent in the payment chain.
    /// </summary>
    [DataMember]
    public CashAccount38? CreditorAgentAccount { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [DataMember]
    public PartyIdentification135? UltimateCreditor { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [DataMember]
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Account used to process charges associated with a transaction.||Usage: Charges account should be used when charges have to be booked to an account different from the account identified in debtor's account.
    /// </summary>
    [DataMember]
    public CashAccount38? ChargesAccount { get; init; } 
    /// <summary>
    /// Agent that services a charges account.||Usage: Charges account agent should only be used when the charges account agent is different from the creditor agent.
    /// </summary>
    [DataMember]
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountAgent { get; init; } 
    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [DataMember]
    public PartyIdentification135? CreditorSchemeIdentification { get; init; } 
    /// <summary>
    /// Provides information on the individual transaction(s) included in the message.
    /// </summary>
    [DataMember]
    public ValueList<DirectDebitTransactionInformation23> DirectDebitTransactionInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
