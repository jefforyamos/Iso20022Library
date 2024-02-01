﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherProductCharacteristics.  ISO2002 ID# _RbrR1dp-Ed-ak6NoX_4Aeg_816698034.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProductCharacteristics1Choice;

/// <summary>
/// Specifies the type of product characteristic not present in the code list.
/// </summary>
public partial record OtherProductCharacteristics : ProductCharacteristics1Choice_
{
    #nullable enable
    /// <summary>
    /// Identifier issued to a person for which no specific identifier has been defined.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Specifies the nature of the identifier.|Usage: IdentificationType is used to specify what kind of identifier is used. It should be used in case the identifier is different from the identifiers listed in the pre-defined identifier list.
    /// </summary>
    public required IsoMax35Text IdentificationType { get; init; } 
    #nullable disable
}
