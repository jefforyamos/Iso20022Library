﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAISSD1V07.  ISO2002 ID# _myaAeVB5Ee2KGNXAcFL5RA.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.supl.DTCCCAISSD1V07>;

namespace BeneficialStrategies.Iso20022.supl;


/// <summary>
/// This record is an implementation of the supl.030.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCAISSD1 message extends ISO corporate action instruction status advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[Description(@"The DTCCCAISSD1 message extends ISO corporate action instruction status advice message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAISSD1V07 : IOuterRecord<DTCCCAISSD1V07,DTCCCAISSD1V07Document>
    ,IIsoXmlSerilizable<DTCCCAISSD1V07>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.030.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAISSD1";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DTCCCAISSD1V07Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Information to be extended as supplementary data to instruction status message for reorganisation events.
    /// </summary>
    [IsoId("_myaAe1B5Ee2KGNXAcFL5RA")]
    [Description(@"Information to be extended as supplementary data to instruction status message for reorganisation events.")]
    [DataMember(Name="ReorgInstrDtls")]
    [XmlElement(ElementName="ReorgInstrDtls")]
    public ReorganisationInstructionSD12? ReorganisationInstructionDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to instruction status message for distribution events.
    /// </summary>
    [IsoId("_O1nlIFB7Ee2KGNXAcFL5RA")]
    [Description(@"Information to be extended as supplementary data to instruction status message for distribution events.")]
    [DataMember(Name="DstrbtnInstrDtls")]
    [XmlElement(ElementName="DstrbtnInstrDtls")]
    public DistributionInstructionSD1? DistributionInstructionDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAISSD1V07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAISSD1V07Document ToDocument()
    {
        return new DTCCCAISSD1V07Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("DTCCCAISSD1");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (ReorganisationInstructionDetails is ReorganisationInstructionSD12 ReorganisationInstructionDetailsValue)
        {
            writer.WriteStartElement(null, "ReorgInstrDtls", xmlNamespace );
            ReorganisationInstructionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DistributionInstructionDetails is DistributionInstructionSD1 DistributionInstructionDetailsValue)
        {
            writer.WriteStartElement(null, "DstrbtnInstrDtls", xmlNamespace );
            DistributionInstructionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DTCCCAISSD1V07 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCAISSD1V07"/>.
/// </summary>
[Serializable]
public partial record DTCCCAISSD1V07Document : IOuterDocument<DTCCCAISSD1V07>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.030.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAISSD1V07"/> is required.
    /// </summary>
    [DataMember(Name=DTCCCAISSD1V07.XmlTag)]
    public required DTCCCAISSD1V07 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(DTCCCAISSD1V07.XmlTag);
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
