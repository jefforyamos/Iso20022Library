﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericIdentification81.  ISO2002 ID# _TukJISFVEeWgV9SQSyaAog.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the identification of a party.
/// </summary>
public partial record GenericIdentification81
{
    #nullable enable
    
    /// <summary>
    /// Identification of a party, such as a tax or social security identifier.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Type of identification.
    /// </summary>
    public required OtherIdentification3Choice_ IdentificationType { get; init; } 
    
    #nullable disable
}
