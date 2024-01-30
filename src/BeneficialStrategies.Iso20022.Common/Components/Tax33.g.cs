﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Tax33.  ISO2002 ID# _T-i_sERSEeeb1MmUPTrSMw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of tax.
/// </summary>
public partial record Tax33
{
    #nullable enable
    
    /// <summary>
    /// Type of tax.
    /// </summary>
    public required AddendumTaxType1Code Type { get; init; } 
    /// <summary>
    /// Other type of tax. Describes the type of tax when Other, Other National, Other Private or Other Taxes Type is selected. 
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Description of the tax.
    /// </summary>
    public IsoMax35Text? Description { get; init; } 
    /// <summary>
    /// Exemption for this type of tax.
    /// True: Exemption of tax
    /// False: No exemption of tax
    /// </summary>
    public IsoTrueFalseIndicator? TaxExemption { get; init; } 
    /// <summary>
    /// Reason for tax exemption.
    /// </summary>
    public IsoMax35Text? TaxExemptReason { get; init; } 
    /// <summary>
    /// Tax amount.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Tax rate applied on original amount.
    /// </summary>
    public IsoPercentageRate? Rate { get; init; } 
    
    #nullable disable
}
