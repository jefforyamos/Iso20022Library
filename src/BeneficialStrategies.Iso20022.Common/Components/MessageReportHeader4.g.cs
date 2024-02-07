﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MessageReportHeader4.  ISO2002 ID# _CLY7kdGdEeaQk737TH1Fzw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of many status advice reports where many received reports are reported at once.
/// </summary>
public partial record MessageReportHeader4
     : IIsoXmlSerilizable<MessageReportHeader4>
{
    #nullable enable
    
    /// <summary>
    /// Provide detail on previously received message reports that are being reported as part of this status advice.
    /// Usage:
    /// When required, this field will be populated with the BAH Business Message Identifier field. Where only a single message report header is used, this field is not used and relies solely on the BAH Business Message Identifier field.
    /// </summary>
    public IsoMax140Text? MessageReportIdentifier { get; init; } 
    /// <summary>
    /// Details the status of the whole message that has been received.
    /// </summary>
    public StatusAdviceReport3? MessageStatus { get; init; } 
    /// <summary>
    /// Provides per record status on the report that has been received.
    /// </summary>
    public StatusReportRecord3? RecordStatus { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
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
        if (MessageReportIdentifier is IsoMax140Text MessageReportIdentifierValue)
        {
            writer.WriteStartElement(null, "MsgRptIdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(MessageReportIdentifierValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (MessageStatus is StatusAdviceReport3 MessageStatusValue)
        {
            writer.WriteStartElement(null, "MsgSts", xmlNamespace );
            MessageStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RecordStatus is StatusReportRecord3 RecordStatusValue)
        {
            writer.WriteStartElement(null, "RcrdSts", xmlNamespace );
            RecordStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MessageReportHeader4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
