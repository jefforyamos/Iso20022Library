﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _XUZ6A5QEEeiILOjNP8ro1w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OrganisationIdentification7Choice;

/// <summary>
/// Unique identification of a counterparty, using a client code or a business identification code.
/// </summary>
public partial record Other : IOrganisationIdentification7Choice
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identification of the organisation.
    /// </summary>
    public required IOrganisationIdentification8Choice Identification { get; init; } 
    /// <summary>
    /// Indicates the name of the reporting counterparty.
    /// </summary>
    public IsoMax105Text? Name { get; init; } 
    /// <summary>
    /// Indicates the domicile of counterparty.
    /// </summary>
    public IsoMax500Text? Domicile { get; init; } 
    #nullable disable
}
