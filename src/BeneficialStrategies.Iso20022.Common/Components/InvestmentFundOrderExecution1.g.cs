﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentFundOrderExecution1.  ISO2002 ID# _R60r-dp-Ed-ak6NoX_4Aeg_-571676430.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of an order, deal reference, client reference and master reference.
/// </summary>
public partial record InvestmentFundOrderExecution1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Indicates whether a confirmation amendment message will follow the confirmation cancellation instruction or not.
    /// </summary>
    public required IsoYesNoIndicator AmendmentIndicator { get; init; } 
    /// <summary>
    /// Reference of an order, client or deal reference.
    /// </summary>
    public InvestmentFundOrderExecution2? OrderReferences { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
