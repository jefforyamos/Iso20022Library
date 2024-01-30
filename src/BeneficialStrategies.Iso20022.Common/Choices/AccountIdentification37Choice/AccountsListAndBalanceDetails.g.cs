﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AccountsListAndBalanceDetails.  ISO2002 ID# _c4bUC5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification37Choice;

/// <summary>
/// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
/// </summary>
public partial record AccountsListAndBalanceDetails : IAccountIdentification37Choice
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
    /// Balance to which the payment applies (less or equal to the total eligible balance).
    /// </summary>
    public required IBalanceFormat7Choice ConfirmedBalance { get; init; } 
    #nullable disable
}
