﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument86.  ISO2002 ID# _oUNLK5NBEemQB_8XA98K0Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security or other asset.
/// </summary>
public partial record FinancialInstrument86
{
    #nullable enable
    
    /// <summary>
    /// Identification of the line of holding in the portfolio.
    /// </summary>
    public IsoMax35Text? LineIdentification { get; init; } 
    /// <summary>
    /// Identification of the asset.
    /// </summary>
    public required FinancialInstrument63Choice_ Instrument { get; init; } 
    /// <summary>
    /// Quantity of asset to be transferred.
    /// </summary>
    public Quantity47? Quantity { get; init; } 
    /// <summary>
    /// Indicates that the quantity of asset to be transferred is a partially instructed quantity.
    /// </summary>
    public IsoYesNoIndicator? PartialInstructedQuantity { get; init; } 
    /// <summary>
    /// Specifies how the financial instrument is transferred.
    /// </summary>
    public required TransferType2Choice_ TransferType { get; init; } 
    /// <summary>
    /// Indicates the asset is a new asset, not previously identified by the transferor party (ceding party) in the account holding discovery process.
    /// </summary>
    public IsoYesNoIndicator? AdditionalAsset { get; init; } 
    /// <summary>
    /// Indicates the asset is no longer available at the transferor party (ceding party).
    /// </summary>
    public IsoYesNoIndicator? NotAvailable { get; init; } 
    /// <summary>
    /// Security is to be converted into another security before transfer.
    /// </summary>
    public Conversion1? Conversion { get; init; } 
    /// <summary>
    /// Breakdown of units.
    /// </summary>
    public Unit11[] UnitsDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    public AdditionalReference10? ClientReference { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    public AdditionalReference10? CounterpartyReference { get; init; } 
    /// <summary>
    /// Business process in which the actors are involved. This will facilitate the right business process to be triggered, according to the market business model, which may require matching instructions (double leg process) or not (single leg process).
    /// </summary>
    public BusinessFlowType1Code? BusinessFlowType { get; init; } 
    /// <summary>
    /// Average cost per share of the security, including all fees.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; init; } 
    /// <summary>
    /// Currency to be used to transfer the holdings. Some transfer agents register holdings grouped by currency in addition to using the ISIN for multi-currency fund shares.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; } 
    /// <summary>
    /// Net asset on the balance sheet, the total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    public DateAndAmount2? TotalBookValue { get; init; } 
    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// (Party and account into which the transferee receives the financial instrument from the transferor.)
    /// </summary>
    public Account28? TransfereeAccount { get; init; } 
    /// <summary>
    /// Party and account from which the transferor delivers the financial instrument to the transferee.
    /// </summary>
    public Account28? Transferor { get; init; } 
    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    public Intermediary43[] IntermediaryInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Date for which the instructing party requests the transfer.
    /// </summary>
    public IsoISODate? RequestedTransferDate { get; init; } 
    /// <summary>
    /// Date to be used as the trade date when securities are settled through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IsoISODate? RequestedTradeDate { get; init; } 
    /// <summary>
    /// Date at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IsoISODate? RequestedSettlementDate { get; init; } 
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    public PaymentInstrument14? PaymentDetails { get; init; } 
    /// <summary>
    /// Number of units that have been received (crystallised) or not yet received (uncrystallised) from the fund. This is typically relevant to a pension fund.
    /// </summary>
    public Crystallisation2[] CrystallisationDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Date or tax quarter used for the calculation of tax on the asset.
    /// </summary>
    public Tax36? TaxValuationPoint { get; init; } 
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    public FundSettlementParameters17? SettlementPartiesDetails { get; init; } 
    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    public AdditionalInformation15[] AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
