﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContractType8.  ISO2002 ID# _Zj1khQ1HEeqV4s5SpzR1dQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to contract attributes.
/// </summary>
public partial record ContractType8
{
    #nullable enable
    
    /// <summary>
    /// Classification of information according to contract type.
    /// </summary>
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    /// <summary>
    /// Specifies the classification according to the asset class of the contract.
    /// </summary>
    public ProductType4Code? AssetClass { get; init; } 
    /// <summary>
    /// Specifies the classification of the derivative product.
    /// </summary>
    public IProductClassification1Choice? ProductClassification { get; init; } 
    /// <summary>
    /// Specifies the identification of the derivative product.
    /// </summary>
    public ISecurityIdentification18Choice? ProductIdentification { get; init; } 
    /// <summary>
    /// Unique identification to identify the direct underlying instrument based on its type.
    /// </summary>
    public ISecurityIdentification34Choice? UnderlyingInstrument { get; init; } 
    /// <summary>
    /// Currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of first leg.
    /// </summary>
    public ActiveCurrencyCode? NotionalCurrencyFirstLeg { get; init; } 
    /// <summary>
    /// Other currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of the second leg.
    /// </summary>
    public ActiveCurrencyCode? NotionalCurrencySecondLeg { get; init; } 
    /// <summary>
    /// Specifies the currency to be delivered.
    /// </summary>
    public ActiveCurrencyCode? DeliverableCurrency { get; init; } 
    
    #nullable disable
}
