﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestForTransferStatusReportV05.  ISO2002 ID# _H02-IR8OEeWpZde3LQh6dg.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the RequestForTransferStatusReport to the executing party, for example, a transfer agent to request the status of a previously instructed transfer.
/// Usage
/// The RequestForTransferStatusReport is used to request either:
/// - the status of one or several transfer instructions or,
/// - the status of one or several transfer cancellation instructions.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An instructing party, for example, an investment manager or its authorised representative, sends the RequestForTransferStatusReport to the executing party, for example, a transfer agent to request the status of a previously instructed transfer.|Usage|The RequestForTransferStatusReport is used to request either:|- the status of one or several transfer instructions or,|- the status of one or several transfer cancellation instructions.")]
public partial record RequestForTransferStatusReportV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqForTrfStsRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_H02-Ix8OEeWpZde3LQh6dg")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Information to identify the transfer for which the status is requested.|.
    /// </summary>
    [IsoId("_H02-JR8OEeWpZde3LQh6dg")]
    [Description(@"Information to identify the transfer for which the status is requested.|.")]
    [DataMember(Name="ReqDtls")]
    [XmlElement(ElementName="ReqDtls")]
    [Required]
    public required MessageAndBusinessReference8 RequestDetails { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_H02-Jx8OEeWpZde3LQh6dg")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_H02-KR8OEeWpZde3LQh6dg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RequestForTransferStatusReportV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestForTransferStatusReportV05Document ToDocument()
    {
        return new RequestForTransferStatusReportV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RequestForTransferStatusReportV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RequestForTransferStatusReportV05Document : IOuterDocument<RequestForTransferStatusReportV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.009.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RequestForTransferStatusReportV05"/> is required.
    /// </summary>
    public required RequestForTransferStatusReportV05 Message { get; init; }
}
