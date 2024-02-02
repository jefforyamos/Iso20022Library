﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionEventReference3.  ISO2002 ID# _n8yzsznYEeWLJsP1cO-amg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a linked corporate action event.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateActionEventReference3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the linked corporate action event.
    /// </summary>
    [DataMember]
    public required CorporateActionEventReference3Choice_ EventIdentification { get; init; } 
    /// <summary>
    /// Specifies when this corporate action event is to be processed relative to a linked corporate action event.
    /// </summary>
    [DataMember]
    public ProcessingPosition7Choice_? LinkageType { get; init; } 
    
    #nullable disable
}
