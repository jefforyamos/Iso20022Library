﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AccountsListAndBalanceDetails.  ISO2002 ID# _Jg42I_pTEeCLrd06h-p51g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification18Choice;

/// <summary>
/// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
/// </summary>
public partial record AccountsListAndBalanceDetails : IAccountIdentification18Choice
{
    #nullable enable
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public required IsoMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public IPartyIdentification36Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    public ISafekeepingPlaceFormat2Choice? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    public CorporateActionBalanceDetails10? Balance { get; init; } 
    #nullable disable
}
