﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DomesticAccount.  ISO2002 ID# _su6ah_SaEeSfzLT5J5kvFg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification31Choice;

/// <summary>
/// Account number used by financial institutions in individual countries to identify an account of a customer, but not necessarily the bank and branch of the financial institution in which the account is held.
/// </summary>
public partial record DomesticAccount : IAccountIdentification31Choice
{
    #nullable enable
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    #nullable disable
}
