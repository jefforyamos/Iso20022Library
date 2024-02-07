﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCASTSD1V04.  ISO2002 ID# _q_pK-Q4zEeuIpNw_GxsBOw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.supl.DTCCCASTSD1V04>;

namespace BeneficialStrategies.Iso20022.supl;


/// <summary>
/// This record is an implementation of the supl.031.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCASTSD1 message extends ISO corporate action instruction statement report message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[Description(@"The DTCCCASTSD1 message extends ISO corporate action instruction statement report message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCASTSD1V04 : IOuterRecord<DTCCCASTSD1V04,DTCCCASTSD1V04Document>
    ,IIsoXmlSerilizable<DTCCCASTSD1V04>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.031.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCASTSD1";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DTCCCASTSD1V04Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details at event level.
    /// </summary>
    [IsoId("_q_pK-w4zEeuIpNw_GxsBOw")]
    [Description(@"Information to be extended as supplementary data to corporate action balance details at event level.")]
    [DataMember(Name="EvtBalDtls")]
    [XmlElement(ElementName="EvtBalDtls")]
    public CorporateActionBalanceSD5? EventBalanceDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details at option level.
    /// </summary>
    [IsoId("_q_pK_Q4zEeuIpNw_GxsBOw")]
    [Description(@"Information to be extended as supplementary data to corporate action balance details at option level.")]
    [DataMember(Name="TtlInstdBalOptnBalDtls")]
    [XmlElement(ElementName="TtlInstdBalOptnBalDtls")]
    public CorporateActionInstructedBalanceOptionBalanceSD3? TotalInstructedBalanceOptionBalanceDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details at option instruction details level. Option level instruction details are referenced by unique instruction identification, instruction date, quantity and status of instruction.
    /// </summary>
    [IsoId("_q_pK_w4zEeuIpNw_GxsBOw")]
    [Description(@"Information to be extended as supplementary data to corporate action balance details at option instruction details level. Option level instruction details are referenced by unique instruction identification, instruction date, quantity and status of instruction.")]
    [DataMember(Name="TtlInstdBalOptnInstrDtls")]
    [XmlElement(ElementName="TtlInstdBalOptnInstrDtls")]
    public CorporateActionInstructedBalanceOptionInstructionSD3? TotalInstructedBalanceOptionInstructionDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details at option protect instruction details level.
    /// </summary>
    [IsoId("_q_pLAQ4zEeuIpNw_GxsBOw")]
    [Description(@"Information to be extended as supplementary data to corporate action balance details at option protect instruction details level.")]
    [DataMember(Name="TtlInstdBalOptnPrtctInstrDtls")]
    [XmlElement(ElementName="TtlInstdBalOptnPrtctInstrDtls")]
    public CorporateActionInstructedBalanceOptionProtectInstructionSD4? TotalInstructedBalanceOptionProtectInstructionDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCASTSD1V04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCASTSD1V04Document ToDocument()
    {
        return new DTCCCASTSD1V04Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("DTCCCASTSD1");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (EventBalanceDetails is CorporateActionBalanceSD5 EventBalanceDetailsValue)
        {
            writer.WriteStartElement(null, "EvtBalDtls", xmlNamespace );
            EventBalanceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalInstructedBalanceOptionBalanceDetails is CorporateActionInstructedBalanceOptionBalanceSD3 TotalInstructedBalanceOptionBalanceDetailsValue)
        {
            writer.WriteStartElement(null, "TtlInstdBalOptnBalDtls", xmlNamespace );
            TotalInstructedBalanceOptionBalanceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalInstructedBalanceOptionInstructionDetails is CorporateActionInstructedBalanceOptionInstructionSD3 TotalInstructedBalanceOptionInstructionDetailsValue)
        {
            writer.WriteStartElement(null, "TtlInstdBalOptnInstrDtls", xmlNamespace );
            TotalInstructedBalanceOptionInstructionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalInstructedBalanceOptionProtectInstructionDetails is CorporateActionInstructedBalanceOptionProtectInstructionSD4 TotalInstructedBalanceOptionProtectInstructionDetailsValue)
        {
            writer.WriteStartElement(null, "TtlInstdBalOptnPrtctInstrDtls", xmlNamespace );
            TotalInstructedBalanceOptionProtectInstructionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DTCCCASTSD1V04 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCASTSD1V04"/>.
/// </summary>
[Serializable]
public partial record DTCCCASTSD1V04Document : IOuterDocument<DTCCCASTSD1V04>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.031.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCASTSD1V04"/> is required.
    /// </summary>
    [DataMember(Name=DTCCCASTSD1V04.XmlTag)]
    public required DTCCCASTSD1V04 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(DTCCCASTSD1V04.XmlTag);
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
