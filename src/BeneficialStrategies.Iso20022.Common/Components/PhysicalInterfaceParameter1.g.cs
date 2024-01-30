﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PhysicalInterfaceParameter1.  ISO2002 ID# _jVcYQNqfEeearpaEPXv9UA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters for physical interface.
/// </summary>
public partial record PhysicalInterfaceParameter1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the interface.
    /// </summary>
    public required IsoMax35Text InterfaceName { get; init; } 
    /// <summary>
    /// Identification of the physical link layer.
    /// </summary>
    public POICommunicationType2Code? InterfaceType { get; init; } 
    /// <summary>
    /// Optional user name to provide to use this interface.
    /// </summary>
    public IsoMax35Text? UserName { get; init; } 
    /// <summary>
    /// Optional access code to provide to use this interface.
    /// </summary>
    public IsoMax35Binary? AccessCode { get; init; } 
    /// <summary>
    /// Identification of the optional security profile to use with this interface.
    /// </summary>
    public IsoMax35Text? SecurityProfile { get; init; } 
    /// <summary>
    /// Any other parameters relevant for this interface.
    /// </summary>
    public IsoMax2KBinary? AdditionalParameters { get; init; } 
    
    #nullable disable
}
