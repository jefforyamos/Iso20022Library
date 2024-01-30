﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProprietaryAgent4.  ISO2002 ID# _HH3jG24-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a proprietary party.
/// </summary>
public partial record ProprietaryAgent4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of proprietary agent.
    /// </summary>
    public required IsoMax35Text Type { get; init; } 
    /// <summary>
    /// Organisation established primarily to provide financial services.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 Agent { get; init; } 
    
    #nullable disable
}
