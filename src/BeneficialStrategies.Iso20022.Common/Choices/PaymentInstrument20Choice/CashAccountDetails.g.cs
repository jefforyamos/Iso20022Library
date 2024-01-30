﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CashAccountDetails.  ISO2002 ID# _weKLIzbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument20Choice;

/// <summary>
/// Part of the investment account to or from which cash entries are made.
/// </summary>
public partial record CashAccountDetails : IPaymentInstrument20Choice
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Account type.
    /// </summary>
    public IInvestmentAccountType1Choice? Type { get; init; } 
    #nullable disable
}
