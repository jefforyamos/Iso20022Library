﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountAndBalance38.  ISO2002 ID# _cjtBI5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides account and balance information.
/// </summary>
public partial record AccountAndBalance38
{
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public IPartyIdentification103Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    public ISafekeepingPlaceFormat11Choice? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    public required CorporateActionBalanceDetails35 Balance { get; init; } 
    
    #nullable disable
}
