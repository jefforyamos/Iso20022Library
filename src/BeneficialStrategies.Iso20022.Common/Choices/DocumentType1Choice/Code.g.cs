﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _iYH70HiJEeidzqjNEfehPg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DocumentType1Choice;

/// <summary>
/// Document type, in a coded form.
/// </summary>
public partial record Code : IDocumentType1Choice
{
    public required ExternalDocumentType1Code Value { get; init; }
}
