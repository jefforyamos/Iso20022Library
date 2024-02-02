﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ServiceResponse7.  ISO2002 ID# _TTosAXIOEe2OqYulmHWukQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the response of the corresponding service request.
/// </summary>
[DataContract]
[XmlType]
public partial record ServiceResponse7
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [DataMember]
    public required CardPaymentEnvironment79 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [DataMember]
    public required CardPaymentContext30 Context { get; init; } 
    /// <summary>
    /// Define the type of service response.
    /// </summary>
    [DataMember]
    public required RetailerService3Code ServiceContent { get; init; } 
    /// <summary>
    /// Data to respond to a Payment request.
    /// </summary>
    [DataMember]
    public PaymentResponse5? PaymentResponse { get; init; } 
    /// <summary>
    /// Response Data to a Reversal request.
    /// </summary>
    [DataMember]
    public ReversalResponse7? ReversalResponse { get; init; } 
    /// <summary>
    /// Response data to a balance inquiry service request.
    /// </summary>
    [DataMember]
    public BalanceInquiryResponse5? BalanceInquiryResponse { get; init; } 
    /// <summary>
    /// Response data to a loyalty service request.
    /// </summary>
    [DataMember]
    public LoyaltyResponse3? LoyaltyResponse { get; init; } 
    /// <summary>
    /// Response data to a Stored Value request.
    /// </summary>
    [DataMember]
    public StoredValueResponse6? StoredValueResponse { get; init; } 
    /// <summary>
    /// Content of the Batch Response message.
    /// </summary>
    [DataMember]
    public BatchResponse5? BatchResponse { get; init; } 
    /// <summary>
    /// Content of the Card Acquisition Response message.
    /// </summary>
    [DataMember]
    public CardAcquisitionResponse3? CardAcquisitionResponse { get; init; } 
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
