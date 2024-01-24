﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ExtendOrPayRequestV01.  ISO2002 ID# _9hNGQnltEeG7BsjMvd1mEw_-1297539311.
//
namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// The ExtendOrPayRequest message is sent by the party that issued the undertaking to the party that requested issuance of the undertaking (applicant or obligor), to request the applicant's response to a beneficiary request to extend or pay.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ExtendOrPayRequest message is sent by the party that issued the undertaking to the party that requested issuance of the undertaking (applicant or obligor), to request the applicant's response to a beneficiary request to extend or pay.")]
public partial record ExtendOrPayRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "XtndOrPayReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ExtendOrPayRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ExtendOrPayRequestV01Document ToDocument()
    {
        return new ExtendOrPayRequestV01Document { Message = this };
    }
}

/// <summary>
/// The ExtendOrPayRequest message is sent by the party that issued the undertaking to the party that requested issuance of the undertaking (applicant or obligor), to request the applicant's response to a beneficiary request to extend or pay.
/// This is the outer document that contains <seealso cref="ExtendOrPayRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ExtendOrPayRequestV01Document : IOuterDocument<ExtendOrPayRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.014.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ExtendOrPayRequestV01"/> is required.
    /// </summary>
    public required ExtendOrPayRequestV01 Message { get; init; }
}
