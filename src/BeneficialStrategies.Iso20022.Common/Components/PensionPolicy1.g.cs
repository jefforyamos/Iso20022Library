﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PensionPolicy1.  ISO2002 ID# _BNqcEFkOEeiaQoK2-_0KTA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a pension policy.
/// </summary>
public partial record PensionPolicy1
{
    #nullable enable
    
    /// <summary>
    /// Reference number of the pension policy, plan or scheme.
    /// </summary>
    public required IsoMax35Text Identifier { get; init; } 
    /// <summary>
    /// Sub-identification of the pension policy, plan or scheme, such as a member reference.
    /// </summary>
    public IsoMax35Text? SubIdentifier { get; init; } 
    /// <summary>
    /// Additional information about the identification of the pension policy, plan or scheme.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    #nullable disable
}
