﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformationSD31.  ISO2002 ID# _Qgcssb5aEeexmbB7KsjCwA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action general information.
/// </summary>
public partial record CorporateActionGeneralInformationSD31
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public required SecurityIdentification20 SecurityIdentification { get; init; } 
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Additional information about the corporate action event.
    /// </summary>
    public CorporateActionUnallocatedDetailsSD6? UnallocatedDetails { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
