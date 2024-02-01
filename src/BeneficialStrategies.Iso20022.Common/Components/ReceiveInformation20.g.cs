﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReceiveInformation20.  ISO2002 ID# _9uZMMZEGEem7fvtoGpNpow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
public partial record ReceiveInformation20
{
    #nullable enable
    
    /// <summary>
    /// Party that receives (transferee) securities from the delivering agent (transferor).
    /// </summary>
    public PartyIdentification139? Transferee { get; init; } 
    /// <summary>
    /// Account into which the securities are to be received.
    /// </summary>
    public Account31? TransfereeRegisteredAccount { get; init; } 
    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    public Intermediary43[] IntermediaryInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Form, that is, ownership, of the security, that is, registered or bearer.
    /// </summary>
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    /// <summary>
    /// Indicates whether a security exists only as an electronic record, that is, there is no physical document representing the security.
    /// </summary>
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference2Code? IncomePreference { get; init; } 
    /// <summary>
    /// Beneficial owner or its designated agent certifies that it complies with any holding or investment restrictions or requirements of the fund.
    /// </summary>
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; } 
    /// <summary>
    /// Date used as the trade date when securities are settled through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IsoISODate? RequestedTradeDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IsoISODate? RequestedSettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; init; } 
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    /// <summary>
    /// Specifies if whether the settlement amount includes the stamp duty amount.
    /// </summary>
    public StampDutyType2Code? StampDuty { get; init; } 
    /// <summary>
    /// Deal amount.
    /// </summary>
    public IsoActiveCurrencyAndAmount? NetAmount { get; init; } 
    /// <summary>
    /// Fee related to the transfer of the financial instrument.
    /// </summary>
    public Fees2[] Fees { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Tax related to the transfer of the financial instrument.
    /// </summary>
    public Tax38[] IndividualTax { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// How the exchange rate is expressed determines which currency is the Unit Currency and Quoted Currency. If the amounts concerned are EUR 1000 and USD 1300, the exchange rate may be expressed as per either of the following examples:
    /// EXAMPLE 1 
    /// UnitCurrency EUR
    /// QuotedCurrency USD
    /// ExchangeRate 1.300
    /// EXAMPLE 2
    /// UnitCurrency USD
    /// QuotedCurrency EUR
    /// ExchangeRate 0.769.
    /// </summary>
    public ForeignExchangeTerms37[] ForeignExchangeDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Chain of parties involved in the settlement of the transaction.
    /// </summary>
    public FundSettlementParameters16? SettlementPartiesDetails { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; } 
    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    public DeliveryParameters4? PhysicalTransferDetails { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    public AdditionalReference10? ClientReference { get; init; } 
    
    #nullable disable
}
