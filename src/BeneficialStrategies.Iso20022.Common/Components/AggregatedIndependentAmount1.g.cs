﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AggregatedIndependentAmount1.  ISO2002 ID# _UlI9I9p-Ed-ak6NoX_4Aeg_1735271850.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Independent amount could be defined at a trade level or portfolio level. It is assumed that their treatment will be based on the exposure convention that is whether netted together or treated on a gross basis.
/// </summary>
public partial record AggregatedIndependentAmount1
{
    #nullable enable
    
    /// <summary>
    /// Total independent amount defined in the confirmations of individual trades.
    /// </summary>
    public IndependentAmount1? Trade { get; init; } 
    /// <summary>
    /// Portfolio level independent amount that reflects portfolio change over a short time period using statistical techniques such as volatility and risk factor correlations.
    /// </summary>
    public IndependentAmount1? ValueAtRisk { get; init; } 
    /// <summary>
    /// Portfolio level independent amount related to parties net open position. Net open position means the total of the net long FX and the net options in respect of each currency where: net long FX for any currency shall be the net amount (if any) of that currency which the party “A” is long as against party “B” in respect of all FX transactions.
    /// </summary>
    public IndependentAmount1? NetOpenPosition { get; init; } 
    /// <summary>
    /// Any other amount that should be considered to calculate the independent amount.
    /// </summary>
    public IndependentAmount2? OtherAmount { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
