﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument69.  ISO2002 ID# _QN2MiUyGEeir2sRRVd9XhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security or other asset.
/// </summary>
[DataContract]
[XmlType]
public partial record FinancialInstrument69
{
    #nullable enable
    
    /// <summary>
    /// Identification of the line of holding in the portfolio.
    /// </summary>
    [DataMember]
    public IsoMax35Text? LineIdentification { get; init; } 
    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [DataMember]
    public required FinancialInstrument1Choice_ Instrument { get; init; } 
    /// <summary>
    /// Quantity of asset to be transferred.
    /// </summary>
    [DataMember]
    public Quantity44Choice_? Quantity { get; init; } 
    /// <summary>
    /// Specifies how the financial instrument is transferred.
    /// </summary>
    [DataMember]
    public required TransferType1Choice_ TransferType { get; init; } 
    /// <summary>
    /// Security is to be converted into another security before transfer.
    /// </summary>
    [DataMember]
    public Conversion1? Conversion { get; init; } 
    /// <summary>
    /// Breakdown of units.
    /// </summary>
    [DataMember]
    public ValueList<Unit11> UnitsDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [DataMember]
    public AdditionalReference10? ClientReference { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [DataMember]
    public AdditionalReference10? CounterpartyReference { get; init; } 
    /// <summary>
    /// Business process in which the actors are involved. This will facilitate the right business process to be triggered, according to the market business model, which may require matching instructions (double leg process) or not (single leg process).
    /// </summary>
    [DataMember]
    public BusinessFlowType1Code? BusinessFlowType { get; init; } 
    /// <summary>
    /// Average cost per share of the security, including all fees.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; init; } 
    /// <summary>
    /// Currency to be used to transfer the holdings. Some transfer agents register holdings grouped by currency in addition to using the ISIN for multi-currency fund shares.
    /// </summary>
    [DataMember]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; } 
    /// <summary>
    /// Net asset on the balance sheet, the total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [DataMember]
    public DateAndAmount2? TotalBookValue { get; init; } 
    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// (Party and account into which the transferee receives the financial instrument from the transferor.)
    /// </summary>
    [DataMember]
    public Account28? TransfereeAccount { get; init; } 
    /// <summary>
    /// Party and account from which the transferor delivers the financial instrument to the transferee.
    /// </summary>
    [DataMember]
    public Account28? Transferor { get; init; } 
    /// <summary>
    /// Date for which the instructing party requests the transfer.
    /// </summary>
    [DataMember]
    public IsoISODate? RequestedTransferDate { get; init; } 
    /// <summary>
    /// Date to be used as the trade date when securities are settled through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [DataMember]
    public IsoISODate? RequestedTradeDate { get; init; } 
    /// <summary>
    /// Date at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [DataMember]
    public IsoISODate? RequestedSettlementDate { get; init; } 
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [DataMember]
    public PaymentInstrument14? PaymentDetails { get; init; } 
    /// <summary>
    /// Specifies the number of units that have been received (crystallised) or not yet received (uncrystallised) from the fund. This is typically relevant to a pension fund.
    /// </summary>
    [DataMember]
    public Crystallisation1? CrystallisationDetails { get; init; } 
    /// <summary>
    /// Date or tax quarter used for the calculation of tax on the asset.
    /// </summary>
    [DataMember]
    public Tax36? TaxValuationPoint { get; init; } 
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [DataMember]
    public FundSettlementParameters14? SettlementPartiesDetails { get; init; } 
    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    [DataMember]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
