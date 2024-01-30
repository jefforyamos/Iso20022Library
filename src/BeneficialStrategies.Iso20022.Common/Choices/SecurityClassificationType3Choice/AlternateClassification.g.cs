﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AlternateClassification.  ISO2002 ID# _SimIQ_35EeimOuZbLgw0bg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityClassificationType3Choice;

/// <summary>
/// Other type of classification of the financial instrument.
/// </summary>
public partial record AlternateClassification : ISecurityClassificationType3Choice
{
    #nullable enable
    /// <summary>
    /// Proprietary information issued by the data source scheme issuer.
    /// </summary>
    public required IsoRestrictedFINMax30Text Identification { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public IsoRestrictedFINMax8Text? Issuer { get; init; } 
    #nullable disable
}
