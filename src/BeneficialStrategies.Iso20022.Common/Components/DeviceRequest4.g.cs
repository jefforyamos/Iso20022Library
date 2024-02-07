﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceRequest4.  ISO2002 ID# _YVZewS5KEeunNvJlR_vCbg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the environment, the context and the services to be used with this message.
/// </summary>
public partial record DeviceRequest4
     : IIsoXmlSerilizable<DeviceRequest4>
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public CardPaymentEnvironment77? Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    public CardPaymentContext28? Context { get; init; } 
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    public required RetailerService8Code ServiceContent { get; init; } 
    /// <summary>
    /// Content of the Display Request message.
    /// </summary>
    public DeviceDisplayRequest3? DisplayRequest { get; init; } 
    /// <summary>
    /// Content of the Input Request message.
    /// </summary>
    public DeviceInputRequest3? InputRequest { get; init; } 
    /// <summary>
    /// Content of the Print Request message.
    /// </summary>
    public DevicePrintRequest3? PrintRequest { get; init; } 
    /// <summary>
    /// Content of the Resource Request message.
    /// </summary>
    public DevicePlayResourceRequest1? PlayResourceRequest { get; init; } 
    /// <summary>
    /// Request a secure input for a PIN.
    /// </summary>
    public DeviceSecureInputRequest3? SecureInputRequest { get; init; } 
    /// <summary>
    /// A service to send parameters to Card Reader to initialize a new communication with a card.
    /// </summary>
    public DeviceInitialisationCardReaderRequest3? InitialisationCardReaderRequest { get; init; } 
    /// <summary>
    /// Content of the APDU (Application Protocol Data Unit) to send to the Card.
    /// </summary>
    public DeviceSendApplicationProtocolDataUnitCardReaderRequest1? CardReaderAPDURequest { get; init; } 
    /// <summary>
    /// Content of the Power Off Card Reader Request message.
    /// </summary>
    public DevicePoweroffCardReaderRequest3? PowerOffCardReaderRequest { get; init; } 
    /// <summary>
    /// Content of the Request message to transmit.
    /// </summary>
    public DeviceTransmitMessageRequest2? TransmissionRequest { get; init; } 
    /// <summary>
    /// Content of the Input notification message.
    /// </summary>
    public DeviceInputNotification3? InputNotification { get; init; } 
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
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
        if (Environment is CardPaymentEnvironment77 EnvironmentValue)
        {
            writer.WriteStartElement(null, "Envt", xmlNamespace );
            EnvironmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Context is CardPaymentContext28 ContextValue)
        {
            writer.WriteStartElement(null, "Cntxt", xmlNamespace );
            ContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SvcCntt", xmlNamespace );
        writer.WriteValue(ServiceContent.ToString()); // Enum value
        writer.WriteEndElement();
        if (DisplayRequest is DeviceDisplayRequest3 DisplayRequestValue)
        {
            writer.WriteStartElement(null, "DispReq", xmlNamespace );
            DisplayRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InputRequest is DeviceInputRequest3 InputRequestValue)
        {
            writer.WriteStartElement(null, "InptReq", xmlNamespace );
            InputRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PrintRequest is DevicePrintRequest3 PrintRequestValue)
        {
            writer.WriteStartElement(null, "PrtReq", xmlNamespace );
            PrintRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PlayResourceRequest is DevicePlayResourceRequest1 PlayResourceRequestValue)
        {
            writer.WriteStartElement(null, "PlayRsrcReq", xmlNamespace );
            PlayResourceRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecureInputRequest is DeviceSecureInputRequest3 SecureInputRequestValue)
        {
            writer.WriteStartElement(null, "ScrInptReq", xmlNamespace );
            SecureInputRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InitialisationCardReaderRequest is DeviceInitialisationCardReaderRequest3 InitialisationCardReaderRequestValue)
        {
            writer.WriteStartElement(null, "InitlstnCardRdrReq", xmlNamespace );
            InitialisationCardReaderRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CardReaderAPDURequest is DeviceSendApplicationProtocolDataUnitCardReaderRequest1 CardReaderAPDURequestValue)
        {
            writer.WriteStartElement(null, "CardRdrAPDUReq", xmlNamespace );
            CardReaderAPDURequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PowerOffCardReaderRequest is DevicePoweroffCardReaderRequest3 PowerOffCardReaderRequestValue)
        {
            writer.WriteStartElement(null, "PwrOffCardRdrReq", xmlNamespace );
            PowerOffCardReaderRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransmissionRequest is DeviceTransmitMessageRequest2 TransmissionRequestValue)
        {
            writer.WriteStartElement(null, "TrnsmssnReq", xmlNamespace );
            TransmissionRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InputNotification is DeviceInputNotification3 InputNotificationValue)
        {
            writer.WriteStartElement(null, "InptNtfctn", xmlNamespace );
            InputNotificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DeviceRequest4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
