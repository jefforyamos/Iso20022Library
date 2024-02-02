﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MessageStatusResponse2.  ISO2002 ID# _CeKZYYYDEemxIqbaFEE8-w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the environment, the context
/// and the services to be used with this message.
/// </summary>
[DataContract]
[XmlType]
public partial record MessageStatusResponse2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [DataMember]
    public required CardPaymentEnvironment73 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [DataMember]
    public required CardPaymentContext27 Context { get; init; } 
    /// <summary>
    /// Content of the Message status Response.
    /// </summary>
    [DataMember]
    public required MessageStatusResponseData2 MessageStatusResponseData { get; init; } 
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [DataMember]
    public required ResponseType9 Response { get; init; } 
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [DataMember]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
