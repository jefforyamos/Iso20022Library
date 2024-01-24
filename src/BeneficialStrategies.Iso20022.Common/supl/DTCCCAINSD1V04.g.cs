﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAINSD1V04.  ISO2002 ID# _LAGyL75MEeexmbB7KsjCwA.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCAINSD1 message extends ISO corporate action instruction message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCAINSD1 message extends ISO corporate action instruction message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAINSD1V04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAINSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAINSD1V04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAINSD1V04Document ToDocument()
    {
        return new DTCCCAINSD1V04Document { Message = this };
    }
}

/// <summary>
/// The DTCCCAINSD1 message extends ISO corporate action instruction message with DTCC corporate action elements not covered in the standard message.
/// This is the outer document that contains <seealso cref="DTCCCAINSD1V04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCAINSD1V04Document : IOuterDocument<DTCCCAINSD1V04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.008.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAINSD1V04"/> is required.
    /// </summary>
    public required DTCCCAINSD1V04 Message { get; init; }
}
