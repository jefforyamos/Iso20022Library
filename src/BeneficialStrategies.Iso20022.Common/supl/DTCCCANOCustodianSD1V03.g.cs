﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCANOCustodianSD1V03.  ISO2002 ID# _1LBwZjL3EeKU9IrkkToqcw_-1345555435.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCANOCustodianSD1 message extends ISO corporate action notification (CANO) message with DTCC validation custodian service specific data elements that are not covered by the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCANOCustodianSD1 message extends ISO corporate action notification (CANO) message with DTCC validation custodian service specific data elements that are not covered by the standard message.")]
public partial record DTCCCANOCustodianSD1V03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOCtdnSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information to be extended as custodian details supplementary data to corporate action notification.
    /// </summary>
    [IsoId("_1LBwZzL3EeKU9IrkkToqcw_764430494")]
    [Description(@"Information to be extended as custodian details supplementary data to corporate action notification.")]
    [DataMember(Name="CtdnDtls")]
    [XmlElement(ElementName="CtdnDtls")]
    public CustodianDetailsSD1? CustodianDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as custodian service supplementary data to option details.
    /// </summary>
    [IsoId("_1LK6UDL3EeKU9IrkkToqcw_780588655")]
    [Description(@"Information to be extended as custodian service supplementary data to option details.")]
    [DataMember(Name="CtdnOptnDtDtls")]
    [XmlElement(ElementName="CtdnOptnDtDtls")]
    public CustodianOptionDateDetailsSD1? CustodianOptionDateDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCANOCustodianSD1V03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCANOCustodianSD1V03Document ToDocument()
    {
        return new DTCCCANOCustodianSD1V03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCANOCustodianSD1V03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCANOCustodianSD1V03Document : IOuterDocument<DTCCCANOCustodianSD1V03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.004.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCANOCustodianSD1V03"/> is required.
    /// </summary>
    public required DTCCCANOCustodianSD1V03 Message { get; init; }
}
