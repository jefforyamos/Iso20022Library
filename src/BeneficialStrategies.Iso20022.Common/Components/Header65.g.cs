﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Header65.  ISO2002 ID# _PgRJoRymEeyVgKPonV4SjQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the protocol.
/// Header for an amendment message.
/// </summary>
public partial record Header65
     : IIsoXmlSerilizable<Header65>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    public required MessageFunction27Code MessageFunction { get; init; } 
    /// <summary>
    /// Version of the acquirer to issuer protocol specifications.
    /// </summary>
    public required IsoMax2048Text ProtocolVersion { get; init; } 
    /// <summary>
    /// Unique identification of an exchange of messages between two parties.
    /// </summary>
    public IsoMax35Text? ExchangeIdentification { get; init; } 
    /// <summary>
    /// Number of retransmission of the message. Incremented by one for each retransmission.
    /// </summary>
    public IsoMax3NumericText? ReTransmissionCounter { get; init; } 
    /// <summary>
    /// Date and time at which the message was sent.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Information related to the batch and the collection to which the message belongs if any.
    /// </summary>
    public BatchManagementInformation1? BatchManagementInformation { get; init; } 
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    public required GenericIdentification183 InitiatingParty { get; init; } 
    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    public GenericIdentification183? RecipientParty { get; init; } 
    /// <summary>
    /// Information sent in the request message to be returned in the response one, for instance to help in the retrieval of the context of the exchange.
    /// </summary>
    public AdditionalData1? TraceData { get; init; } 
    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    public Traceability9? Traceability { get; init; } 
    
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
        writer.WriteStartElement(null, "MsgFctn", xmlNamespace );
        writer.WriteValue(MessageFunction.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PrtcolVrsn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax2048Text(ProtocolVersion)); // data type Max2048Text System.String
        writer.WriteEndElement();
        if (ExchangeIdentification is IsoMax35Text ExchangeIdentificationValue)
        {
            writer.WriteStartElement(null, "XchgId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ExchangeIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ReTransmissionCounter is IsoMax3NumericText ReTransmissionCounterValue)
        {
            writer.WriteStartElement(null, "ReTrnsmssnCntr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3NumericText(ReTransmissionCounterValue)); // data type Max3NumericText System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CreDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(CreationDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (BatchManagementInformation is BatchManagementInformation1 BatchManagementInformationValue)
        {
            writer.WriteStartElement(null, "BtchMgmtInf", xmlNamespace );
            BatchManagementInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "InitgPty", xmlNamespace );
        InitiatingParty.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (RecipientParty is GenericIdentification183 RecipientPartyValue)
        {
            writer.WriteStartElement(null, "RcptPty", xmlNamespace );
            RecipientPartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TraceData is AdditionalData1 TraceDataValue)
        {
            writer.WriteStartElement(null, "TracData", xmlNamespace );
            TraceDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Traceability is Traceability9 TraceabilityValue)
        {
            writer.WriteStartElement(null, "Tracblt", xmlNamespace );
            TraceabilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Header65 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
