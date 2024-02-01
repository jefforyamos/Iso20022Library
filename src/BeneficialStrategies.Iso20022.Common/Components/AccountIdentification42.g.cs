﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountIdentification42.  ISO2002 ID# _SQmVUaWPEeahOrvW2rewGg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides account identification information.
/// </summary>
public partial record AccountIdentification42
{
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification103Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    public SafekeepingPlaceFormat27Choice_? SafekeepingPlace { get; init; } 
    
    #nullable disable
}
