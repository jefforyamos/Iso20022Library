﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalInformation15.  ISO2002 ID# _tmecgZCkEeiQvr1XXv37hw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information.
/// </summary>
public partial record AdditionalInformation15
{
    #nullable enable
    
    /// <summary>
    /// Type of additional information.
    /// </summary>
    public required GenericIdentification36 InformationType { get; init; } 
    /// <summary>
    /// Value of the additional information.
    /// </summary>
    public required IsoMax350Text InformationValue { get; init; } 
    
    #nullable disable
}
