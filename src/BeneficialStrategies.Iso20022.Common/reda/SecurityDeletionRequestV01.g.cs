﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecurityDeletionRequestV01.  ISO2002 ID# _jTumsR62Eeu31YsWNiv_cw.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// SCOPE
/// An instructing party sends a SecurityDeletionRequest message to an executing/servicing party to advice the complete removal of a financial instrument entry from their system.
/// The instructing party - executing/servicing party relationship may be:
/// - Central Securities Depositories (CSD) who would like to publish security static data, or 
/// - a Corporate, or
/// - a Bank, or
/// - a Market Infrastructure, or 
/// - a Market Data Provider.
/// USAGE
/// The request is sent when the instructing party identified that a security is wrongly created in the securities coverage of the executing/servicing party. The instructing party needs this security to be removed from the executing /servicing party database. 
/// This message can be used when a security identification code was issued too quickly or if a security identification code needs to be reused (for example, in case of money market instrument). The result of this message is a complete removal of the security identification from the executing/servicing party's database.
/// Initiator: instructing party.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"SCOPE|An instructing party sends a SecurityDeletionRequest message to an executing/servicing party to advice the complete removal of a financial instrument entry from their system.||The instructing party - executing/servicing party relationship may be:|- Central Securities Depositories (CSD) who would like to publish security static data, or |- a Corporate, or|- a Bank, or|- a Market Infrastructure, or |- a Market Data Provider.||USAGE|The request is sent when the instructing party identified that a security is wrongly created in the securities coverage of the executing/servicing party. The instructing party needs this security to be removed from the executing /servicing party database. |This message can be used when a security identification code was issued too quickly or if a security identification code needs to be reused (for example, in case of money market instrument). The result of this message is a complete removal of the security identification from the executing/servicing party's database.||Initiator: instructing party.")]
public partial record SecurityDeletionRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctyDeltnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_NYafgZIxEeuAlLVx8pyt3w")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    public SomeMessageHeaderRecord? MessageHeader { get; init; }
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_jTumvx62Eeu31YsWNiv_cw")]
    [Description(@"Identification of the financial instrument.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SomeFinancialInstrumentIdentificationRecord FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jTumxR62Eeu31YsWNiv_cw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecurityDeletionRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecurityDeletionRequestV01Document ToDocument()
    {
        return new SecurityDeletionRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecurityDeletionRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecurityDeletionRequestV01Document : IOuterDocument<SecurityDeletionRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.013.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecurityDeletionRequestV01"/> is required.
    /// </summary>
    public required SecurityDeletionRequestV01 Message { get; init; }
}
