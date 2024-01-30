﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DeMinimusApplicable.  ISO2002 ID# _CgNiAggqEeSUG-8hqXsVMQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DeMinimus1Choice;

/// <summary>
/// Conditions applicable when the investor is covered by the "de minimis" exemption.
/// </summary>
public partial record DeMinimusApplicable : IDeMinimus1Choice
{
    #nullable enable
    /// <summary>
    /// Indicates whether the investor permits its beneficial owners that are restricted persons, if any, to participate in profits and losses allocated to the investor that are attribute to new issue securities.
    /// </summary>
    public required IsoYesNoIndicator NewIssuePermission { get; init; } 
    /// <summary>
    /// Percentage of the new issue profits and losses that it receives to beneficial owners that are restricted persons.
    /// </summary>
    public IsoPercentageRate? Percentage { get; init; } 
    #nullable disable
}
