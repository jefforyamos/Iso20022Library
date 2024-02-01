﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NameAndAddress.  ISO2002 ID# _TFnrINp-Ed-ak6NoX_4Aeg_426657982.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification5Choice;

/// <summary>
/// Identifies the name and address of a financial institution.
/// </summary>
public partial record NameAndAddress : FinancialInstitutionIdentification5Choice_
{
    #nullable enable
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax70Text Name { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    public required PostalAddress1 PostalAddress { get; init; } 
    #nullable disable
}
