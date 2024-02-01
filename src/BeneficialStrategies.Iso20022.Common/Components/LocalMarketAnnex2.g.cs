﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LocalMarketAnnex2.  ISO2002 ID# _Q5QhRdp-Ed-ak6NoX_4Aeg_-1175095471.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
/// </summary>
public partial record LocalMarketAnnex2
{
    #nullable enable
    
    /// <summary>
    /// Country in which the processing characteristic applies.
    /// </summary>
    public CountryCode[] Country { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Organisation established primarily to provide financial services.
    /// </summary>
    public required ContactAttributes1 LocalOrderDesk { get; init; } 
    /// <summary>
    /// Processing characteristics linked to the instrument, ie, not to the market.
    /// </summary>
    public required ProcessingCharacteristics2 SubscriptionProcessingCharacteristics { get; init; } 
    /// <summary>
    /// Processing characteristics linked to the instrument, ie, not to the market.
    /// </summary>
    public required ProcessingCharacteristics3 RedemptionProcessingCharacteristics { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public CashAccount22[] SettlementDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
