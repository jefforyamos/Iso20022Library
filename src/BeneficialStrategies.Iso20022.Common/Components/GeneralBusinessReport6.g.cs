﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GeneralBusinessReport6.  ISO2002 ID# _QdJoBXhdEeidzqjNEfehPg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on the business information or on a business error.
/// </summary>
public partial record GeneralBusinessReport6
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a general business information system, as assigned by the system transaction administrator.
    /// </summary>
    public required IsoMax35Text BusinessInformationReference { get; init; } 
    /// <summary>
    /// Requested business information.
    /// </summary>
    public required GeneralBusinessOrError8Choice_ GeneralBusinessOrError { get; init; } 
    
    #nullable disable
}
