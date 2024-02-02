﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OutputResult1.  ISO2002 ID# _3CNXIN7EEeiwsev40qZGEQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the result the output (display, print, input).
/// </summary>
[DataContract]
[XmlType]
public partial record OutputResult1
{
    #nullable enable
    
    /// <summary>
    /// Logical device located on a Sale Terminal or a POI Terminal, in term of class of information to output.
    /// </summary>
    [DataMember]
    public required UserInterface4Code DeviceType { get; init; } 
    /// <summary>
    /// Qualification of the information to sent to an output logical device.
    /// </summary>
    [DataMember]
    public required InformationQualify1Code InformationQualifier { get; init; } 
    /// <summary>
    /// Gives response for each peripheral.
    /// </summary>
    [DataMember]
    public required ResponseType9 Response { get; init; } 
    
    #nullable disable
}
