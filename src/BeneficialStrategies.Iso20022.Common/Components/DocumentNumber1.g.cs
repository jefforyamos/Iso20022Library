﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentNumber1.  ISO2002 ID# _Tg5R5dp-Ed-ak6NoX_4Aeg_-1445653769.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a document.
/// </summary>
[DataContract]
[XmlType]
public partial record DocumentNumber1
{
    #nullable enable
    
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    [DataMember]
    public required DocumentNumber1Choice_ Number { get; init; } 
    
    #nullable disable
}
