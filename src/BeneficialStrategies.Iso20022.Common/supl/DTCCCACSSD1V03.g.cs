﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCACSSD1V03.  ISO2002 ID# _myaAh1B5Ee2KGNXAcFL5RA.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.supl.DTCCCACSSD1V03>;

namespace BeneficialStrategies.Iso20022.supl;


/// <summary>
/// This record is an implementation of the supl.033.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCACSSD1 message extends ISO corporate action Instruction Cancellation Request Status Advice (CACS) message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[Description(@"The DTCCCACSSD1 message extends ISO corporate action Instruction Cancellation Request Status Advice (CACS) message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCACSSD1V03 : IOuterRecord<DTCCCACSSD1V03,DTCCCACSSD1V03Document>
    ,IIsoXmlSerilizable<DTCCCACSSD1V03>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.033.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACSSD1";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DTCCCACSSD1V03Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Supplementary data extending corporate action instruction cancellation request status advice message with corporate action reorganisation elements not covered in the standard message.
    /// </summary>
    [IsoId("_myaAiVB5Ee2KGNXAcFL5RA")]
    [Description(@"Supplementary data extending corporate action instruction cancellation request status advice message with corporate action reorganisation elements not covered in the standard message.")]
    [DataMember(Name="ReorgInstrCxlDtls")]
    [XmlElement(ElementName="ReorgInstrCxlDtls")]
    public ReorganisationInstructionSD14? ReorganisationInstructionCancellationDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCACSSD1V03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCACSSD1V03Document ToDocument()
    {
        return new DTCCCACSSD1V03Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("DTCCCACSSD1");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (ReorganisationInstructionCancellationDetails is ReorganisationInstructionSD14 ReorganisationInstructionCancellationDetailsValue)
        {
            writer.WriteStartElement(null, "ReorgInstrCxlDtls", xmlNamespace );
            ReorganisationInstructionCancellationDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DTCCCACSSD1V03 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCACSSD1V03"/>.
/// </summary>
[Serializable]
public partial record DTCCCACSSD1V03Document : IOuterDocument<DTCCCACSSD1V03>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.033.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCACSSD1V03"/> is required.
    /// </summary>
    [DataMember(Name=DTCCCACSSD1V03.XmlTag)]
    public required DTCCCACSSD1V03 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(DTCCCACSSD1V03.XmlTag);
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
