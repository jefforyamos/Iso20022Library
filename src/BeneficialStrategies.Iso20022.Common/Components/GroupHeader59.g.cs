﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GroupHeader59.  ISO2002 ID# _s-e4EVkyEeGeoaLUQk__nA_754761691.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the message.
/// </summary>
public partial record GroupHeader59
     : IIsoXmlSerilizable<GroupHeader59>
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the account owner or the party authorised to send the message, and sent to the account servicing institution, to unambiguously identify the message.|Usage: The sender has to make sure that 'MessageIdentification' is unique per account servicing institution for a pre-agreed period.
    /// </summary>
    public required IsoMax35Text MessageIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Identification of the party that is sending the message, when different from the account owner.
    /// </summary>
    public Party12Choice_? MessageSender { get; init; } 
    
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
        writer.WriteStartElement(null, "MsgId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(MessageIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CreDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(CreationDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (MessageSender is Party12Choice_ MessageSenderValue)
        {
            writer.WriteStartElement(null, "MsgSndr", xmlNamespace );
            MessageSenderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static GroupHeader59 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
