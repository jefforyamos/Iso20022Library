﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestToPayDebtorActivationAmendmentRequestV01.  ISO2002 ID# _rNNBueHzEeqbls7Gk4-ckA.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// The RequestToPayDebtorActivationAmendmentRequest message is sent by the debtor RTP (Request To Pay) provider to the creditor RTP provider and optionally from the debtor to its RTP provider and from the creditor RTP provider to the creditor to request for the amendment of the debtor activation of the RTP service with that specific creditor.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The RequestToPayDebtorActivationAmendmentRequest message is sent by the debtor RTP (Request To Pay) provider to the creditor RTP provider and optionally from the debtor to its RTP provider and from the creditor RTP provider to the creditor to request for the amendment of the debtor activation of the RTP service with that specific creditor.")]
public partial record RequestToPayDebtorActivationAmendmentRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqToPayDbtrActvtnAmdmntReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the amendment of the mandate, but which are not part of the mandate.
    /// </summary>
    [IsoId("_rNNBveHzEeqbls7Gk4-ckA")]
    [Description(@"Set of characteristics to identify the message and parties playing a role in the amendment of the mandate, but which are not part of the mandate.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Provides details on the amendment of a debtor activation request.
    /// </summary>
    [IsoId("_rNNBv-HzEeqbls7Gk4-ckA")]
    [Description(@"Provides details on the amendment of a debtor activation request.")]
    [DataMember(Name="AmdmntData")]
    [XmlElement(ElementName="AmdmntData")]
    [Required]
    public required SomeAmendmentDataRecord AmendmentData { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rNNBweHzEeqbls7Gk4-ckA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RequestToPayDebtorActivationAmendmentRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestToPayDebtorActivationAmendmentRequestV01Document ToDocument()
    {
        return new RequestToPayDebtorActivationAmendmentRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RequestToPayDebtorActivationAmendmentRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RequestToPayDebtorActivationAmendmentRequestV01Document : IOuterDocument<RequestToPayDebtorActivationAmendmentRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.071.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RequestToPayDebtorActivationAmendmentRequestV01"/> is required.
    /// </summary>
    public required RequestToPayDebtorActivationAmendmentRequestV01 Message { get; init; }
}
