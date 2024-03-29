﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentDataSetTransaction12.  ISO2002 ID# _xsescWmMEeS7iYydEtv3Ug.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Card payment transaction to be authorised in a batch.
/// </summary>
[IsoId("_xsescWmMEeS7iYydEtv3Ug")]
[DisplayName("Card Payment Data Set Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentDataSetTransaction12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentDataSetTransaction12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentDataSetTransaction12( System.String reqTransactionSequenceCounter,CardPaymentEnvironment32 reqEnvironment,CardPaymentTransaction47 reqTransaction )
    {
        TransactionSequenceCounter = reqTransactionSequenceCounter;
        Environment = reqEnvironment;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_x5micWmMEeS7iYydEtv3Ug")]
    [DisplayName("Transaction Sequence Counter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSeqCntr")]
    #endif
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionSequenceCounter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionSequenceCounter { get; init; } 
    #else
    public System.String TransactionSequenceCounter { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_x5mic2mMEeS7iYydEtv3Ug")]
    [DisplayName("Traceability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tracblt")]
    #endif
    [IsoXmlTag("Tracblt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Traceability2? Traceability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Traceability2? Traceability { get; init; } 
    #else
    public Traceability2? Traceability { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to the environment of the card payment transaction to authorise.
    /// </summary>
    [IsoId("_x5midWmMEeS7iYydEtv3Ug")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment32 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment32 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment32 Environment { get; init; } 
    #else
    public CardPaymentEnvironment32 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_x5mid2mMEeS7iYydEtv3Ug")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentContext12? Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentContext12? Context { get; init; } 
    #else
    public CardPaymentContext12? Context { get; set; } 
    #endif
    
    /// <summary>
    /// Card payment transaction to authorise.
    /// </summary>
    [IsoId("_x5mieWmMEeS7iYydEtv3Ug")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentTransaction47 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentTransaction47 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction47 Transaction { get; init; } 
    #else
    public CardPaymentTransaction47 Transaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
