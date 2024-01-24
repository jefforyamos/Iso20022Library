﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for UndertakingAmendmentResponseV01.  ISO2002 ID# _9iGeInltEeG7BsjMvd1mEw_-1174691593.
//
namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// The UndertakingAmendmentResponse message is sent by the beneficiary to the party that issued the undertaking, either directly or via one or more advising parties, to indicate acceptance or rejection by the beneficiary of the amendment.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The UndertakingAmendmentResponse message is sent by the beneficiary to the party that issued the undertaking, either directly or via one or more advising parties, to indicate acceptance or rejection by the beneficiary of the amendment.")]
public partial record UndertakingAmendmentResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgAmdmntRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Details related to the proposed amendment response.
    /// </summary>
    [IsoId("_9iGeI3ltEeG7BsjMvd1mEw_1688211765")]
    [Description(@"Details related to the proposed amendment response.")]
    [DataMember(Name="UdrtkgAmdmntRspnDtls")]
    [XmlElement(ElementName="UdrtkgAmdmntRspnDtls")]
    [Required]
    public required SomeUndertakingAmendmentResponseDetailsRecord UndertakingAmendmentResponseDetails { get; init; }
    
    /// <summary>
    /// Digital signature of the response.
    /// </summary>
    [IsoId("_9iGeJHltEeG7BsjMvd1mEw_-106555432")]
    [Description(@"Digital signature of the response.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public SomeDigitalSignatureRecord? DigitalSignature { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="UndertakingAmendmentResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public UndertakingAmendmentResponseV01Document ToDocument()
    {
        return new UndertakingAmendmentResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="UndertakingAmendmentResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record UndertakingAmendmentResponseV01Document : IOuterDocument<UndertakingAmendmentResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.008.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="UndertakingAmendmentResponseV01"/> is required.
    /// </summary>
    public required UndertakingAmendmentResponseV01 Message { get; init; }
}
