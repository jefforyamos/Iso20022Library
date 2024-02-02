﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentCommon3.  ISO2002 ID# _mKHMIZlgEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Common details for all payment instruction.
/// </summary>
[DataContract]
[XmlType]
public partial record PaymentCommon3
{
    #nullable enable
    
    /// <summary>
    /// Origin of the payment (be it a member or a system or both).
    /// </summary>
    [DataMember]
    public System1? PaymentFrom { get; init; } 
    /// <summary>
    /// Destination of the payment (be it a member or a system or both).
    /// </summary>
    [DataMember]
    public System1? PaymentTo { get; init; } 
    /// <summary>
    /// Status of a transfer.|.
    /// </summary>
    [DataMember]
    public ValueList<PaymentStatus3> CommonStatus { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Date and time at which the cash is at the disposal of the credit account owner, or ceases to be at the disposal of the debit account owner.
    /// </summary>
    [DataMember]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date and time at which an entry is posted to an account on the account servicer's books.
    /// </summary>
    [DataMember]
    public DateAndDateTime2Choice_? EntryDate { get; init; } 
    /// <summary>
    /// Indicates whether the payment instruction is a debit or a credit.|.
    /// </summary>
    [DataMember]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Indicates the message or event from which an instruction has been initiated.
    /// </summary>
    [DataMember]
    public PaymentOrigin1Choice_? PaymentMethod { get; init; } 
    
    #nullable disable
}
