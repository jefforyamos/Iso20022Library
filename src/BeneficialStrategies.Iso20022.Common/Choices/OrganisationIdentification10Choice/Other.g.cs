﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _IEZpg-9IEemVGdgB8P8uQQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OrganisationIdentification10Choice;

/// <summary>
/// Unique identification of a counterparty, using a client code or a business identification code.
/// </summary>
public partial record Other : IOrganisationIdentification10Choice
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identification of the organisation.
    /// </summary>
    public required GenericIdentification175 Identification { get; init; } 
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
