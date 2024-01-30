﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ListExecution1.  ISO2002 ID# _SzmHCNp-Ed-ak6NoX_4Aeg_922397507.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about of a list that must be executed.
/// </summary>
public partial record ListExecution1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a list, as assigned by the trading party. The identifier must be unique within a single trading day.
    /// </summary>
    public required IsoMax35Text ListIdentification { get; init; } 
    /// <summary>
    /// Identifies a bid made by a client, to which the list is associated.
    /// </summary>
    public IsoMax35Text? ClientBidIdentification { get; init; } 
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
    /// </summary>
    public required IsoMax35Text BidIdentification { get; init; } 
    
    #nullable disable
}
