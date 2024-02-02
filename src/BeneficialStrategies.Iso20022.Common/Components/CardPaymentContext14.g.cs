﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentContext14.  ISO2002 ID# _jglFMY0VEeWRYffwL7E13A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the transaction is performed (payment and sale).
/// </summary>
[DataContract]
[XmlType]
public partial record CardPaymentContext14
{
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [DataMember]
    public required PaymentContext14 PaymentContext { get; init; } 
    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [DataMember]
    public SaleContext2? SaleContext { get; init; } 
    
    #nullable disable
}
