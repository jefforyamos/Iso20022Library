﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentFundOrder5.  ISO2002 ID# _TSS1O9p-Ed-ak6NoX_4Aeg_1004775206.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of an order and order cancellation.
/// </summary>
public partial record InvestmentFundOrder5
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text OrderReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an order cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    
    #nullable disable
}
