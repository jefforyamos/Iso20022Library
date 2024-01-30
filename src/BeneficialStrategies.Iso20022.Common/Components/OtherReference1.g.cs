﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherReference1.  ISO2002 ID# _6VGSwMeTEeysUoBKYz1Ytw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other option to express a reference.
/// </summary>
public partial record OtherReference1
{
    #nullable enable
    
    /// <summary>
    /// Type of reference
    /// </summary>
    public required IReferenceType1Choice Type { get; init; } 
    /// <summary>
    /// Value of the reference
    /// </summary>
    public required IsoMax256Text Value { get; init; } 
    
    #nullable disable
}
