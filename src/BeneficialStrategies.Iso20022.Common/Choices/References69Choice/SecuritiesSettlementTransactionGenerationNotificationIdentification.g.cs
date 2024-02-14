﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesSettlementTransactionGenerationNotificationIdentification.  ISO2002 ID# _z_ogSwzXEeuUZuaHWzkTew.
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
namespace BeneficialStrategies.Iso20022.Choices.References69Choice
{
    /// <summary>
    /// Unambiguous identification of the notification message to be cancelled.
    /// </summary>
    [IsoId("_z_ogSwzXEeuUZuaHWzkTew")]
    [DisplayName("Securities Settlement Transaction Generation Notification Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SecuritiesSettlementTransactionGenerationNotificationIdentification : References69Choice_
    #else
    public partial class SecuritiesSettlementTransactionGenerationNotificationIdentification : References69Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SecuritiesSettlementTransactionGenerationNotificationIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SecuritiesSettlementTransactionGenerationNotificationIdentification( System.String reqTransactionIdentification,ReceiveDelivery1Code reqSecuritiesMovementType,DeliveryReceiptType2Code reqPayment )
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
        [IsoId("_HIvRMzqoEeWyoP0PbocV1Q")]
        [DisplayName("Transaction Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxId")]
        #endif
        [IsoXmlTag("TxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text TransactionIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String TransactionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String TransactionIdentification { get; init; } 
        #else
        public System.String TransactionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
        /// </summary>
        [IsoId("_HIvRNTqoEeWyoP0PbocV1Q")]
        [DisplayName("Securities Movement Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SctiesMvmntTp")]
        #endif
        [IsoXmlTag("SctiesMvmntTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
        #else
        public ReceiveDelivery1Code SecuritiesMovementType { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies how the transaction is to be settled, for example, against payment.
        /// </summary>
        [IsoId("_HIvRNzqoEeWyoP0PbocV1Q")]
        [DisplayName("Payment")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Pmt")]
        #endif
        [IsoXmlTag("Pmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DeliveryReceiptType2Code Payment { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required DeliveryReceiptType2Code Payment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DeliveryReceiptType2Code Payment { get; init; } 
        #else
        public DeliveryReceiptType2Code Payment { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
