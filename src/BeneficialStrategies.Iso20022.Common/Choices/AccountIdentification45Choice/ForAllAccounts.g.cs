﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ForAllAccounts.  ISO2002 ID# _csxii_fSEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification45Choice;

/// <summary>
/// All safekeeping accounts that own an underlying financial instrument.
/// </summary>
public partial record ForAllAccounts : IAccountIdentification45Choice
{
    #nullable enable
    /// <summary>
    /// Standard code to specify that announcement applies to all safekeeping accounts that own underlying financial instrument.
    /// </summary>
    public required SafekeepingAccountIdentification1Code IdentificationCode { get; init; } 
    #nullable disable
}
