﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAICSD1V01.  ISO2002 ID# _b8UwkL5OEeexmbB7KsjCwA.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.supl.DTCCCAICSD1V01>;

namespace BeneficialStrategies.Iso20022.supl;


/// <summary>
/// This record is an implementation of the supl.032.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCAICSD1 message extends ISO corporate action Instruction Cancellation Request (CAIC) message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[Description(@"The DTCCCAICSD1 message extends ISO corporate action Instruction Cancellation Request (CAIC) message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAICSD1V01 : IOuterRecord<DTCCCAICSD1V01,DTCCCAICSD1V01Document>
    ,IIsoXmlSerilizable<DTCCCAICSD1V01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.032.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAICSD1";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DTCCCAICSD1V01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Supplementary data extending corporate action instruction cancellation request message with corporate action reorganisation elements not covered in the standard message.
    /// </summary>
    [IsoId("_fcQ_wMYxEeesocHIuVGr7g")]
    [Description(@"Supplementary data extending corporate action instruction cancellation request message with corporate action reorganisation elements not covered in the standard message.")]
    [DataMember(Name="ReorgInstrCxlDtls")]
    [XmlElement(ElementName="ReorgInstrCxlDtls")]
    public required ValueList<ReorganisationInstructionDetailsSD3> ReorganisationInstructionCancellationDetails { get; init; } = []; // Min=0, Max=12
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAICSD1V01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAICSD1V01Document ToDocument()
    {
        return new DTCCCAICSD1V01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("DTCCCAICSD1");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "ReorgInstrCxlDtls", xmlNamespace );
        ReorganisationInstructionCancellationDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static DTCCCAICSD1V01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCAICSD1V01"/>.
/// </summary>
[Serializable]
public partial record DTCCCAICSD1V01Document : IOuterDocument<DTCCCAICSD1V01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.032.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAICSD1V01"/> is required.
    /// </summary>
    [DataMember(Name=DTCCCAICSD1V01.XmlTag)]
    public required DTCCCAICSD1V01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(DTCCCAICSD1V01.XmlTag);
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
