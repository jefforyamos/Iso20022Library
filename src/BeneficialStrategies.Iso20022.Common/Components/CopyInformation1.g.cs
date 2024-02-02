﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CopyInformation1.  ISO2002 ID# _RE37Ydp-Ed-ak6NoX_4Aeg_-877911728.
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
public partial record CopyInformation1
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
    public required BICIdentification1 OriginalReceiver { get; init; } 
    
    #nullable disable
}
