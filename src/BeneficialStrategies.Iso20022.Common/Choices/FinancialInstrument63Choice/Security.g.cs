﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Security.  ISO2002 ID# _nj5gMaPvEemf4IaGqCtquA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument63Choice;

/// <summary>
/// Identification of the security.
/// </summary>
public partial record Security : FinancialInstrument63Choice_
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    public required SecurityIdentification25Choice_ Identification { get; init; } 
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    public IsoMax350Text? Name { get; init; } 
    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    public IsoMax35Text? ShortName { get; init; } 
    /// <summary>
    /// Type of security.
    /// </summary>
    public ClassificationType32Choice_? ClassificationType { get; init; } 
    #nullable disable
}
