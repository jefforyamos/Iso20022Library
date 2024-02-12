﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorAuthorisationResponse3.  ISO2002 ID# _Nai6QTGiEeO118ZQJgaQSQ.
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
/// Authorisation response from the acquirer.
/// </summary>
[IsoId("_Nai6QTGiEeO118ZQJgaQSQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Acceptor Authorisation Response")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorAuthorisationResponse3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorAuthorisationResponse3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorAuthorisationResponse3( CardPaymentEnvironment21 reqEnvironment,CardPaymentTransaction23 reqTransaction,CardPaymentTransaction24 reqTransactionResponse )
    {
        Environment = reqEnvironment;
        Transaction = reqTransaction;
        TransactionResponse = reqTransactionResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_NrNMcTGiEeO118ZQJgaQSQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Environment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment21 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CardPaymentEnvironment21 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment21 Environment { get; init; } 
    #else
    public CardPaymentEnvironment21 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Authorisation of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_NrNMczGiEeO118ZQJgaQSQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentTransaction23 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CardPaymentTransaction23 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction23 Transaction { get; init; } 
    #else
    public CardPaymentTransaction23 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Authorisation response from the acquirer.
    /// Authorisation of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_NrNMdTGiEeO118ZQJgaQSQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Response")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentTransaction24 TransactionResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CardPaymentTransaction24 TransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction24 TransactionResponse { get; init; } 
    #else
    public CardPaymentTransaction24 TransactionResponse { get; set; } 
    #endif
    
    
    #nullable disable
    
}
