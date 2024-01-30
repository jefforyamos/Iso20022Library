﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountIdentification33.  ISO2002 ID# _fJ6PgTndEeWLJsP1cO-amg.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account information and detailed account holdings information report for corporate action events.
/// </summary>
public partial record AccountIdentification33
{
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public required IsoMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public IPartyIdentification92Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    public ISafekeepingPlaceFormat8Choice? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Detailed account holdings information report for a corporate action event.
    /// </summary>
    public CorporateActionEventAndBalance9? CorporateActionEventAndBalance { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
