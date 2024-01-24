﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CurrencyControlRequestOrLetterV02.  ISO2002 ID# _bf9R-22PEei3KuUgpx7Xcw.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The CurrencyControlRequestOrLetter message is sent by the reporting party (respectively the registration agent) to the registration agent (respectively the reporting party) to send a currency control related letter or to request for supporting documents.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CurrencyControlRequestOrLetter message is sent by the reporting party (respectively the registration agent) to the registration agent (respectively the reporting party) to send a currency control related letter or to request for supporting documents.")]
public partial record CurrencyControlRequestOrLetterV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CcyCtrlReqOrLttr";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Characteristics shared by all individual items included in the message.
    /// </summary>
    [IsoId("_bf9R_W2PEei3KuUgpx7Xcw")]
    [Description(@"Characteristics shared by all individual items included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required SomeGroupHeaderRecord GroupHeader { get; init; }
    
    /// <summary>
    /// Supporting document request or letter details.
    /// </summary>
    [IsoId("_bf9R_22PEei3KuUgpx7Xcw")]
    [Description(@"Supporting document request or letter details.")]
    [DataMember(Name="ReqOrLttr")]
    [XmlElement(ElementName="ReqOrLttr")]
    [Required]
    public required SomeRequestOrLetterRecord RequestOrLetter { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bf9SAW2PEei3KuUgpx7Xcw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CurrencyControlRequestOrLetterV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CurrencyControlRequestOrLetterV02Document ToDocument()
    {
        return new CurrencyControlRequestOrLetterV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CurrencyControlRequestOrLetterV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CurrencyControlRequestOrLetterV02Document : IOuterDocument<CurrencyControlRequestOrLetterV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.026.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CurrencyControlRequestOrLetterV02"/> is required.
    /// </summary>
    public required CurrencyControlRequestOrLetterV02 Message { get; init; }
}
