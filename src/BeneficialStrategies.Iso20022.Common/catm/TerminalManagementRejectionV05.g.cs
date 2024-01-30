﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TerminalManagementRejectionV05.  ISO2002 ID# _LFU9MRBgEeqgJK7e3n_EXA.
//
namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// The TerminalManagementRejection message is sent by the terminal manager to reject a message request sent by an acceptor, to indicate that the received message could not be processed.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The TerminalManagementRejection message is sent by the terminal manager to reject a message request sent by an acceptor, to indicate that the received message could not be processed.")]
public partial record TerminalManagementRejectionV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TermnlMgmtRjctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Rejection message management information.
    /// </summary>
    [IsoId("_LFYnkxBgEeqgJK7e3n_EXA")]
    [Description(@"Rejection message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required TMSHeader1 Header { get; init; }
    
    /// <summary>
    /// Information related to the reject.
    /// </summary>
    [IsoId("_LFYnlRBgEeqgJK7e3n_EXA")]
    [Description(@"Information related to the reject.")]
    [DataMember(Name="Rjct")]
    [XmlElement(ElementName="Rjct")]
    [Required]
    public required AcceptorRejection3 Reject { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TerminalManagementRejectionV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TerminalManagementRejectionV05Document ToDocument()
    {
        return new TerminalManagementRejectionV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TerminalManagementRejectionV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TerminalManagementRejectionV05Document : IOuterDocument<TerminalManagementRejectionV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.004.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TerminalManagementRejectionV05"/> is required.
    /// </summary>
    public required TerminalManagementRejectionV05 Message { get; init; }
}
