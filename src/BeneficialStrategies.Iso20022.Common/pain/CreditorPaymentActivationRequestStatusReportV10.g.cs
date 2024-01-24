﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CreditorPaymentActivationRequestStatusReportV10.  ISO2002 ID# _qzYDUQLFEe2X55dNQNVKfg.
//
namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// The CreditorPaymentActivationRequestStatusReport message is sent by a party to the next party in the creditor payment activation request chain. It is used to inform the latter about the positive or negative status of a creditor payment activation request (either single or file).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CreditorPaymentActivationRequestStatusReport message is sent by a party to the next party in the creditor payment activation request chain. It is used to inform the latter about the positive or negative status of a creditor payment activation request (either single or file).")]
public partial record CreditorPaymentActivationRequestStatusReportV10 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CdtrPmtActvtnReqStsRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CreditorPaymentActivationRequestStatusReportV10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CreditorPaymentActivationRequestStatusReportV10Document ToDocument()
    {
        return new CreditorPaymentActivationRequestStatusReportV10Document { Message = this };
    }
}

/// <summary>
/// The CreditorPaymentActivationRequestStatusReport message is sent by a party to the next party in the creditor payment activation request chain. It is used to inform the latter about the positive or negative status of a creditor payment activation request (either single or file).
/// This is the outer document that contains <seealso cref="CreditorPaymentActivationRequestStatusReportV10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CreditorPaymentActivationRequestStatusReportV10Document : IOuterDocument<CreditorPaymentActivationRequestStatusReportV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.014.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CreditorPaymentActivationRequestStatusReportV10"/> is required.
    /// </summary>
    public required CreditorPaymentActivationRequestStatusReportV10 Message { get; init; }
}
