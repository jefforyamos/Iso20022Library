﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NonFinancialResponseComponent2.  ISO2002 ID# _qNgYMU1BEeybj420QgWBkA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to a non financial request.
/// </summary>
[DataContract]
[XmlType]
public partial record NonFinancialResponseComponent2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [DataMember]
    public required CardPaymentEnvironment78 Environment { get; init; } 
    /// <summary>
    /// Response of the non financial request.
    /// </summary>
    [DataMember]
    public ValueList<NonFinancialResponseContentComponent2> ResponseContent { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [DataMember]
    public required ResponseType11 Response { get; init; } 
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [DataMember]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
