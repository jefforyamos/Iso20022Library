﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AccountsListAndBalanceDetails.  ISO2002 ID# _wXf6yzq3EeWQ1Y7f8kds2A.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification32Choice;

/// <summary>
/// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
/// </summary>
public partial record AccountsListAndBalanceDetails : IAccountIdentification32Choice
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
    /// Provides information about balance related to a corporate action.
    /// </summary>
    public CorporateActionBalanceDetails29? Balance { get; init; } 
    #nullable disable
}
