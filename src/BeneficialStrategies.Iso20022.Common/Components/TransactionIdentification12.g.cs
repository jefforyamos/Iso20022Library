﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionIdentification12.  ISO2002 ID# _yGEF8cWZEeiCfKAZkk6ZAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the transaction for network management.
/// </summary>
public partial record TransactionIdentification12
     : IIsoXmlSerilizable<TransactionIdentification12>
{
    #nullable enable
    
    /// <summary>
    /// Number assigned by a transaction originator to assist in identifying a transaction uniquely. The trace number remains unchanged for all messages within a two-message exchange (for example, request/repeat and response)
    /// ISO 8583 bit 11.
    /// </summary>
    public required IsoMax12NumericText SystemTraceAuditNumber { get; init; } 
    /// <summary>
    /// Date and time expressed in UTC of the message as sent by the initiator.
    /// ISO 8583 bit 7
    /// </summary>
    public required IsoISODateTime TransmissionDateTime { get; init; } 
    /// <summary>
    /// A reference supplied by the system retaining the original source information and used to assist in locating that information or a copy thereof.
    /// ISO 8583 bit 37
    /// </summary>
    public IsoExact12Text? RetrievalReferenceNumber { get; init; } 
    /// <summary>
    /// Unique global identification structure used to match transactions throughout their lifecycle.
    /// ISO 8583:2003 bit 21
    /// </summary>
    public TransactionLifeCycleIdentification2? LifeCycleTraceIdentificationData { get; init; } 
    
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
        writer.WriteStartElement(null, "SysTracAudtNb", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax12NumericText(SystemTraceAuditNumber)); // data type Max12NumericText System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TrnsmssnDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(TransmissionDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (RetrievalReferenceNumber is IsoExact12Text RetrievalReferenceNumberValue)
        {
            writer.WriteStartElement(null, "RtrvlRefNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact12Text(RetrievalReferenceNumberValue)); // data type Exact12Text System.String
            writer.WriteEndElement();
        }
        if (LifeCycleTraceIdentificationData is TransactionLifeCycleIdentification2 LifeCycleTraceIdentificationDataValue)
        {
            writer.WriteStartElement(null, "LifeCyclTracIdData", xmlNamespace );
            LifeCycleTraceIdentificationDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransactionIdentification12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
