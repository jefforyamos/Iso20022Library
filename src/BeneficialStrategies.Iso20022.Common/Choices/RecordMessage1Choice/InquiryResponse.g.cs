﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for InquiryResponse.  ISO2002 ID# _SwebcFZYEeen1vB4iz5SyA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Inquiry response message record.
/// </summary>
public partial record InquiryResponse : IRecordMessage1Choice
{
    public required IsoMax2MBBinary Value { get; init; }
}
