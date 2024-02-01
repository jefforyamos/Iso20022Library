﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferStatusAndReason8.  ISO2002 ID# _UEdjodx9EeqKxsvOxFQHKA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the status of a transfer instruction and its reason.
/// </summary>
public partial record TransferStatusAndReason8
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the transfer, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text TransferReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    public AdditionalReference10? ClientReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    /// <summary>
    /// Type of event for which the message is sent.
    /// </summary>
    public TransferStatusType3Choice_[] TransferEventType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    public required TransferStatus5Choice_ TransferStatus { get; init; } 
    /// <summary>
    /// Identification of the asset.
    /// </summary>
    public FinancialInstrument63Choice_? Instrument { get; init; } 
    /// <summary>
    /// Investment account information of the transfer for which the status or information is provided.
    /// </summary>
    public Account33? InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    public Intermediary48[] IntermediaryInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Date on which the transfer was executed.
    /// In some scenarios, this is the date and time to be used as the trade date when securities are settled through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IsoISODate? TradeDate { get; init; } 
    /// <summary>
    /// Date at which the securities are to be exchanged or were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IsoISODate? SettlementDate { get; init; } 
    /// <summary>
    /// Date on which the document, for example, the application form, was sent.
    /// </summary>
    public IsoISODate? SendOutDate { get; init; } 
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    public IsoISODate? CashSettlementDate { get; init; } 
    /// <summary>
    /// Number of units to be transferred.
    /// </summary>
    public IsoDecimalNumber? TotalUnitsNumber { get; init; } 
    /// <summary>
    /// Weighted average price of the units in the account. The average price may also be known as the average acquisition price.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    /// <summary>
    /// Breakdown of units to be transferred.
    /// </summary>
    public Unit11[] UnitsDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Information about the source security following a conversion.
    /// </summary>
    public Conversion2? Conversion { get; init; } 
    /// <summary>
    /// Total transfer value.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? TotalTransferValue { get; init; } 
    /// <summary>
    /// Details of a payment that will result from or resulting from the liquation of an asset and transfer of cash or for the transfer of cash that was not invested.
    /// </summary>
    public PaymentInstrument18[] PaymentDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Information about the realisation of benefits taken from a pension.
    /// </summary>
    public BenefitCrystallisationEvent2[] BenefitCrystallisationEvent { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Details of a drawdown tranche.
    /// </summary>
    public Drawdown2[] DrawdownTranche { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Drawdown information not specifically associated with a drawdown tranche.
    /// </summary>
    public Drawdown3? OtherDrawdownInformation { get; init; } 
    /// <summary>
    /// Response information.
    /// </summary>
    public IsoMax350Text[] QueryResponse { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    public PartyIdentification139? StatusInitiator { get; init; } 
    /// <summary>
    /// Party that issues the status or information message.
    /// </summary>
    public PartyIdentification139? StatusIssuer { get; init; } 
    /// <summary>
    /// Party that receives the status or information message.
    /// </summary>
    public PartyIdentification139? StatusRecipient { get; init; } 
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    public AdditionalInformation15[] AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
