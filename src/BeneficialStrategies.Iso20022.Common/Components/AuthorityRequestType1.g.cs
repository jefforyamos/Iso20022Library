﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AuthorityRequestType1.  ISO2002 ID# _1uJfwPG1EeGldvY3i8Fbvw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the authority request type.
/// </summary>
public partial record AuthorityRequestType1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the requested message name identifier.
    /// </summary>
    public required IsoMax35Text MessageNameIdentification { get; init; } 
    /// <summary>
    /// Specifies the message name.
    /// </summary>
    public IsoMax140Text? MessageName { get; init; } 
    
    #nullable disable
}
