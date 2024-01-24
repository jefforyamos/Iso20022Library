﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAPSSD1V05.  ISO2002 ID# _I7vsoZCEEeaSk9d1hvTrHg.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCAPSSD1 message extends ISO corporate action event processing status advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCAPSSD1 message extends ISO corporate action event processing status advice message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAPSSD1V05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAPSSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAPSSD1V05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAPSSD1V05Document ToDocument()
    {
        return new DTCCCAPSSD1V05Document { Message = this };
    }
}

/// <summary>
/// The DTCCCAPSSD1 message extends ISO corporate action event processing status advice message with DTCC corporate action elements not covered in the standard message.
/// This is the outer document that contains <seealso cref="DTCCCAPSSD1V05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCAPSSD1V05Document : IOuterDocument<DTCCCAPSSD1V05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.010.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAPSSD1V05"/> is required.
    /// </summary>
    public required DTCCCAPSSD1V05 Message { get; init; }
}
