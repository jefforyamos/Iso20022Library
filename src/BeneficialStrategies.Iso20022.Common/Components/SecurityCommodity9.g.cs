﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityCommodity9.  ISO2002 ID# _97aFscg4Eeu4ecZgAYuz5w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indication of the type of assets subject of the transaction.
/// </summary>
public partial record SecurityCommodity9
{
    #nullable enable
    
    /// <summary>
    /// Data specific to securities being subject to the transaction.
    /// </summary>
    public Security51[] Security { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Data specific to commodities being subject to the transaction.
    /// </summary>
    public Commodity43[] Commodity { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
