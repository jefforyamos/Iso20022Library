﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalGroupInformation22.  ISO2002 ID# _Pkwzl9p-Ed-ak6NoX_4Aeg_-554618475.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original group, to which the message refers.
/// </summary>
public partial record OriginalGroupInformation22
     : IIsoXmlSerilizable<OriginalGroupInformation22>
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    /// <summary>
    /// Set of elements used to provide detailed information on the reversal reason.
    /// </summary>
    public ReversalReasonInformation6? ReversalReasonInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "OrgnlMsgId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalMessageIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OrgnlMsgNmId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalMessageNameIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (OriginalCreationDateTime is IsoISODateTime OriginalCreationDateTimeValue)
        {
            writer.WriteStartElement(null, "OrgnlCreDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(OriginalCreationDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (ReversalReasonInformation is ReversalReasonInformation6 ReversalReasonInformationValue)
        {
            writer.WriteStartElement(null, "RvslRsnInf", xmlNamespace );
            ReversalReasonInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static OriginalGroupInformation22 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
