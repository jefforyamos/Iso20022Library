﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAISSD1V03.  ISO2002 ID# _b_h_X-aHEei5aPS232E3Mw.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCAISSD1 message extends ISO Corporate Action Instruction Status Advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCAISSD1 message extends ISO Corporate Action Instruction Status Advice message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAISSD1V03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAISSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Supplementary data extending corporate action reorganisation instruction status message with corporate action elements not covered in the standard message.
    /// </summary>
    [IsoId("_b_h_YeaHEei5aPS232E3Mw")]
    [Description(@"Supplementary data extending corporate action reorganisation instruction status message with corporate action elements not covered in the standard message.")]
    [DataMember(Name="ReorgInstrDtls")]
    [XmlElement(ElementName="ReorgInstrDtls")]
    public SomeReorganisationInstructionDetailsRecord? ReorganisationInstructionDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAISSD1V03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAISSD1V03Document ToDocument()
    {
        return new DTCCCAISSD1V03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCAISSD1V03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCAISSD1V03Document : IOuterDocument<DTCCCAISSD1V03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.030.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAISSD1V03"/> is required.
    /// </summary>
    public required DTCCCAISSD1V03 Message { get; init; }
}
