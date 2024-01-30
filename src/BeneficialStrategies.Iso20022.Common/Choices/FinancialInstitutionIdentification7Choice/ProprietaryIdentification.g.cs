﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryIdentification.  ISO2002 ID# _Tet_ZyGOEeW7gKYhAMEFCw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification7Choice;

/// <summary>
/// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
/// </summary>
public partial record ProprietaryIdentification : IFinancialInstitutionIdentification7Choice
{
    #nullable enable
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    #nullable disable
}
