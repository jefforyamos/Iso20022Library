﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ForAllAccounts.  ISO2002 ID# _wXf6wzq3EeWQ1Y7f8kds2A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification32Choice;

/// <summary>
/// All safekeeping accounts that own underlying financial instrument.
/// </summary>
public partial record ForAllAccounts : IAccountIdentification32Choice
{
    #nullable enable
    /// <summary>
    /// Standard code to specify that announcement applies to all safekeeping accounts that own underlying financial instrument.
    /// </summary>
    public required SafekeepingAccountIdentification1Code IdentificationCode { get; init; } 
    #nullable disable
}
