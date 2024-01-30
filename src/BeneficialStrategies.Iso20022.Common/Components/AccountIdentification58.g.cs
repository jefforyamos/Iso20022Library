﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountIdentification58.  ISO2002 ID# _H-OIkRn1EeyroI8qKgB7Mg.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account information and detailed account holdings information report for corporate action events.
/// </summary>
public partial record AccountIdentification58
{
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public IsoMax35Text? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; } 
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
    public CorporateActionEventAndBalance22? CorporateActionEventAndBalance { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
