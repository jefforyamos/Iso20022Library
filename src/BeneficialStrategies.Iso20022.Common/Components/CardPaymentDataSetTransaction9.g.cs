﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentDataSetTransaction9.  ISO2002 ID# _6SZA8TKOEeOqyZqt0rCZLg.
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
/// Card payment transaction including an authorisation response.
/// </summary>
[IsoId("_6SZA8TKOEeOqyZqt0rCZLg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Card Payment Data Set Transaction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentDataSetTransaction9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentDataSetTransaction9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentDataSetTransaction9( System.String reqTransactionSequenceCounter,CardPaymentEnvironment28 reqEnvironment,CardPaymentTransaction32 reqTransaction,CardPaymentTransaction24 reqTransactionResponse )
    {
        TransactionSequenceCounter = reqTransactionSequenceCounter;
        Environment = reqEnvironment;
        Transaction = reqTransaction;
        TransactionResponse = reqTransactionResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_6ht2YTKOEeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Sequence Counter")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String TransactionSequenceCounter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionSequenceCounter { get; init; } 
    #else
    public System.String TransactionSequenceCounter { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_6ht2YzKOEeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Traceability")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Traceability1? Traceability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Traceability1? Traceability { get; init; } 
    #else
    public Traceability1? Traceability { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to the environment of the card payment transaction.
    /// </summary>
    [IsoId("_6ht2ZTKOEeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Environment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment28 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CardPaymentEnvironment28 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment28 Environment { get; init; } 
    #else
    public CardPaymentEnvironment28 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Card payment transaction authorisation result.
    /// </summary>
    [IsoId("_6ht2ZzKOEeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentTransaction32 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CardPaymentTransaction32 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction32 Transaction { get; init; } 
    #else
    public CardPaymentTransaction32 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Response to the authorisation request from the acquirer.
    /// </summary>
    [IsoId("_6ht2aTKOEeOqyZqt0rCZLg")]
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
