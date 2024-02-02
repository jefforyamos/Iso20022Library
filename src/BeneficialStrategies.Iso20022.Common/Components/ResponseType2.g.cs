﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ResponseType2.  ISO2002 ID# _MGZDwXuGEeSZrqGdHyoIrw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response of a requested service.
/// </summary>
[DataContract]
[XmlType]
public partial record ResponseType2
{
    #nullable enable
    
    /// <summary>
    /// Result of the request message or advice message.
    /// </summary>
    [DataMember]
    public required Response3Code Result { get; init; } 
    /// <summary>
    /// Detail of the result.
    /// </summary>
    [DataMember]
    public ResultDetail1Code? ResultDetails { get; init; } 
    /// <summary>
    /// Additional information to be logged for further examination.
    /// </summary>
    [DataMember]
    public IsoMax140Text? AdditionalResultInformation { get; init; } 
    
    #nullable disable
}
