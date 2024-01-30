﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AccountsListAndBalanceDetails.  ISO2002 ID# _QSXgYdp-Ed-ak6NoX_4Aeg_1685362038.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification9Choice;

/// <summary>
/// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
/// </summary>
public partial record AccountsListAndBalanceDetails : IAccountIdentification9Choice
{
    #nullable enable
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public required IsoMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public IPartyIdentification13Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    public ISafekeepingPlaceFormat2Choice? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Balance to which the payment applies (less or equal to the total eligible balance).
    /// </summary>
    public required IBalanceFormat1Choice ConfirmedBalance { get; init; } 
    #nullable disable
}
