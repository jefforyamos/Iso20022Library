﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AccountReport.  ISO2002 ID# _fCDzsdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountOrOperationalError5Choice;

/// <summary>
/// Reports either on the account information or on a business error.
/// </summary>
public partial record AccountReport : IAccountOrOperationalError5Choice
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required IAccountIdentification4Choice AccountIdentification { get; init; } 
    /// <summary>
    /// Requested information on the account or business error when information has not been found.
    /// </summary>
    public required IAccountOrBusinessError5Choice AccountOrError { get; init; } 
    #nullable disable
}
