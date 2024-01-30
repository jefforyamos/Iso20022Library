﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InputResult3.  ISO2002 ID# _Wey54S9EEeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the result the input.
/// </summary>
public partial record InputResult3
{
    #nullable enable
    
    /// <summary>
    /// Type of Input device.
    /// </summary>
    public required SaleCapabilities2Code DeviceType { get; init; } 
    /// <summary>
    /// Qualifies the type of given information.
    /// </summary>
    public required InformationQualify1Code InformationQualifier { get; init; } 
    /// <summary>
    /// Data resulting of input after POI or Sale processing.
    /// </summary>
    public required InputResultData3 InputResultData { get; init; } 
    
    #nullable disable
}
