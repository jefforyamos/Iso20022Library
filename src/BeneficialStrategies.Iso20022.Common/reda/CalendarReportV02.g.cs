﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CalendarReportV02.  ISO2002 ID# _DRJNLFuDEe29lKnE5APnfA.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.reda.CalendarReportV02>;

namespace BeneficialStrategies.Iso20022.reda;


/// <summary>
/// This record is an implementation of the reda.065.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CalendarReport message is sent by the system administrator to the system member is to return information on the system status for specific calendar days.
/// </summary>
[Serializable]
[Description(@"The CalendarReport message is sent by the system administrator to the system member is to return information on the system status for specific calendar days.")]
public partial record CalendarReportV02 : IOuterRecord<CalendarReportV02,CalendarReportV02Document>
    ,IIsoXmlSerilizable<CalendarReportV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.065.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CalRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CalendarReportV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_DRJNL1uDEe29lKnE5APnfA")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader11 MessageHeader { get; init; }
    
    /// <summary>
    /// Reports on the calendar data.
    /// </summary>
    [IsoId("_DRJNLVuDEe29lKnE5APnfA")]
    [Description(@"Reports on the calendar data.")]
    [DataMember(Name="RptOrErr")]
    [XmlElement(ElementName="RptOrErr")]
    [Required]
    public required CalendarReportOrError1Choice_ ReportOrError { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DRJNLluDEe29lKnE5APnfA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CalendarReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CalendarReportV02Document ToDocument()
    {
        return new CalendarReportV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CalRpt");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MsgHdr", xmlNamespace );
        MessageHeader.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RptOrErr", xmlNamespace );
        ReportOrError.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CalendarReportV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CalendarReportV02"/>.
/// </summary>
[Serializable]
public partial record CalendarReportV02Document : IOuterDocument<CalendarReportV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.065.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CalendarReportV02"/> is required.
    /// </summary>
    [DataMember(Name=CalendarReportV02.XmlTag)]
    public required CalendarReportV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(CalendarReportV02.XmlTag);
        Message.Serialize(writer, DocumentNamespace);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
    }
    
    public void ReadXml(XmlReader reader)
    {
        throw new NotImplementedException();
    }
    
    public System.Xml.Schema.XmlSchema GetSchema() => null;
}
