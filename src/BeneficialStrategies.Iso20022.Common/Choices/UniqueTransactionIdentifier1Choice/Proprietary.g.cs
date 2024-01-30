﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _yq1bcQxeEeuoAcnnpX2x_w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UniqueTransactionIdentifier1Choice;

/// <summary>
/// Frequency expressed in a proprietary notation.
/// </summary>
public partial record Proprietary : IUniqueTransactionIdentifier1Choice
{
    #nullable enable
    /// <summary>
    /// Identification of the lot, according to a data source scheme. Used to indicate which processing to apply to the corresponding market value amount.
    /// </summary>
    public required IsoMax52Text Identification { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    #nullable disable
}
