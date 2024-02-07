﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Header19.  ISO2002 ID# _Hrm-EXvUEeS7Wv4oKCO8_A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the protocol.
/// </summary>
public partial record Header19
     : IIsoXmlSerilizable<Header19>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    public required MessageFunction6Code MessageFunction { get; init; } 
    /// <summary>
    /// Identifies the type of process related to the message which has to be reversed.
    /// </summary>
    public MessageFunction6Code? OriginalMessageFunction { get; init; } 
    /// <summary>
    /// Version of the acquirer to issuer protocol specifications.
    /// </summary>
    public required IsoMax6Text ProtocolVersion { get; init; } 
    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    public required IsoMax3NumericText ExchangeIdentification { get; init; } 
    /// <summary>
    /// Number of retransmission of the message. Incremented by 1 for each retransmission.
    /// </summary>
    public IsoMax3NumericText? ReTransmissionCounter { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    public GenericIdentification73? InitiatingParty { get; init; } 
    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    public GenericIdentification73? RecipientParty { get; init; } 
    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    public Traceability3? Traceability { get; init; } 
    
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
        if (OriginalMessageFunction is MessageFunction6Code OriginalMessageFunctionValue)
        {
            writer.WriteStartElement(null, "OrgnlMsgFctn", xmlNamespace );
            writer.WriteValue(OriginalMessageFunctionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PrtcolVrsn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax6Text(ProtocolVersion)); // data type Max6Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "XchgId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax3NumericText(ExchangeIdentification)); // data type Max3NumericText System.String
        writer.WriteEndElement();
        if (ReTransmissionCounter is IsoMax3NumericText ReTransmissionCounterValue)
        {
            writer.WriteStartElement(null, "ReTrnsmssnCntr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3NumericText(ReTransmissionCounterValue)); // data type Max3NumericText System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CreDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(CreationDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (InitiatingParty is GenericIdentification73 InitiatingPartyValue)
        {
            writer.WriteStartElement(null, "InitgPty", xmlNamespace );
            InitiatingPartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RecipientParty is GenericIdentification73 RecipientPartyValue)
        {
            writer.WriteStartElement(null, "RcptPty", xmlNamespace );
            RecipientPartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Traceability is Traceability3 TraceabilityValue)
        {
            writer.WriteStartElement(null, "Tracblt", xmlNamespace );
            TraceabilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Header19 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
