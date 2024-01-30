﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AccountDetails.  ISO2002 ID# _VKshRtp-Ed-ak6NoX_4Aeg_1485868880.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument8Choice;

/// <summary>
/// Part of the investment account to or from which cash entries are made.
/// </summary>
public partial record AccountDetails : IPaymentInstrument8Choice
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public AccountIdentification1? AccountIdentification { get; init; } 
    /// <summary>
    /// Account type.
    /// </summary>
    public CashAccountType1? Type { get; init; } 
    #nullable disable
}
