﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MessageStatusResponseData2.  ISO2002 ID# _YEAKUYYMEemxIqbaFEE8-w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Message status Response.
/// </summary>
[DataContract]
[XmlType]
public partial record MessageStatusResponseData2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the requested previous message.
    /// </summary>
    [DataMember]
    public required IsoMax35Text ExchangeIdentification { get; init; } 
    /// <summary>
    /// Party that has initiated the previous message.
    /// </summary>
    [DataMember]
    public required GenericIdentification171 InitiatingParty { get; init; } 
    /// <summary>
    /// Specific response of the Repeated Message sent back by the POI System.
    /// </summary>
    [DataMember]
    public required ResponseType9 TransactionResponse { get; init; } 
    /// <summary>
    /// Content of the requested Loyalty Message Response.
    /// </summary>
    [DataMember]
    public LoyaltyResponse1? RepeatedLoyaltyResponse { get; init; } 
    /// <summary>
    /// Content of the requested Payment Message Response.
    /// </summary>
    [DataMember]
    public PaymentResponse1? RepeatedPaymentResponse { get; init; } 
    /// <summary>
    /// Content of the requested Reversal Message Response.
    /// </summary>
    [DataMember]
    public ReversalResponse1? RepeatedReversalResponse { get; init; } 
    /// <summary>
    /// Content of the requested StoredValue Message Response.
    /// </summary>
    [DataMember]
    public StoredValueResponse2? RepeatedStoredValueResponse { get; init; } 
    /// <summary>
    /// Content of the requested CardAcquisition Message Response.
    /// </summary>
    [DataMember]
    public CardAcquisitionResponse1? RepeatedCardAcquisitionResponse { get; init; } 
    /// <summary>
    /// Content of the requested SendApplicationProtocolDataUnitCardReader Message Response.
    /// </summary>
    [DataMember]
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? RepeatedSendApplicationProtocolDataUnitCardReaderResponse { get; init; } 
    
    #nullable disable
}
