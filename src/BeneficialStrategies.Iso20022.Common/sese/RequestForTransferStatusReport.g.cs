﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestForTransferStatusReport.  ISO2002 ID# _nnEjSNE5Ed-BzquC8wXy7w_-788060154.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// The RequestForTransferStatusReport is sent by an instructing party to the executing party.
/// This message requests the status of a transfer instruction or the status of a transfer cancellation instruction.
/// Usage
/// The RequestForTransferStatusReport is sent by an instructing party to the executing party to request
/// - the status of one or several transfer instructions or
/// - the status of one or several transfer cancellation instructions.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The RequestForTransferStatusReport is sent by an instructing party to the executing party.|This message requests the status of a transfer instruction or the status of a transfer cancellation instruction.|Usage|The RequestForTransferStatusReport is sent by an instructing party to the executing party to request|- the status of one or several transfer instructions or|- the status of one or several transfer cancellation instructions.")]
public partial record RequestForTransferStatusReport : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "sese.009.001.01";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information to identify the transfer for which the status is requested.|.
    /// </summary>
    [IsoId("_nnEjSdE5Ed-BzquC8wXy7w_-359483453")]
    [Description(@"Information to identify the transfer for which the status is requested.|.")]
    [DataMember(Name="ReqDtls")]
    [XmlElement(ElementName="ReqDtls")]
    [Required]
    public required MessageAndBusinessReference1 RequestDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RequestForTransferStatusReportDocument"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestForTransferStatusReportDocument ToDocument()
    {
        return new RequestForTransferStatusReportDocument { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RequestForTransferStatusReport"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RequestForTransferStatusReportDocument : IOuterDocument<RequestForTransferStatusReport>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.009.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RequestForTransferStatusReport"/> is required.
    /// </summary>
    public required RequestForTransferStatusReport Message { get; init; }
}
