﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Account.  ISO2002 ID# _nArEUPNBEeCuA5Tr22BnwA_-379442712.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType7Choice;

/// <summary>
/// Account identification.
/// </summary>
public partial record Account : BalanceType7Choice_
{
    #nullable enable
    /// <summary>
    /// Unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Description of the account.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Specifies the type of account.
    /// </summary>
    public GenericIdentification30? Type { get; init; } 
    #nullable disable
}
