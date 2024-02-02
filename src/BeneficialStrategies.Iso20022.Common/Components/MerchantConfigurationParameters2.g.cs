﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MerchantConfigurationParameters2.  ISO2002 ID# _GmtMcY39EeWRwov1g9WL_A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to the merchant.
/// </summary>
[DataContract]
[XmlType]
public partial record MerchantConfigurationParameters2
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [DataMember]
    public required TerminalManagementAction3Code ActionType { get; init; } 
    /// <summary>
    /// Identification of the merchant for the MTM, if the POI manages several merchants.
    /// </summary>
    [DataMember]
    public IsoMax35Text? MerchantIdentification { get; init; } 
    /// <summary>
    /// Version of the merchant parameters.
    /// </summary>
    [DataMember]
    public required IsoMax256Text Version { get; init; } 
    /// <summary>
    /// Local proxy configuration.
    /// </summary>
    [DataMember]
    public NetworkParameters6? Proxy { get; init; } 
    /// <summary>
    /// Other merchant parameters.
    /// </summary>
    [DataMember]
    public IsoMax10000Binary? OtherParameters { get; init; } 
    
    #nullable disable
}
