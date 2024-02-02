﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RequestDetails5.  ISO2002 ID# _SumZGwEcEeCQm6a_G2yO_w_1103821784.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report of the requested data.
/// </summary>
[DataContract]
[XmlType]
public partial record RequestDetails5
{
    #nullable enable
    
    /// <summary>
    /// Type of data requested, for example, a sub-member BIC.
    /// </summary>
    [DataMember]
    public required IsoMax35Text Type { get; init; } 
    /// <summary>
    /// Reference to the request for which the report is sent.
    /// </summary>
    [DataMember]
    public required IsoMax35Text RequestReference { get; init; } 
    /// <summary>
    /// Report key and returned data.
    /// </summary>
    [DataMember]
    public ValueList<RequestDetails4> ReportKey { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
