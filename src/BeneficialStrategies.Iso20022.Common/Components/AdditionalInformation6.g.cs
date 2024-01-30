﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalInformation6.  ISO2002 ID# _SuAjPwEcEeCQm6a_G2yO_w_1862347907.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information about a request.
/// </summary>
public partial record AdditionalInformation6
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of additional information.
    /// </summary>
    public required ExternalInformationType1Code InformationType { get; init; } 
    /// <summary>
    /// Contents of the additional information.
    /// </summary>
    public required IsoMax350Text InformationValue { get; init; } 
    
    #nullable disable
}
