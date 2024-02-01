﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherIdentification.  ISO2002 ID# _jUg4o-GXEeWCAvUNsZ5u6g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification24Choice;

/// <summary>
/// Proprietary identification of a security assigned by an institution or organisation.
/// </summary>
public partial record OtherIdentification : SecurityIdentification24Choice_
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    public required IsoMax70Text Identification { get; init; } 
    /// <summary>
    /// Source of the security identification.
    /// </summary>
    public required IdentificationSource1Choice_ IdentificationSource { get; init; } 
    #nullable disable
}
