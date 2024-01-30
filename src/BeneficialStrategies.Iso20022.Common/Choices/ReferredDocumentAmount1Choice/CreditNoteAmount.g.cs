﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CreditNoteAmount.  ISO2002 ID# _QGJCRtp-Ed-ak6NoX_4Aeg_-888106456.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReferredDocumentAmount1Choice;

/// <summary>
/// Amount specified for the referred document is the amount of a credit note.
/// </summary>
public partial record CreditNoteAmount : IReferredDocumentAmount1Choice
{
    public required IsoCurrencyAndAmount Value { get; init; }
}
