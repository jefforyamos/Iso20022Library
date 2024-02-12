﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PaymentCardDetails.  ISO2002 ID# _Jmv4wZTBEemqYPWMBuVawg.
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
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument24Choice
{
    /// <summary>
    /// Settlement instructions for a payment by card.
    /// </summary>
    [IsoId("_Jmv4wZTBEemqYPWMBuVawg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Card Details")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PaymentCardDetails : PaymentInstrument24Choice_
    #else
    public partial class PaymentCardDetails : PaymentInstrument24Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PaymentCardDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PaymentCardDetails( CardType1Code reqType,System.String reqNumber,System.String reqHolderName,System.UInt16 reqExpiryDate )
        {
            Type = reqType;
            Number = reqNumber;
            HolderName = reqHolderName;
            ExpiryDate = reqExpiryDate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Type of card, for example, credit card.
        /// </summary>
        [IsoId("_OQmYwZTBEemqYPWMBuVawg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Type")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CardType1Code Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public CardType1Code Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardType1Code Type { get; init; } 
        #else
        public CardType1Code Type { get; set; } 
        #endif
        
        /// <summary>
        /// Number embossed on a card that links the card to the account owner and account servicer.
        /// </summary>
        [IsoId("_OQmYw5TBEemqYPWMBuVawg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Number")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Number { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String Number { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Number { get; init; } 
        #else
        public System.String Number { get; set; } 
        #endif
        
        /// <summary>
        /// Party entitled by a card issuer to use a card.
        /// </summary>
        [IsoId("_OQmYxZTBEemqYPWMBuVawg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Holder Name")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text HolderName { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String HolderName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String HolderName { get; init; } 
        #else
        public System.String HolderName { get; set; } 
        #endif
        
        /// <summary>
        /// Year and month the card is available for use.
        /// </summary>
        [IsoId("_OQmYx5TBEemqYPWMBuVawg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Start Date")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISOYearMonth? StartDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt16? StartDate { get; init; } 
        #else
        public System.UInt16? StartDate { get; set; } 
        #endif
        
        /// <summary>
        /// Year and month the card expires.
        /// </summary>
        [IsoId("_OQmYyZTBEemqYPWMBuVawg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Expiry Date")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISOYearMonth ExpiryDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.UInt16 ExpiryDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt16 ExpiryDate { get; init; } 
        #else
        public System.UInt16 ExpiryDate { get; set; } 
        #endif
        
        /// <summary>
        /// Party that issues a payment card, as expressed by a numeric identification of the card issuer according to ISO/IEC 7812-1.
        /// </summary>
        [IsoId("_OQmYy5TBEemqYPWMBuVawg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Card Issuer Name")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? CardIssuerName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? CardIssuerName { get; init; } 
        #else
        public System.String? CardIssuerName { get; set; } 
        #endif
        
        /// <summary>
        /// Party that issues a payment card, as expressed by a numeric identification of the card issuer according to ISO/IEC 7812-1.
        /// </summary>
        [IsoId("_OQmYzZTBEemqYPWMBuVawg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Card Issuer Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification125Choice_? CardIssuerIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification125Choice_? CardIssuerIdentification { get; init; } 
        #else
        public PartyIdentification125Choice_? CardIssuerIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Security code written on, or in, the card.
        /// </summary>
        [IsoId("_OQmYz5TBEemqYPWMBuVawg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Security Code")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? SecurityCode { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? SecurityCode { get; init; } 
        #else
        public System.String? SecurityCode { get; set; } 
        #endif
        
        /// <summary>
        /// Number distinguishing two or more payment cards with the same account number.
        /// </summary>
        [IsoId("_OQmY0ZTBEemqYPWMBuVawg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Sequence Number")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 3 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax3Text? SequenceNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? SequenceNumber { get; init; } 
        #else
        public System.String? SequenceNumber { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
