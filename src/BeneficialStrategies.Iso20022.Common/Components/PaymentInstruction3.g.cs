﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentInstruction3.  ISO2002 ID# _8C5sEKMgEeCJ6YNENx4h-w_-792076459.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction to pay an amount of money to an ultimate beneficiary, on behalf of an originator. This instruction may have to be forwarded several times to complete the settlement chain.|.
/// </summary>
[DataContract]
[XmlType]
public partial record PaymentInstruction3
{
    #nullable enable
    
    /// <summary>
    /// Date at which the initiating party requests that the payment instruction be processed. |.
    /// </summary>
    [DataMember]
    public IsoISODateTime? RequestedExecutionDateTime { get; init; } 
    /// <summary>
    /// Type, or nature, of the payment, for example an express payment.
    /// </summary>
    [DataMember]
    public PaymentType3Choice_? PaymentType { get; init; } 
    
    #nullable disable
}
