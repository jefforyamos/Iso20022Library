﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CopyInformation5.  ISO2002 ID# _y6HYAZELEem-9Y6mq5ZH3Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information provided when the message is a copy of a previous message.
/// </summary>
[DataContract]
[XmlType]
public partial record CopyInformation5
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the message is a copy.
    /// </summary>
    [DataMember]
    public required IsoYesNoIndicator CopyIndicator { get; init; } 
    /// <summary>
    /// Original receiver of the message, if this message is a copy.
    /// </summary>
    [DataMember]
    public IsoAnyBICDec2014Identifier? OriginalReceiver { get; init; } 
    
    #nullable disable
}
