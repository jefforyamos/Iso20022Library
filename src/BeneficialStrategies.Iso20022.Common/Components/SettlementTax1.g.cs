﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementTax1.  ISO2002 ID# _S0j3LAEcEeCQm6a_G2yO_w_811596505.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Species the tax applicable for this settlement.
/// </summary>
public partial record SettlementTax1
{
    #nullable enable
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    public TaxTypeFormat1Choice_? TypeCode { get; init; } 
    /// <summary>
    /// Monetary value resulting from the calculation of this tax, levy or duty.
    /// </summary>
    public IsoCurrencyAndAmount[] CalculatedAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value used as the basis on which this tax, levy or duty is calculated.
    /// </summary>
    public IsoCurrencyAndAmount[] BasisAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Date of the tax point when this tax, levy or duty becomes applicable.
    /// </summary>
    public IsoISODate? TaxPointDate { get; init; } 
    
    #nullable disable
}
