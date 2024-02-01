﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformationSD26.  ISO2002 ID# _5UBlEZEsEeajS_7NioJdVA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action general information.
/// </summary>
public partial record CorporateActionGeneralInformationSD26
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public required SecurityIdentification15 SecurityIdentification { get; init; } 
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Additional information about the corporate action event.
    /// </summary>
    public CorporateActionUnallocatedDetailsSD5[] UnallocatedDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
