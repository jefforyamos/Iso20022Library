﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoCriteria.  ISO2002 ID# _KQCmFWomEeipaMTLlhaKMQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FundParameters4Choice;

/// <summary>
/// Specifies that there is no criteria for the report. The request is a request for all reports, rather than reports attributed to a specific fund manager, date or financial instrument.
/// </summary>
public partial record NoCriteria : IFundParameters4Choice
{
    public required NoCriteria1Code Value { get; init; }
}
