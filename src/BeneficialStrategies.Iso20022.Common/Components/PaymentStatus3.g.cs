﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentStatus3.  ISO2002 ID# _NhZZ05lPEee-Zps0fZQaFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment status details.
/// </summary>
[DataContract]
[XmlType]
public partial record PaymentStatus3
{
    #nullable enable
    
    /// <summary>
    /// Status of a transfer, in coded form, as assigned by the transaction administrator.
    /// </summary>
    [DataMember]
    public PaymentStatusCode6Choice_? Code { get; init; } 
    /// <summary>
    /// Date and time at which the status was assigned to the transfer.
    /// </summary>
    [DataMember]
    public DateAndDateTime2Choice_? DateTime { get; init; } 
    /// <summary>
    /// Reason provided for the status of a transfer.
    /// </summary>
    [DataMember]
    public ValueList<PaymentStatusReasonCode7Choice_> Reason { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
