﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesFinancingConfirmationIdentification.  ISO2002 ID# _Wkm3j0fGEey6Is2iMqV8fg.
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
namespace BeneficialStrategies.Iso20022.Choices.References79Choice
{
    /// <summary>
    /// Unambiguous identification of the confirmation to be cancelled.
    /// </summary>
    [IsoId("_Wkm3j0fGEey6Is2iMqV8fg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities Financing Confirmation Identification")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SecuritiesFinancingConfirmationIdentification : References79Choice_
    #else
    public partial class SecuritiesFinancingConfirmationIdentification : References79Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SecuritiesFinancingConfirmationIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SecuritiesFinancingConfirmationIdentification( System.String reqTransactionIdentification,ReceiveDelivery1Code reqSecuritiesMovementType,DeliveryReceiptType2Code reqPayment )
        {
            TransactionIdentification = reqTransactionIdentification;
            SecuritiesMovementType = reqSecuritiesMovementType;
            Payment = reqPayment;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides unambiguous transaction identification information.
        /// </summary>
        [IsoId("_6EvMU5NLEeWGlc8L7oPDIg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Transaction Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoRestrictedFINXMax16Text TransactionIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String TransactionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String TransactionIdentification { get; init; } 
        #else
        public System.String TransactionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
        /// </summary>
        [IsoId("_6EvMVZNLEeWGlc8L7oPDIg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Securities Movement Type")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
        #else
        public ReceiveDelivery1Code SecuritiesMovementType { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies how the transaction is to be settled, for example, against payment.
        /// </summary>
        [IsoId("_6EvMV5NLEeWGlc8L7oPDIg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Payment")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DeliveryReceiptType2Code Payment { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public DeliveryReceiptType2Code Payment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DeliveryReceiptType2Code Payment { get; init; } 
        #else
        public DeliveryReceiptType2Code Payment { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
