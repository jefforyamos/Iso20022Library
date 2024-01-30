﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ServiceResponse3.  ISO2002 ID# _0fJMAQ1VEeqjM-rxn3HuXQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component contains the response of the corresponding service request.
/// </summary>
public partial record ServiceResponse3
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment75 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    public required CardPaymentContext28 Context { get; init; } 
    /// <summary>
    /// Define the type of service response.
    /// </summary>
    public required RetailerService3Code ServiceContent { get; init; } 
    /// <summary>
    /// Data to respond to a Payment request.
    /// </summary>
    public PaymentResponse2? PaymentResponse { get; init; } 
    /// <summary>
    /// Response Data to a Reversal request.
    /// </summary>
    public ReversalResponse3? ReversalResponse { get; init; } 
    /// <summary>
    /// Response data to a balance inquiry service request.
    /// </summary>
    public BalanceInquiryResponse2? BalanceInquiryResponse { get; init; } 
    /// <summary>
    /// Response data to a loyalty service request.
    /// </summary>
    public LoyaltyResponse2? LoyaltyResponse { get; init; } 
    /// <summary>
    /// Response data to a Stored Value request.
    /// </summary>
    public StoredValueResponse3? StoredValueResponse { get; init; } 
    /// <summary>
    /// Content of the Batch Response message.
    /// </summary>
    public BatchResponse2? BatchResponse { get; init; } 
    /// <summary>
    /// Content of the Card Acquisition Response message.
    /// </summary>
    public CardAcquisitionResponse2? CardAcquisitionResponse { get; init; } 
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    public required ResponseType9 Response { get; init; } 
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
