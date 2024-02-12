﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorReconciliationResponse1.  ISO2002 ID# _Svfw-wEcEeCQm6a_G2yO_w_828551474.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation response from the acquirer.
/// </summary>
[IsoId("_Svfw-wEcEeCQm6a_G2yO_w_828551474")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Acceptor Reconciliation Response")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorReconciliationResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorReconciliationResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorReconciliationResponse1( CardPaymentEnvironment7 reqEnvironment,ResponseType1 reqTransactionResponse,TransactionReconciliation1 reqTransaction )
    {
        Environment = reqEnvironment;
        TransactionResponse = reqTransactionResponse;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Svfw_AEcEeCQm6a_G2yO_w_766279755")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Environment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment7 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CardPaymentEnvironment7 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment7 Environment { get; init; } 
    #else
    public CardPaymentEnvironment7 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Response from the acquirer to the reconciliation transaction.
    /// </summary>
    [IsoId("_Svfw_QEcEeCQm6a_G2yO_w_-1242316409")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Response")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType1 TransactionResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ResponseType1 TransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType1 TransactionResponse { get; init; } 
    #else
    public ResponseType1 TransactionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    [IsoId("_Svfw_gEcEeCQm6a_G2yO_w_-712189637")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionReconciliation1 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TransactionReconciliation1 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionReconciliation1 Transaction { get; init; } 
    #else
    public TransactionReconciliation1 Transaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
