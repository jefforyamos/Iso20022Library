﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EligiblePosition4.  ISO2002 ID# _R7tcwtp-Ed-ak6NoX_4Aeg_-758914703.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the voting entitlement.
/// </summary>
public partial record EligiblePosition4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Identifies party that legally owns the account.
    /// </summary>
    public PartyIdentification39? AccountOwner { get; init; } 
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    // public IReadOnlyCollection<HoldingBalance6> HoldingBalance { get; init; }
    /// <summary>
    /// Identifies owner of the voting rights.
    /// </summary>
    // public IReadOnlyCollection<PartyIdentification39> RightsHolder { get; init; }
    
    #nullable disable
}
