﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Cancellation.  ISO2002 ID# _EzeIQ2mJEeS7iYydEtv3Ug.
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
namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction3Choice
{
    /// <summary>
    /// Cancelled card payment transaction to be captured.
    /// </summary>
    [IsoId("_EzeIQ2mJEeS7iYydEtv3Ug")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cancellation")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Cancellation : CardPaymentDataSetTransaction3Choice_
    #else
    public partial class Cancellation : CardPaymentDataSetTransaction3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Cancellation instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Cancellation( System.String reqTransactionSequenceCounter,CardPaymentEnvironment40 reqEnvironment,CardPaymentTransaction46 reqTransaction )
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
        [IsoId("_f8cOwWmLEeS7iYydEtv3Ug")]
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
        [IsoId("_f8cOw2mLEeS7iYydEtv3Ug")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Traceability")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Traceability2? Traceability { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Traceability2? Traceability { get; init; } 
        #else
        public Traceability2? Traceability { get; set; } 
        #endif
        
        /// <summary>
        /// Data related to the environment of the cancelled transaction captured in batch.
        /// </summary>
        [IsoId("_f8cOxWmLEeS7iYydEtv3Ug")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Environment")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CardPaymentEnvironment40 Environment { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public CardPaymentEnvironment40 Environment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentEnvironment40 Environment { get; init; } 
        #else
        public CardPaymentEnvironment40 Environment { get; set; } 
        #endif
        
        /// <summary>
        /// Context in which the transaction is performed (payment and sale).
        /// </summary>
        [IsoId("_f8cOx2mLEeS7iYydEtv3Ug")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Context")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CardPaymentContext13? Context { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentContext13? Context { get; init; } 
        #else
        public CardPaymentContext13? Context { get; set; } 
        #endif
        
        /// <summary>
        /// Card payment cancellation transaction between an acceptor and an acquirer.
        /// </summary>
        [IsoId("_f8cOyWmLEeS7iYydEtv3Ug")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Transaction")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CardPaymentTransaction46 Transaction { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public CardPaymentTransaction46 Transaction { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentTransaction46 Transaction { get; init; } 
        #else
        public CardPaymentTransaction46 Transaction { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
