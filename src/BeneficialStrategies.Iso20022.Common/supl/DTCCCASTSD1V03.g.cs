﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCASTSD1V03.  ISO2002 ID# _b_h_Y-aHEei5aPS232E3Mw.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCASTSD1 message extends ISO Corporate Action Instruction Statement Report message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCASTSD1 message extends ISO Corporate Action Instruction Statement Report message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCASTSD1V03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCASTSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCASTSD1V03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCASTSD1V03Document ToDocument()
    {
        return new DTCCCASTSD1V03Document { Message = this };
    }
}

/// <summary>
/// The DTCCCASTSD1 message extends ISO Corporate Action Instruction Statement Report message with DTCC corporate action elements not covered in the standard message.
/// This is the outer document that contains <seealso cref="DTCCCASTSD1V03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCASTSD1V03Document : IOuterDocument<DTCCCASTSD1V03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.031.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCASTSD1V03"/> is required.
    /// </summary>
    public required DTCCCASTSD1V03 Message { get; init; }
}
