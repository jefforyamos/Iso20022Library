﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RqIkktp-Ed-ak6NoX_4Aeg_-1706426890.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReportingSource1Choice;

/// <summary>
/// Reporting source, as published in an external reporting source code list.
/// </summary>
public partial record Code : ReportingSource1Choice_
{
    public required ExternalReportingSource1Code Value { get; init; }
}
