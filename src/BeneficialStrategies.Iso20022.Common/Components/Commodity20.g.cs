﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Commodity20.  ISO2002 ID# _MMF1181VEem4K5qLxnWwMA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data specific to commodities and related fields used as a collateral.
/// </summary>
[DataContract]
[XmlType]
public partial record Commodity20
{
    #nullable enable
    
    /// <summary>
    /// Details on commodities assignments to sectors.
    /// </summary>
    [DataMember]
    public AssetClassCommodity5Choice_? Classification { get; init; } 
    /// <summary>
    /// Quantity of the commodity.
    /// </summary>
    [DataMember]
    public Quantity17? Quantity { get; init; } 
    /// <summary>
    /// Price of unit of asset or collateral component, including accrued interest for interest-bearing securities, used to value the commodity .
    /// </summary>
    [DataMember]
    public SecuritiesTransactionPrice11Choice_? UnitPrice { get; init; } 
    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? MarketValue { get; init; } 
    
    #nullable disable
}
