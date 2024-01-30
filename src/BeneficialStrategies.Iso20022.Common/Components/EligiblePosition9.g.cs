﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EligiblePosition9.  ISO2002 ID# _Z8ACF_NjEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a securities position and rights holders.
/// </summary>
public partial record EligiblePosition9
{
    #nullable enable
    
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    public required IsoMax35Text AccountIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public IPartyIdentification231Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, for example, sub-balance per status.
    /// </summary>
    // public IReadOnlyCollection<HoldingBalance9> HoldingBalance { get; init; }
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    // public IReadOnlyCollection<IPartyIdentification233Choice> RightsHolder { get; init; }
    
    #nullable disable
}
