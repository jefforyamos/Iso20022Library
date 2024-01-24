﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCACNSD1V10.  ISO2002 ID# _q_pKaQ4zEeuIpNw_GxsBOw.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCACNSD1 message extends ISO corporate action cancellation advice (CACN) message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCACNSD1 message extends ISO corporate action cancellation advice (CACN) message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCACNSD1V10 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACNSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCACNSD1V10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCACNSD1V10Document ToDocument()
    {
        return new DTCCCACNSD1V10Document { Message = this };
    }
}

/// <summary>
/// The DTCCCACNSD1 message extends ISO corporate action cancellation advice (CACN) message with DTCC corporate action elements not covered in the standard message.
/// This is the outer document that contains <seealso cref="DTCCCACNSD1V10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCACNSD1V10Document : IOuterDocument<DTCCCACNSD1V10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.006.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCACNSD1V10"/> is required.
    /// </summary>
    public required DTCCCACNSD1V10 Message { get; init; }
}
