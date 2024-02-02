﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOption6.  ISO2002 ID# _UGcO-dp-Ed-ak6NoX_4Aeg_221261687.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action security option.
/// </summary>
[DataContract]
[XmlType]
public partial record SecuritiesOption6
{
    #nullable enable
    
    /// <summary>
    /// Provides description of the financial instrument related to securities movement.
    /// </summary>
    [DataMember]
    public required FinancialInstrumentAttributes5 SecurityDetails { get; init; } 
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [DataMember]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies that the security identified is a temporary security identification used for processing reasons, for example, contra security used in the US.
    /// </summary>
    [DataMember]
    public TemporaryFinancialInstrumentIndicator1Choice_? TemporaryFinancialInstrumentIndicator { get; init; } 
    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    [DataMember]
    public NonEligibleProceedsIndicator1Choice_? NonEligibleProceedsIndicator { get; init; } 
    /// <summary>
    /// Quantity of securities based on the terms of the corporate action event and balance of underlying securities entitled to the account owner. (This quantity can be positive or negative).
    /// </summary>
    [DataMember]
    public Quantity6Choice_? EntitledQuantity { get; init; } 
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [DataMember]
    public FractionDispositionType1Choice_? FractionDisposition { get; init; } 
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [DataMember]
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    [DataMember]
    public Period1Choice_? TradingPeriod { get; init; } 
    /// <summary>
    /// Provides information about the dates related to securities movement.
    /// </summary>
    [DataMember]
    public required SecurityDate2 DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the rates related to securities movement.
    /// </summary>
    [DataMember]
    public CorporateActionRate7? RateDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to securities movement.
    /// </summary>
    [DataMember]
    public CorporateActionPrice10? PriceDetails { get; init; } 
    
    #nullable disable
}
