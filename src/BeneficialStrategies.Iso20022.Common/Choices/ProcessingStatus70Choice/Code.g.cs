﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _mXWx0eGHEeWCAvUNsZ5u6g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus70Choice;

/// <summary>
/// Specifies the processing status of the instruction in a coded format.
/// </summary>
public partial record Code : ProcessingStatus70Choice_
{
    public required TransactionProcessingStatus4Code Value { get; init; }
}
