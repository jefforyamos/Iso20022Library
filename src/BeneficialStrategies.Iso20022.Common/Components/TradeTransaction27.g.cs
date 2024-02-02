﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeTransaction27.  ISO2002 ID# _yTcm8Q1JEeqV4s5SpzR1dQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of the trade transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record TradeTransaction27
{
    #nullable enable
    
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the counterparty.
    /// </summary>
    [DataMember]
    public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
    /// <summary>
    /// Unique number to indicate a group of reports which relate to the same execution.
    /// </summary>
    [DataMember]
    public IsoMax52Text? ReportTrackingNumber { get; init; } 
    /// <summary>
    /// Identification, internal to the reporting firm to identify all the reports related to the same execution of a combination of financial instruments. The code must be unique for the firm for the group of reports for the execution.
    /// Usage: Field only applies when the instrument is complex.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ComplexTradeIdentification { get; init; } 
    /// <summary>
    /// Venue of execution identified by a unique code for this venue. 
    /// In case of a contract concluded OTC, it has to be identified using specific MIC codes designating OTC transactions.
    /// </summary>
    [DataMember]
    public IsoMICIdentifier? TradingVenue { get; init; } 
    /// <summary>
    /// Identifies whether the contract results from a compression operation or not.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? Compression { get; init; } 
    /// <summary>
    /// Indicates the price per derivative excluding, where applicable, commission and accrued interest.
    /// </summary>
    [DataMember]
    public SecuritiesTransactionPrice10Choice_? Price { get; init; } 
    /// <summary>
    /// Reference amount from which contractual payments are determined.
    /// Usage: In case of partial terminations, and amortisations and in case of contracts where the notional, due to the characteristics of the contract, varies over time, it shall reflect the remaining notional after the change took place.
    /// </summary>
    [DataMember]
    public AmountAndDirection56? NotionalAmount { get; init; } 
    /// <summary>
    /// Number of units of the underlying instrument represented by a single derivative contract.
    /// </summary>
    [DataMember]
    public IsoLongFraction21DecimalNumber? PriceMultiplier { get; init; } 
    /// <summary>
    /// Number of units of the financial instrument, that is, the nominal value.
    /// </summary>
    [DataMember]
    public FinancialInstrumentQuantity30Choice_? Quantity { get; init; } 
    /// <summary>
    /// Amount of money of any up-front payment the reporting counterparty made or received.
    /// Usage: The negative symbol to be used to indicate that the payment was made, not received.
    /// </summary>
    [DataMember]
    public AmountAndDirection56? UpFrontPayment { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is settled physically or in cash or decided at expiration time by counterparty.
    /// </summary>
    [DataMember]
    public PhysicalTransferType4Code? DeliveryType { get; init; } 
    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    [DataMember]
    public IsoISODateTime? ExecutionDateTime { get; init; } 
    /// <summary>
    /// Indicates the date when obligations under the contract come into effect.
    /// </summary>
    [DataMember]
    public IsoISODate? EffectiveDate { get; init; } 
    /// <summary>
    /// Indicates the original date of expiry of the reported contract. 
    /// Usage: 
    /// An early termination shall not be reported in this field.
    /// </summary>
    [DataMember]
    public IsoISODate? MaturityDate { get; init; } 
    /// <summary>
    /// Indicates the date in the case of an early termination of the reported contract.
    /// </summary>
    [DataMember]
    public IsoISODate? TerminationDate { get; init; } 
    /// <summary>
    /// Indicates the date of settlement of the underlying.
    /// </summary>
    [DataMember]
    public ValueList<IsoISODate> SettlementDate { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Details related to the Master agreement.
    /// </summary>
    [DataMember]
    public MasterAgreement5? MasterAgreement { get; init; } 
    /// <summary>
    /// Provides information on whether the contract was electronically confirmed, non-electronically confirmed or remains unconfirmed.
    /// </summary>
    [DataMember]
    public TradeConfirmation2Choice_? TradeConfirmation { get; init; } 
    /// <summary>
    /// Information related to clearing of the reported contract.
    /// </summary>
    [DataMember]
    public TradeClearing3? TradeClearing { get; init; } 
    /// <summary>
    /// Information related to interest rate asset class type.
    /// </summary>
    [DataMember]
    public InterestRateLegs7? InterestRate { get; init; } 
    /// <summary>
    /// Information related to currency asset class type.
    /// </summary>
    [DataMember]
    public CurrencyExchange10? Currency { get; init; } 
    /// <summary>
    /// Information related to commodity asset class type.
    /// </summary>
    [DataMember]
    public AssetClassCommodity2Choice_? Commodity { get; init; } 
    /// <summary>
    /// Attributes specific for derivative contracts related to natural gas and electricity delivered in the European Union.
    /// </summary>
    [DataMember]
    public EnergySpecificAttribute5? EnergySpecificAttributes { get; init; } 
    /// <summary>
    /// Information related to credit derivative asset class type.
    /// </summary>
    [DataMember]
    public OptionOrSwaption4? Option { get; init; } 
    /// <summary>
    /// Information related to credit derivative asset class type.
    /// </summary>
    [DataMember]
    public CreditDerivative2? Credit { get; init; } 
    
    #nullable disable
}
