﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ForAllAccounts.  ISO2002 ID# _qVGz6eaPEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification13Choice;

/// <summary>
/// All safekeeping accounts that own underlying financial instrument.
/// </summary>
public partial record ForAllAccounts : AccountIdentification13Choice_
{
    #nullable enable
    /// <summary>
    /// Standard code to specify that announcement applies to all safekeeping accounts that own underlying financial instrument.
    /// </summary>
    public required SafekeepingAccountIdentification1Code IdentificationCode { get; init; } 
    #nullable disable
}
