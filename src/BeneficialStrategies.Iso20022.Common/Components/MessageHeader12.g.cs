﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MessageHeader12.  ISO2002 ID# _Hm0DQYtSEeih5rmIxWMzEw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the header data such as the identification and the creation date and time, specific to the message.
/// </summary>
public partial record MessageHeader12
     : IIsoXmlSerilizable<MessageHeader12>
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the sender, to unambiguously identify the message.|Usage: The sender has to make sure that MessageIdentification is unique for a pre-agreed period.
    /// </summary>
    public required IsoMax35Text MessageIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    public IsoISODateTime? CreationDateTime { get; init; } 
    /// <summary>
    /// Unique identification of the original instruction.
    /// </summary>
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; } 
    
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
        if (CreationDateTime is IsoISODateTime CreationDateTimeValue)
        {
            writer.WriteStartElement(null, "CreDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(CreationDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (OriginalBusinessInstruction is OriginalBusinessInstruction1 OriginalBusinessInstructionValue)
        {
            writer.WriteStartElement(null, "OrgnlBizInstr", xmlNamespace );
            OriginalBusinessInstructionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MessageHeader12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
