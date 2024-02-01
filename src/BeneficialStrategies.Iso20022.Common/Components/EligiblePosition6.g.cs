﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EligiblePosition6.  ISO2002 ID# _DLgcx1tjEeSwKe7KuKvXhg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the voting entitlement.
/// </summary>
public partial record EligiblePosition6
{
    #nullable enable
    
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Identifies the party that legally owns the account.
    /// </summary>
    public PartyIdentification71? AccountOwner { get; init; } 
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, for example, sub-balance per status.
    /// </summary>
    public HoldingBalance7[] HoldingBalance { get; init; } = [];
    /// <summary>
    /// Identifies the owner of the voting rights.
    /// </summary>
    public PartyIdentification71[] RightsHolder { get; init; } = [];
    
    #nullable disable
}
