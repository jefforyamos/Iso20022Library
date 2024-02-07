﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalBusinessInstruction4.  ISO2002 ID# _P2u1uRd0EeqIn-BjQjNcxg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification, as assigned by the original requestor, to unambiguously identify the business instruction message.
/// </summary>
public partial record OriginalBusinessInstruction4
     : IIsoXmlSerilizable<OriginalBusinessInstruction4>
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original initiating party, to unambiguously identify the original instruction message.
    /// </summary>
    public IsoMax35Text? MessageIdentification { get; init; } 
    /// <summary>
    /// Specifies the instruction message name identifier to which the message refers.
    /// </summary>
    public IsoMax35Text? MessageNameIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    public IsoISODateTime? CreationDateTime { get; init; } 
    
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
        if (MessageIdentification is IsoMax35Text MessageIdentificationValue)
        {
            writer.WriteStartElement(null, "MsgId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MessageIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (MessageNameIdentification is IsoMax35Text MessageNameIdentificationValue)
        {
            writer.WriteStartElement(null, "MsgNmId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MessageNameIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CreationDateTime is IsoISODateTime CreationDateTimeValue)
        {
            writer.WriteStartElement(null, "CreDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(CreationDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
    }
    public static OriginalBusinessInstruction4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
