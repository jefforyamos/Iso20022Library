﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Credentials1.  ISO2002 ID# _AwRLkMV4Eee3gsS0IxDWIA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains credential information.
/// </summary>
public partial record Credentials1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the type of credential.
    /// </summary>
    public required Identification2Code IdentificationCode { get; init; } 
    /// <summary>
    /// Used when OtherNational or OtherPrivate value is selected in identification code list. 
    /// </summary>
    public IsoMax35Text? OtherIdentificationCode { get; init; } 
    /// <summary>
    /// Value of identification.
    /// </summary>
    public required IsoMax70Text IdentificationValue { get; init; } 
    
    #nullable disable
}
