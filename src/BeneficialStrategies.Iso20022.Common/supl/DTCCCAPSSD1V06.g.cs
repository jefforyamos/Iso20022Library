﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAPSSD1V06.  ISO2002 ID# _LAGydb5MEeexmbB7KsjCwA.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCAPSSD1 message extends ISO corporate action event processing status advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCAPSSD1 message extends ISO corporate action event processing status advice message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAPSSD1V06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAPSSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Extension block for the information to be extended as corporate action general information.
    /// </summary>
    [IsoId("_LAGyd75MEeexmbB7KsjCwA")]
    [Description(@"Extension block for the information to be extended as corporate action general information.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD31? CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_LAGyf75MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to corporate action details.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateActionSD19? CorporateActionDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAPSSD1V06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAPSSD1V06Document ToDocument()
    {
        return new DTCCCAPSSD1V06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCAPSSD1V06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCAPSSD1V06Document : IOuterDocument<DTCCCAPSSD1V06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.010.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAPSSD1V06"/> is required.
    /// </summary>
    public required DTCCCAPSSD1V06 Message { get; init; }
}
