﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PositionSetCollateralMetrics1.  ISO2002 ID# _imt2X8WJEeiRga8tPu1L4Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables used to quantify the different calculations for collateral position sets and currency collateral position sets reports.
/// </summary>
[DataContract]
[XmlType]
public partial record PositionSetCollateralMetrics1
{
    #nullable enable
    
    /// <summary>
    /// Total values by the reporting counterparty to the other counterparty. 
    /// Usage: Where the value is on a portfolio basis, this field should include the overall value  posted for the portfolio.
    /// </summary>
    [DataMember]
    public PositionSetCollateralTotal1? Total { get; init; } 
    /// <summary>
    /// Clean values by the reporting counterparty to the other counterparty with outliers removed. 
    /// Usage: Where the value is on a portfolio basis, this field should include the overall value posted for the portfolio.
    /// </summary>
    [DataMember]
    public PositionSetCollateralTotal1? Clean { get; init; } 
    
    #nullable disable
}
