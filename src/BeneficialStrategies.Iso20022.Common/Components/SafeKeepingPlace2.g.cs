﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SafeKeepingPlace2.  ISO2002 ID# _JLYF8ZjwEeWn2ur3BXxtdg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
/// </summary>
public partial record SafeKeepingPlace2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    public SafekeepingPlaceFormat17Choice_? SafekeepingPlaceFormat { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for a place of safekeeping.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    
    #nullable disable
}
