﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcquirerNetworkManagementResponse1.  ISO2002 ID# _aNF6EHvFEeSKFIcWw3l4Yw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response to the network management.
/// </summary>
[DataContract]
[XmlType]
public partial record AcquirerNetworkManagementResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [DataMember]
    public required CardTransactionEnvironment6 Environment { get; init; } 
    /// <summary>
    /// Network management transaction.
    /// </summary>
    [DataMember]
    public required CardTransaction12 Transaction { get; init; } 
    
    #nullable disable
}
