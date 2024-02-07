﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MessageHeader7.  ISO2002 ID# _imfkUZIhEeect698_YsnIA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics, such as the identification or the creation date and time, specific to the message.
/// </summary>
public partial record MessageHeader7
     : IIsoXmlSerilizable<MessageHeader7>
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
    /// Specific actions to be executed through the request.
    /// </summary>
    public RequestType4Choice_? RequestType { get; init; } 
    /// <summary>
    /// Unique identification of the original query message.
    /// </summary>
    public OriginalBusinessQuery1? OriginalBusinessQuery { get; init; } 
    /// <summary>
    /// Recalls the criteria (search and return criteria) defined in a preceding query.
    /// </summary>
    public IsoMax35Text? QueryName { get; init; } 
    
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
        if (RequestType is RequestType4Choice_ RequestTypeValue)
        {
            writer.WriteStartElement(null, "ReqTp", xmlNamespace );
            RequestTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalBusinessQuery is OriginalBusinessQuery1 OriginalBusinessQueryValue)
        {
            writer.WriteStartElement(null, "OrgnlBizQry", xmlNamespace );
            OriginalBusinessQueryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (QueryName is IsoMax35Text QueryNameValue)
        {
            writer.WriteStartElement(null, "QryNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(QueryNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static MessageHeader7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
