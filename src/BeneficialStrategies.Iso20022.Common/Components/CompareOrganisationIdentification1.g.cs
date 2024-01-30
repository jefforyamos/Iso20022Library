﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareOrganisationIdentification1.  ISO2002 ID# _NQB58bQ5EemI67HK7aviyg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for an organisation identification.
/// </summary>
public partial record CompareOrganisationIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    public IOrganisationIdentification9Choice? Value1 { get; init; } 
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    public IOrganisationIdentification9Choice? Value2 { get; init; } 
    
    #nullable disable
}
