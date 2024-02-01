﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Tax6.  ISO2002 ID# _VScIA9p-Ed-ak6NoX_4Aeg_-1430262467.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax related to an investment fund order.
/// </summary>
public partial record Tax6
{
    #nullable enable
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    public required TaxType1 Type { get; init; } 
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    public required IsoPercentageRate Rate { get; init; } 
    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    public required IsoYesNoIndicator ExemptionIndicator { get; init; } 
    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    public TaxExemptionReason1? ExemptionReason { get; init; } 
    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    public TaxCalculationInformation1? TaxCalculationDetails { get; init; } 
    
    #nullable disable
}
