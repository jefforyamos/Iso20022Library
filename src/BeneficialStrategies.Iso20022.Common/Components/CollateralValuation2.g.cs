﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralValuation2.  ISO2002 ID# _7ZNbl2A4EeSMf75YyPqG7w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the valuation of each piece of collateral that is posted.
/// </summary>
[DataContract]
[XmlType]
public partial record CollateralValuation2
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the valued collateral.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CollateralIdentification { get; init; } 
    /// <summary>
    /// Specifies the type of collateral used.
    /// </summary>
    [DataMember]
    public required CollateralType1Code CollateralType { get; init; } 
    /// <summary>
    /// Provides the status of settlement of an instruction/financial instrument movement.
    /// </summary>
    [DataMember]
    public required SettlementStatus2Code SettlementStatus { get; init; } 
    /// <summary>
    /// Specifies the number of days used for interest calculation.
    /// </summary>
    [DataMember]
    public required IsoNumber NumberOfDaysAccrued { get; init; } 
    /// <summary>
    /// Provides details on the collateral valuation.
    /// </summary>
    [DataMember]
    public required CollateralAmount1 ValuationAmounts { get; init; } 
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [DataMember]
    public required InterestComputationMethod2Code DayCountBasis { get; init; } 
    /// <summary>
    /// Specifies the exchange rate between the currency of the collateral and the reporting currency.
    /// </summary>
    [DataMember]
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    /// <summary>
    /// Specifies the haircut or valuation factor on the currency of the collateral expressed as a percentage.
    /// </summary>
    [DataMember]
    public IsoBaseOneRate? CurrencyHaircut { get; init; } 
    /// <summary>
    /// Percentage by which the collateral amount needs to be adjusted.
    /// </summary>
    [DataMember]
    public IsoBaseOneRate? AdjustedRate { get; init; } 
    /// <summary>
    /// Provides details on the securities collateral.
    /// </summary>
    [DataMember]
    public SecuritiesCollateral2? SecuritiesCollateral { get; init; } 
    /// <summary>
    /// Provides details on the cash collateral valuation.
    /// </summary>
    [DataMember]
    public CashCollateral4? CashCollateral { get; init; } 
    /// <summary>
    /// Provides details on other collateral valuation.
    /// </summary>
    [DataMember]
    public OtherCollateral3? OtherCollateral { get; init; } 
    
    #nullable disable
}
