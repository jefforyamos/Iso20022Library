﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AuthorisationRequest.  ISO2002 ID# _bgZKtU0ZEeybj420QgWBkA.
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
namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction10Choice
{
    /// <summary>
    /// Card payment transaction including an authorisation request.
    /// </summary>
    [IsoId("_bgZKtU0ZEeybj420QgWBkA")]
    [DisplayName("Authorisation Request")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AuthorisationRequest : CardPaymentDataSetTransaction10Choice_
    #else
    public partial class AuthorisationRequest : CardPaymentDataSetTransaction10Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AuthorisationRequest instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AuthorisationRequest( System.String reqTransactionSequenceCounter,CardPaymentEnvironment78 reqEnvironment,CardPaymentTransaction119 reqTransaction )
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
        [IsoId("_9B_DQU3jEey_VecAUE-C9Q")]
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
        [IsoId("_9B_DQ03jEey_VecAUE-C9Q")]
        [DisplayName("Traceability")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tracblt")]
        #endif
        [IsoXmlTag("Tracblt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Traceability8? Traceability { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Traceability8? Traceability { get; init; } 
        #else
        public Traceability8? Traceability { get; set; } 
        #endif
        
        /// <summary>
        /// Data related to the environment of the card payment transaction to authorise.
        /// </summary>
        [IsoId("_9B_DRU3jEey_VecAUE-C9Q")]
        [DisplayName("Environment")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Envt")]
        #endif
        [IsoXmlTag("Envt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CardPaymentEnvironment78 Environment { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CardPaymentEnvironment78 Environment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentEnvironment78 Environment { get; init; } 
        #else
        public CardPaymentEnvironment78 Environment { get; set; } 
        #endif
        
        /// <summary>
        /// Context in which the transaction is performed (payment and sale).
        /// </summary>
        [IsoId("_9B_DR03jEey_VecAUE-C9Q")]
        [DisplayName("Context")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cntxt")]
        #endif
        [IsoXmlTag("Cntxt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CardPaymentContext29? Context { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentContext29? Context { get; init; } 
        #else
        public CardPaymentContext29? Context { get; set; } 
        #endif
        
        /// <summary>
        /// Card payment transaction to authorise.
        /// </summary>
        [IsoId("_9B_DSU3jEey_VecAUE-C9Q")]
        [DisplayName("Transaction")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tx")]
        #endif
        [IsoXmlTag("Tx")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CardPaymentTransaction119 Transaction { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CardPaymentTransaction119 Transaction { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentTransaction119 Transaction { get; init; } 
        #else
        public CardPaymentTransaction119 Transaction { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
