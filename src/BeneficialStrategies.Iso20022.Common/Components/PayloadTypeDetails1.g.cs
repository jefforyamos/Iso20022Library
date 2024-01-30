﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PayloadTypeDetails1.  ISO2002 ID# _jMCaQe5NEeCisYr99QEiWA_994991099.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the type of payload.
/// </summary>
public partial record PayloadTypeDetails1
{
    #nullable enable
    
    /// <summary>
    /// Declaration of the payload content. Describes the type of business document being exchanged.
    /// When sending a copy or a duplicate of a previous document set, the document set identification must remain identical.
    /// </summary>
    public required IsoMax256Text Type { get; init; } 
    
    #nullable disable
}
