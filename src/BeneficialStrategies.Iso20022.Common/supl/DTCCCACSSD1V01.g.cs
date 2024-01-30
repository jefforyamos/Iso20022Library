﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCACSSD1V01.  ISO2002 ID# _8-GvcL5OEeexmbB7KsjCwA.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCACSSD1 message extends ISO corporate action Instruction Cancellation Request Status Advice (CACS) message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCACSSD1 message extends ISO corporate action Instruction Cancellation Request Status Advice (CACS) message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCACSSD1V01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACSSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Supplementary data extending corporate action instruction cancellation request status advice message with corporate action reorganisation elements not covered in the standard message.
    /// </summary>
    [IsoId("_xPi3UcY1EeesocHIuVGr7g")]
    [Description(@"Supplementary data extending corporate action instruction cancellation request status advice message with corporate action reorganisation elements not covered in the standard message.")]
    [DataMember(Name="ReorgInstrCxlDtls")]
    [XmlElement(ElementName="ReorgInstrCxlDtls")]
    public required IReadonlyCollection<ReorganisationInstructionDetailsSD4> ReorganisationInstructionCancellationDetails { get; init; } // Min=0, Max=12
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCACSSD1V01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCACSSD1V01Document ToDocument()
    {
        return new DTCCCACSSD1V01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCACSSD1V01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCACSSD1V01Document : IOuterDocument<DTCCCACSSD1V01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.033.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCACSSD1V01"/> is required.
    /// </summary>
    public required DTCCCACSSD1V01 Message { get; init; }
}
