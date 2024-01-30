﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reconciled.  ISO2002 ID# _QxzOadp-Ed-ak6NoX_4Aeg_-1746354035.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.EventProcessingStatus1Choice;

/// <summary>
/// Corporate action event processing specifying that the funds paid have been reconciled with the funds received from the agent (meaning that there is no more risk of payment to be reversed).
/// </summary>
public partial record Reconciled : IEventProcessingStatus1Choice
{
    #nullable enable
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #nullable disable
}
