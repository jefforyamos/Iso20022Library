﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountIdentification45.  ISO2002 ID# _YrDjUbXDEeiTob_PrFFUxA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account information and detailed account holdings information report for corporate action events.
/// </summary>
public partial record AccountIdentification45
{
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public required IsoMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public IPartyIdentification127Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    public ISafekeepingPlaceFormat28Choice? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Detailed account holdings information report for a corporate action event.
    /// </summary>
    public CorporateActionEventAndBalance15? CorporateActionEventAndBalance { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
