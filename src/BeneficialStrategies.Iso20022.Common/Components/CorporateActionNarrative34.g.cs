﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNarrative34.  ISO2002 ID# _chfbXZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the registration details.
/// </summary>
public partial record CorporateActionNarrative34
{
    #nullable enable
    
    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    public IsoRestrictedFINXMax350Text[] RegistrationDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    public IsoRestrictedFINXMax350Text[] PartyContactNarrative { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information required for the certification/breakdown.
    /// </summary>
    public IsoRestrictedFINXMax350Text[] CertificationBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
