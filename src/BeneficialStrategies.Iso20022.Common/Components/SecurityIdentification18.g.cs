﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityIdentification18.  ISO2002 ID# _el9wcID3EeSQoe-8fZQlpA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security by its symbol.
/// </summary>
public partial record SecurityIdentification18
{
    #nullable enable
    
    /// <summary>
    /// Security identification source of the trade.
    /// </summary>
    public required IdentificationType2Code SecurityIdentificationSource { get; init; } 
    /// <summary>
    /// Security identification of the trade.
    /// </summary>
    public required IsoMax35Text SecurityIdentification { get; init; } 
    
    #nullable disable
}
