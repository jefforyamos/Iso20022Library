﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OrganisationIdentification.  ISO2002 ID# _2uFgEeWkEeevU7McUP3D1w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party36Choice;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
public partial record OrganisationIdentification : Party36Choice_
{
    #nullable enable
    /// <summary>
    /// Code allocated to an institution by the ISO 9362 Registration Authority as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
    /// </summary>
    public IsoAnyBICIdentifier? AnyBIC { get; init; } 
    /// <summary>
    /// Unique identification of an organisation, as assigned by an institution, using an identification scheme.
    /// </summary>
    public GenericOrganisationIdentification1? Other { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
