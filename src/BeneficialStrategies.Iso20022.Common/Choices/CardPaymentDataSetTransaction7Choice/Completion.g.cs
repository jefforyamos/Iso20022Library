﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Completion.  ISO2002 ID# _438TcdeiEeiJyp_aycJaTw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction7Choice
{
    /// <summary>
    /// Completed card payment transaction to be captured.
    /// </summary>
    [IsoId("_438TcdeiEeiJyp_aycJaTw")]
    [DisplayName("Completion")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Completion : CardPaymentDataSetTransaction7Choice_
    #else
    public partial class Completion : CardPaymentDataSetTransaction7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Completion instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Completion( System.String reqTransactionSequenceCounter,CardPaymentEnvironment68 reqEnvironment,CardPaymentTransaction89 reqTransaction )
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
        [IsoId("_23Y7gNejEeiJyp_aycJaTw")]
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
        [IsoId("_23Y7gtejEeiJyp_aycJaTw")]
        [DisplayName("Traceability")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tracblt")]
        #endif
        [IsoXmlTag("Tracblt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Traceability5? Traceability { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Traceability5? Traceability { get; init; } 
        #else
        public Traceability5? Traceability { get; set; } 
        #endif
        
        /// <summary>
        /// Data related to the environment of the transaction in a transaction captured in batch.
        /// </summary>
        [IsoId("_23Y7hNejEeiJyp_aycJaTw")]
        [DisplayName("Environment")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Envt")]
        #endif
        [IsoXmlTag("Envt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CardPaymentEnvironment68 Environment { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CardPaymentEnvironment68 Environment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentEnvironment68 Environment { get; init; } 
        #else
        public CardPaymentEnvironment68 Environment { get; set; } 
        #endif
        
        /// <summary>
        /// Data related to the context of the transaction.
        /// </summary>
        [IsoId("_23Y7htejEeiJyp_aycJaTw")]
        [DisplayName("Context")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cntxt")]
        #endif
        [IsoXmlTag("Cntxt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CardPaymentContext27? Context { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentContext27? Context { get; init; } 
        #else
        public CardPaymentContext27? Context { get; set; } 
        #endif
        
        /// <summary>
        /// Transaction information to be captured.
        /// </summary>
        [IsoId("_23Y7iNejEeiJyp_aycJaTw")]
        [DisplayName("Transaction")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tx")]
        #endif
        [IsoXmlTag("Tx")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CardPaymentTransaction89 Transaction { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CardPaymentTransaction89 Transaction { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentTransaction89 Transaction { get; init; } 
        #else
        public CardPaymentTransaction89 Transaction { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
