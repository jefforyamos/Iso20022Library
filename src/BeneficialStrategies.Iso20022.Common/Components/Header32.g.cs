﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Header32.  ISO2002 ID# _4Wfn0a4JEeWZgJQOa6iKCQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
/// </summary>
public partial record Header32
     : IIsoXmlSerilizable<Header32>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    public required ATMMessageFunction2 MessageFunction { get; init; } 
    /// <summary>
    /// Version of the ATM protocol specifications.
    /// </summary>
    public required IsoMax6Text ProtocolVersion { get; init; } 
    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    public required IsoMax3NumericText ExchangeIdentification { get; init; } 
    /// <summary>
    ///  Retransmission counter of this advice, 0 for the first transmission.
    /// </summary>
    public IsoNumber? ReTransmissionCounter { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    public required IsoMax35Text InitiatingParty { get; init; } 
    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    public IsoMax35Text? RecipientParty { get; init; } 
    /// <summary>
    /// State of the sender of the message inside the process flow.
    /// </summary>
    public IsoMax35Text? ProcessState { get; init; } 
    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    public Traceability4? Traceability { get; init; } 
    
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
        MessageFunction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PrtcolVrsn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax6Text(ProtocolVersion)); // data type Max6Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "XchgId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax3NumericText(ExchangeIdentification)); // data type Max3NumericText System.String
        writer.WriteEndElement();
        if (ReTransmissionCounter is IsoNumber ReTransmissionCounterValue)
        {
            writer.WriteStartElement(null, "ReTrnsmssnCntr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(ReTransmissionCounterValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CreDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(CreationDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InitgPty", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(InitiatingParty)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (RecipientParty is IsoMax35Text RecipientPartyValue)
        {
            writer.WriteStartElement(null, "RcptPty", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(RecipientPartyValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ProcessState is IsoMax35Text ProcessStateValue)
        {
            writer.WriteStartElement(null, "PrcStat", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProcessStateValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Traceability is Traceability4 TraceabilityValue)
        {
            writer.WriteStartElement(null, "Tracblt", xmlNamespace );
            TraceabilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Header32 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
