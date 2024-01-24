﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for InvoiceAssignmentAcknowledgementV01.  ISO2002 ID# _OTgzNDk4-AOSNFX-8224507.
//
namespace BeneficialStrategies.Iso20022.tsin;

/// <summary>
/// The InvoiceAssignmentAcknowledgement message is sent from a trade partner to communicate the status of payment obligations related to financial items. The message can be sent independently or as a response to an InvoiceAssignmentNotification message.
/// Depending on legal contexts the message may be required as a response to an InvoiceAssignmentNotification message in order for the assignment to become effective.
/// The trade party may include references to the corresponding items of an InvoiceAssignmentRequest, InvoiceAssignmentStatus or InvoiceAssignmentNotification or other messages and may include referenced data.
/// The message can carry digital signatures if required by context.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The InvoiceAssignmentAcknowledgement message is sent from a trade partner to communicate the status of payment obligations related to financial items. The message can be sent independently or as a response to an InvoiceAssignmentNotification message.|Depending on legal contexts the message may be required as a response to an InvoiceAssignmentNotification message in order for the assignment to become effective.|The trade party may include references to the corresponding items of an InvoiceAssignmentRequest, InvoiceAssignmentStatus or InvoiceAssignmentNotification or other messages and may include referenced data.|The message can carry digital signatures if required by context.")]
public partial record InvoiceAssignmentAcknowledgementV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcAssgnmtAck";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="InvoiceAssignmentAcknowledgementV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public InvoiceAssignmentAcknowledgementV01Document ToDocument()
    {
        return new InvoiceAssignmentAcknowledgementV01Document { Message = this };
    }
}

/// <summary>
/// The InvoiceAssignmentAcknowledgement message is sent from a trade partner to communicate the status of payment obligations related to financial items. The message can be sent independently or as a response to an InvoiceAssignmentNotification message.
/// Depending on legal contexts the message may be required as a response to an InvoiceAssignmentNotification message in order for the assignment to become effective.
/// The trade party may include references to the corresponding items of an InvoiceAssignmentRequest, InvoiceAssignmentStatus or InvoiceAssignmentNotification or other messages and may include referenced data.
/// The message can carry digital signatures if required by context.
/// This is the outer document that contains <seealso cref="InvoiceAssignmentAcknowledgementV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record InvoiceAssignmentAcknowledgementV01Document : IOuterDocument<InvoiceAssignmentAcknowledgementV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.013.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="InvoiceAssignmentAcknowledgementV01"/> is required.
    /// </summary>
    public required InvoiceAssignmentAcknowledgementV01 Message { get; init; }
}
