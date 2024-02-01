﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Sale2.  ISO2002 ID# _3kUpYSCAEey8XKHwKquEQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of good and services included in the sale.
/// </summary>
public partial record Sale2
{
    #nullable enable
    
    /// <summary>
    /// Sale summary information.
    /// </summary>
    public SaleSummary1? Summary { get; init; } 
    /// <summary>
    /// Sale line item information.
    /// </summary>
    public SaleItem3[] LineItem { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
