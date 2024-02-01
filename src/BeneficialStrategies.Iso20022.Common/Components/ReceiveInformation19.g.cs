﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReceiveInformation19.  ISO2002 ID# _Ew7CTYfuEeevKP8c-ilVhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
public partial record ReceiveInformation19
{
    #nullable enable
    
    /// <summary>
    /// Party that receives (transferee) securities from the delivering agent (transferor).
    /// </summary>
    public PartyIdentification113? Transferee { get; init; } 
    /// <summary>
    /// Account into which the securities are to be received.
    /// </summary>
    public Account24? TransfereeRegisteredAccount { get; init; } 
    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    public Intermediary41[] IntermediaryInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IsoISODate? RequestedSettlementDate { get; init; } 
    /// <summary>
    /// Total amount of money paid/to be paid or received in exchange for the financial instrument.
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
    public Fees1[] Fees { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Tax related to the transfer of the financial instrument.
    /// </summary>
    public Tax34[] IndividualTax { get; init; } = []; // Warning: Don't know multiplicity.
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
    public ForeignExchangeTerms33[] ForeignExchangeDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Chain of parties involved in the settlement of the transaction.
    /// </summary>
    public ReceivingPartiesAndAccount17? SettlementPartiesDetails { get; init; } 
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
    public AdditionalReference8? ClientReference { get; init; } 
    
    #nullable disable
}
