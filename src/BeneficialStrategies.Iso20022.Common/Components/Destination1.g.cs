﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Destination1.  ISO2002 ID# _ZQh2YE95EeePXdaAO32Uew.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Destination of the message.
/// </summary>
public partial record Destination1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the destination of the transaction.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Identification of the entity assigning the destination identification.
    /// </summary>
    public IsoMax35Text? Assigner { get; init; } 
    /// <summary>
    /// Country of the destination.
    /// </summary>
    public ISO3NumericCountryCode? Country { get; init; } 
    /// <summary>
    /// Short name of the destination.
    /// </summary>
    public IsoMax35Text? ShortName { get; init; } 
    
    #nullable disable
}
