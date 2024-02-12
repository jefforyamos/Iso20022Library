﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MessageStatusResponseData7.  ISO2002 ID# _VigGkXIqEe299ZbWCkdR_w.
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
/// Content of the Message status Response.
/// </summary>
[IsoId("_VigGkXIqEe299ZbWCkdR_w")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Message Status Response Data")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MessageStatusResponseData7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MessageStatusResponseData7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MessageStatusResponseData7( System.String reqExchangeIdentification,GenericIdentification177 reqInitiatingParty,ResponseType11 reqTransactionResponse )
    {
        ExchangeIdentification = reqExchangeIdentification;
        InitiatingParty = reqInitiatingParty;
        TransactionResponse = reqTransactionResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the requested previous message.
    /// </summary>
    [IsoId("_Vp02kXIqEe299ZbWCkdR_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Exchange Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ExchangeIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ExchangeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExchangeIdentification { get; init; } 
    #else
    public System.String ExchangeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that has initiated the previous message.
    /// </summary>
    [IsoId("_Vp02k3IqEe299ZbWCkdR_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Initiating Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification177 InitiatingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public GenericIdentification177 InitiatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification177 InitiatingParty { get; init; } 
    #else
    public GenericIdentification177 InitiatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Specific response of the Repeated Message sent back by the POI System.
    /// </summary>
    [IsoId("_Vp02lXIqEe299ZbWCkdR_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Response")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType11 TransactionResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ResponseType11 TransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType11 TransactionResponse { get; init; } 
    #else
    public ResponseType11 TransactionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the requested Loyalty Message Response.
    /// </summary>
    [IsoId("_Vp02l3IqEe299ZbWCkdR_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Repeated Loyalty Response")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyResponse3? RepeatedLoyaltyResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyResponse3? RepeatedLoyaltyResponse { get; init; } 
    #else
    public LoyaltyResponse3? RepeatedLoyaltyResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the requested Payment Message Response.
    /// </summary>
    [IsoId("_Vp02mXIqEe299ZbWCkdR_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Repeated Payment Response")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentResponse5? RepeatedPaymentResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentResponse5? RepeatedPaymentResponse { get; init; } 
    #else
    public PaymentResponse5? RepeatedPaymentResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the requested Reversal Message Response.
    /// </summary>
    [IsoId("_Vp02m3IqEe299ZbWCkdR_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Repeated Reversal Response")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReversalResponse7? RepeatedReversalResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversalResponse7? RepeatedReversalResponse { get; init; } 
    #else
    public ReversalResponse7? RepeatedReversalResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the requested StoredValue Message Response.
    /// </summary>
    [IsoId("_Vp02nXIqEe299ZbWCkdR_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Repeated Stored Value Response")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueResponse6? RepeatedStoredValueResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueResponse6? RepeatedStoredValueResponse { get; init; } 
    #else
    public StoredValueResponse6? RepeatedStoredValueResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the requested CardAcquisition Message Response.
    /// </summary>
    [IsoId("_Vp02n3IqEe299ZbWCkdR_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Repeated Card Acquisition Response")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAcquisitionResponse3? RepeatedCardAcquisitionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAcquisitionResponse3? RepeatedCardAcquisitionResponse { get; init; } 
    #else
    public CardAcquisitionResponse3? RepeatedCardAcquisitionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the requested SendApplicationProtocolDataUnitCardReader Message Response.
    /// </summary>
    [IsoId("_Vp02oXIqEe299ZbWCkdR_w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Repeated Send Application Protocol Data Unit Card Reader Response")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? RepeatedSendApplicationProtocolDataUnitCardReaderResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? RepeatedSendApplicationProtocolDataUnitCardReaderResponse { get; init; } 
    #else
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? RepeatedSendApplicationProtocolDataUnitCardReaderResponse { get; set; } 
    #endif
    
    
    #nullable disable
    
}
