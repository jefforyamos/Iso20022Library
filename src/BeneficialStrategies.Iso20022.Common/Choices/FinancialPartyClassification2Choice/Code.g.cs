﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _IJIRcSI4Ee2zWP9pqvmqdw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialPartyClassification2Choice;

/// <summary>
/// Classification of the business activities of the counterparty via a pre-determined code list.
/// </summary>
public partial record Code : FinancialPartyClassification2Choice_
{
    public required FinancialPartySectorType3Code Value { get; init; }
}
