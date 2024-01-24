﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PartyRegistrationAndGuaranteeRequestV01.  ISO2002 ID# _OTgzNDYz-AOSNFX-8224506.
//
namespace BeneficialStrategies.Iso20022.tsin;

/// <summary>
/// The message PartyRegistrationAndGuaranteeRequest is sent by a factoring client either to a financial service or a guarantee issuer. The message can also be sent from a financial service to a guarantee issuer. Furthermore, the message can be sent to an interested party for example a fiscal authority. When the message is sent to a guarantee issuer, the factoring client or financial service provider requests a guarantee for the factoring agreement concerning the indicated trade party. When the message is sent to a financial service, the financial client requests an agreement to execute assignments of financial items. The financial client may request the guarantee amount to be obtained in case of insolvency of the trade partner for a corresponding account receivable directly from the financial service. Alternatively and depending on the contractual and product definition, the financial client may be required to include a copy of a guarantee status received from a guarantee issuer.
/// The message can carry digital signatures if required by context.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The message PartyRegistrationAndGuaranteeRequest is sent by a factoring client either to a financial service or a guarantee issuer. The message can also be sent from a financial service to a guarantee issuer. Furthermore, the message can be sent to an interested party for example a fiscal authority. When the message is sent to a guarantee issuer, the factoring client or financial service provider requests a guarantee for the factoring agreement concerning the indicated trade party. When the message is sent to a financial service, the financial client requests an agreement to execute assignments of financial items. The financial client may request the guarantee amount to be obtained in case of insolvency of the trade partner for a corresponding account receivable directly from the financial service. Alternatively and depending on the contractual and product definition, the financial client may be required to include a copy of a guarantee status received from a guarantee issuer.|The message can carry digital signatures if required by context.")]
public partial record PartyRegistrationAndGuaranteeRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyRegnAndGrntReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics that unambiguously identify the request, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNDY0-AOSNFX-8224506")]
    [Description(@"Set of characteristics that unambiguously identify the request, common parameters, documents and identifications.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// List of agreements.
    /// </summary>
    [IsoId("_OTgzNDY1-AOSNFX-8224506")]
    [Description(@"List of agreements.")]
    [DataMember(Name="AgrmtList")]
    [XmlElement(ElementName="AgrmtList")]
    [Required]
    public required SomeAgreementListRecord AgreementList { get; init; }
    
    /// <summary>
    /// Number of agreement lists as control value.
    /// </summary>
    [IsoId("_OTgzNDY2-AOSNFX-8224506")]
    [Description(@"Number of agreement lists as control value.")]
    [DataMember(Name="AgrmtCnt")]
    [XmlElement(ElementName="AgrmtCnt")]
    public SomeAgreementCountRecord? AgreementCount { get; init; }
    
    /// <summary>
    /// Total number of individual items in all lists.
    /// </summary>
    [IsoId("_OTgzNDY3-AOSNFX-8224506")]
    [Description(@"Total number of individual items in all lists.")]
    [DataMember(Name="ItmCnt")]
    [XmlElement(ElementName="ItmCnt")]
    public SomeItemCountRecord? ItemCount { get; init; }
    
    /// <summary>
    /// Total of all individual amounts included in all lists, irrespective of currencies or direction.
    /// </summary>
    [IsoId("_OTgzNDY4-AOSNFX-8224506")]
    [Description(@"Total of all individual amounts included in all lists, irrespective of currencies or direction.")]
    [DataMember(Name="CtrlSum")]
    [XmlElement(ElementName="CtrlSum")]
    public SomeControlSumRecord? ControlSum { get; init; }
    
    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNDY5-AOSNFX-8224506")]
    [Description(@"Referenced or related business message.")]
    [DataMember(Name="AttchdMsg")]
    [XmlElement(ElementName="AttchdMsg")]
    public SomeAttachedMessageRecord? AttachedMessage { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PartyRegistrationAndGuaranteeRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PartyRegistrationAndGuaranteeRequestV01Document ToDocument()
    {
        return new PartyRegistrationAndGuaranteeRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PartyRegistrationAndGuaranteeRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PartyRegistrationAndGuaranteeRequestV01Document : IOuterDocument<PartyRegistrationAndGuaranteeRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.009.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PartyRegistrationAndGuaranteeRequestV01"/> is required.
    /// </summary>
    public required PartyRegistrationAndGuaranteeRequestV01 Message { get; init; }
}
