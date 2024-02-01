﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementSubTotalCalculatedTax1.  ISO2002 ID# _S0j3JQEcEeCQm6a_G2yO_w_-1391363136.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the subtotal calculated tax applicable for this settlement.
/// </summary>
public partial record SettlementSubTotalCalculatedTax1
{
    #nullable enable
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    public IsoMax4Text? TypeCode { get; init; } 
    /// <summary>
    /// Reference used to identify the nature of tax levied, such as Value Added Tax (VAT).
    /// </summary>
    public IsoMax4Text? CategoryCode { get; init; } 
    /// <summary>
    /// Monetary value resulting from the calculation of this tax, levy or duty.
    /// </summary>
    public IsoCurrencyAndAmount[] CalculatedAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value used as the basis on which this tax, levy or duty is calculated.
    /// </summary>
    public IsoCurrencyAndAmount[] BasisAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Rate used to calculate the amount of this tax, levy or duty.
    /// </summary>
    public IsoPercentageRate? CalculatedRate { get; init; } 
    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    public TaxExemptionReason1? ExemptionReason { get; init; } 
    
    #nullable disable
}
