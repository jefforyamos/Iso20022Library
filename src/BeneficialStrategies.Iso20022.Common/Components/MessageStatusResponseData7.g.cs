﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MessageStatusResponseData7.  ISO2002 ID# _VigGkXIqEe299ZbWCkdR_w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Message status Response.
/// </summary>
public partial record MessageStatusResponseData7
     : IIsoXmlSerilizable<MessageStatusResponseData7>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the requested previous message.
    /// </summary>
    public required IsoMax35Text ExchangeIdentification { get; init; } 
    /// <summary>
    /// Party that has initiated the previous message.
    /// </summary>
    public required GenericIdentification177 InitiatingParty { get; init; } 
    /// <summary>
    /// Specific response of the Repeated Message sent back by the POI System.
    /// </summary>
    public required ResponseType11 TransactionResponse { get; init; } 
    /// <summary>
    /// Content of the requested Loyalty Message Response.
    /// </summary>
    public LoyaltyResponse3? RepeatedLoyaltyResponse { get; init; } 
    /// <summary>
    /// Content of the requested Payment Message Response.
    /// </summary>
    public PaymentResponse5? RepeatedPaymentResponse { get; init; } 
    /// <summary>
    /// Content of the requested Reversal Message Response.
    /// </summary>
    public ReversalResponse7? RepeatedReversalResponse { get; init; } 
    /// <summary>
    /// Content of the requested StoredValue Message Response.
    /// </summary>
    public StoredValueResponse6? RepeatedStoredValueResponse { get; init; } 
    /// <summary>
    /// Content of the requested CardAcquisition Message Response.
    /// </summary>
    public CardAcquisitionResponse3? RepeatedCardAcquisitionResponse { get; init; } 
    /// <summary>
    /// Content of the requested SendApplicationProtocolDataUnitCardReader Message Response.
    /// </summary>
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? RepeatedSendApplicationProtocolDataUnitCardReaderResponse { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "XchgId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(ExchangeIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InitgPty", xmlNamespace );
        InitiatingParty.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxRspn", xmlNamespace );
        TransactionResponse.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (RepeatedLoyaltyResponse is LoyaltyResponse3 RepeatedLoyaltyResponseValue)
        {
            writer.WriteStartElement(null, "RpeatdLltyRspn", xmlNamespace );
            RepeatedLoyaltyResponseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RepeatedPaymentResponse is PaymentResponse5 RepeatedPaymentResponseValue)
        {
            writer.WriteStartElement(null, "RpeatdPmtRspn", xmlNamespace );
            RepeatedPaymentResponseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RepeatedReversalResponse is ReversalResponse7 RepeatedReversalResponseValue)
        {
            writer.WriteStartElement(null, "RpeatdRvslRspn", xmlNamespace );
            RepeatedReversalResponseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RepeatedStoredValueResponse is StoredValueResponse6 RepeatedStoredValueResponseValue)
        {
            writer.WriteStartElement(null, "RpeatdStordValRspn", xmlNamespace );
            RepeatedStoredValueResponseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RepeatedCardAcquisitionResponse is CardAcquisitionResponse3 RepeatedCardAcquisitionResponseValue)
        {
            writer.WriteStartElement(null, "RpeatdCardAcqstnRspn", xmlNamespace );
            RepeatedCardAcquisitionResponseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RepeatedSendApplicationProtocolDataUnitCardReaderResponse is DeviceSendApplicationProtocolDataUnitCardReaderResponse1 RepeatedSendApplicationProtocolDataUnitCardReaderResponseValue)
        {
            writer.WriteStartElement(null, "RpeatdSndApplPrtcolDataUnitCardRdrRspn", xmlNamespace );
            RepeatedSendApplicationProtocolDataUnitCardReaderResponseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MessageStatusResponseData7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
