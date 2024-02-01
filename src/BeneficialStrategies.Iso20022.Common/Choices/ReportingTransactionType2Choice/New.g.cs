﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for New.  ISO2002 ID# _XM1TEZ26Eeuwmdq0KtnICg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReportingTransactionType2Choice;

/// <summary>
/// Transaction is a newly reported transaction.
/// </summary>
public partial record New : ReportingTransactionType2Choice_
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identification of the transaction.
    /// </summary>
    public required IsoMax52Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the entity executing the transaction.
    /// </summary>
    public required IsoLEIIdentifier ExecutingParty { get; init; } 
    /// <summary>
    /// Indicates whether the reporting party is defined as an investment firm under the local regulation or not.
    /// </summary>
    public required IsoTrueFalseIndicator InvestmentPartyIndicator { get; init; } 
    /// <summary>
    /// Entity submitting the transaction report to the competent authority.
    /// </summary>
    public required IsoLEIIdentifier SubmittingParty { get; init; } 
    /// <summary>
    /// Identifies the acquirer of the legal title to the financial instrument.
    /// </summary>
    public required PartyIdentification79 Buyer { get; init; } 
    /// <summary>
    /// Identifies the seller of the legal title to the financial instrument.
    /// </summary>
    public required PartyIdentification79 Seller { get; init; } 
    /// <summary>
    /// Indication as to whether the transaction results from an order transmitted by the reporting of a client to a third party.
    /// Usage: Only applicable when the conditions for transmission are not satisfied.
    /// </summary>
    public required SecuritiesTransactionTransmission2 OrderTransmission { get; init; } 
    /// <summary>
    /// Provides the details of the reported transaction.
    /// </summary>
    public required SecuritiesTransaction1 Transaction { get; init; } 
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required FinancialInstrumentAttributes4Choice_ FinancialInstrument { get; init; } 
    /// <summary>
    /// Identifies the person or algorithm which is responsible within the reporting party for the investment decision.
    /// </summary>
    public InvestmentParty1Choice_? InvestmentDecisionPerson { get; init; } 
    /// <summary>
    /// Person or algorithm responsible for the execution of the transaction.
    /// </summary>
    public required ExecutingParty1Choice_ ExecutingPerson { get; init; } 
    /// <summary>
    /// Provides additional indicators on the reported transaction.
    /// </summary>
    public required SecuritiesTransactionIndicator2 AdditionalAttributes { get; init; } 
    /// <summary>
    /// Data used for exchanges between national competent authorities, not to be used by reporting entities.
    /// </summary>
    public RecordTechnicalData5? TechnicalAttributes { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
