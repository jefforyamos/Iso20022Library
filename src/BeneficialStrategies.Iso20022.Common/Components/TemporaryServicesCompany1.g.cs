﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TemporaryServicesCompany1.  ISO2002 ID# _unOVWPfSEei89sMSHxl1ew.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains company related information for Temporary Services.
/// </summary>
[DataContract]
[XmlType]
public partial record TemporaryServicesCompany1
{
    #nullable enable
    
    /// <summary>
    /// Contains the name of the individual at the contracting company that has requested temporary services.
    /// </summary>
    [DataMember]
    public IsoMax70Text? Name { get; init; } 
    /// <summary>
    /// Contains the name of the department at the contracting company in which the temporary staff will be working. 
    /// </summary>
    [DataMember]
    public IsoMax70Text? Department { get; init; } 
    /// <summary>
    /// Identification of the temporary services company.
    /// </summary>
    [DataMember]
    public PartyIdentification197? Identification { get; init; } 
    /// <summary>
    /// Contains the name of the individual at the contracting company that is supervising the temporary staff. 
    /// </summary>
    [DataMember]
    public IsoMax70Text? Supervisor { get; init; } 
    
    #nullable disable
}
