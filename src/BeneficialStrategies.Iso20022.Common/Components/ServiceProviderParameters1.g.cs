﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ServiceProviderParameters1.  ISO2002 ID# _iGGCMDAKEeugIJ3Gvoevmg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Service provider parameters of the point of interaction (POI).
/// </summary>
[DataContract]
[XmlType]
public partial record ServiceProviderParameters1
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [DataMember]
    public required TerminalManagementAction3Code ActionType { get; init; } 
    /// <summary>
    /// Identification of the service provider.
    /// </summary>
    [DataMember]
    public ValueList<GenericIdentification176> ServiceProviderIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Version of the service provider parameters.
    /// </summary>
    [DataMember]
    public required IsoMax256Text Version { get; init; } 
    /// <summary>
    /// Identification of payment application relevant for this service provider.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax35Text> ApplicationIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Service provider host configuration.
    /// </summary>
    [DataMember]
    public ValueList<AcquirerHostConfiguration8> Host { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of non financial action supported by the Service Provider.
    /// </summary>
    [DataMember]
    public ValueList<NonFinancialRequestType1Code> NonFinancialActionSupported { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
