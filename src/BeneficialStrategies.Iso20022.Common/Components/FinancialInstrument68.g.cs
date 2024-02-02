﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument68.  ISO2002 ID# _bCyMAU4CEeiQHa-q1Uephw.
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
public partial record FinancialInstrument68
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
    /// Specifies the quantity of assets to be transferred in units or in a percentage rate.
    /// </summary>
    [DataMember]
    public required Quantity44Choice_ Quantity { get; init; } 
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
    /// Net asset on the balance sheet, the total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [DataMember]
    public DateAndAmount2? TotalBookValue { get; init; } 
    /// <summary>
    /// Date and market value of the asset. 
    /// </summary>
    [DataMember]
    public DateAndAmount2? LatestValuation { get; init; } 
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
    /// Specifies the number of units that have been received (crystallised) or not yet received (uncrystallised) from the fund. This is typically relevant to a pension fund.
    /// </summary>
    [DataMember]
    public ValueList<Crystallisation1> CrystallisationDetails { get; init; } = []; // Warning: Don't know multiplicity.
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
