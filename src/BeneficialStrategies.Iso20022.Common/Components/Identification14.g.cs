﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Identification14.  ISO2002 ID# _jXzlYu5NEeCisYr99QEiWA_-2122254183.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identifier of a document, message or transaction.
/// </summary>
public partial record Identification14
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a document, message or transaction.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    
    #nullable disable
}
