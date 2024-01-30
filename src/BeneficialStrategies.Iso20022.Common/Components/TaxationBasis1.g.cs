﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxationBasis1.  ISO2002 ID# _VSvC8tp-Ed-ak6NoX_4Aeg_526119979.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the taxation basis.
/// </summary>
public partial record TaxationBasis1
{
    #nullable enable
    
    /// <summary>
    /// Structured format.
    /// </summary>
    public required TaxationBasis3Code Structured { get; init; } 
    /// <summary>
    /// Additional information about the type of taxation basis.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
