﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstitutionIdentification17.  ISO2002 ID# _vEm5sWAYEeiH9-hkDDXUHA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a financial institution.
/// </summary>
public partial record FinancialInstitutionIdentification17
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the financial institution.
    /// </summary>
    public required IFinancialInstitutionIdentification10Choice Party { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    
    #nullable disable
}
