﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NewBeneficiary.  ISO2002 ID# _-Eq_sXltEeG7BsjMvd1mEw_-1059783639.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AddressOrParty1Choice;

/// <summary>
/// New beneficiary.
/// </summary>
public partial record NewBeneficiary : IAddressOrParty1Choice
{
    #nullable enable
    /// <summary>
    /// Name by which a party is known and is usually used to identify that party.
    /// </summary>
    public required IsoMax140Text Name { get; init; } 
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    public required PostalAddress6 Address { get; init; } 
    #nullable disable
}
