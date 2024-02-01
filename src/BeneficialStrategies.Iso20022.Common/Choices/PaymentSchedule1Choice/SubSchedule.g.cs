﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SubSchedule.  ISO2002 ID# _Bhnbc9OAEeSQ_-lmj1tzfw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentSchedule1Choice;

/// <summary>
/// Specifies a payment sub-schedule, that is the amount of money that must be paid no sooner than the expected date and no later than the latest shipment date.
/// </summary>
public partial record SubSchedule : PaymentSchedule1Choice_
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identification of the payment schedule.
    /// </summary>
    public IsoMax35Text? PaymentScheduleIdentification { get; init; } 
    /// <summary>
    /// Amount that must be paid no sooner than the expected payment date and no later than the due date.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Expected date whereby the amount must be paid.
    /// </summary>
    public IsoISODate? ExpectedDate { get; init; } 
    /// <summary>
    /// Latest date whereby the amount of money must be paid.
    /// </summary>
    public required IsoISODate DueDate { get; init; } 
    #nullable disable
}
