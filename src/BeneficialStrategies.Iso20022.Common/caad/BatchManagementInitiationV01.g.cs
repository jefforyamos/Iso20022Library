﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BatchManagementInitiationV01.  ISO2002 ID# _CcEcRVW9EeeiG_nL4vgKnQ.
//
namespace BeneficialStrategies.Iso20022.caad;

/// <summary>
/// The BatchManagementInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer) connected to a network.
/// This message provides flow control information enabling a series of messages in batches and batches in collections to start, end or require checkpoints during the flow.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The BatchManagementInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer) connected to a network.||This message provides flow control information enabling a series of messages in batches and batches in collections to start, end or require checkpoints during the flow.")]
public partial record BatchManagementInitiationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BtchMgmtInitn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_CcEcR1W9EeeiG_nL4vgKnQ")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the batch management.
    /// </summary>
    [IsoId("_CcEcSFW9EeeiG_nL4vgKnQ")]
    [Description(@"Information related to the batch management.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required SomeBodyRecord Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_CcEcRlW9EeeiG_nL4vgKnQ")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BatchManagementInitiationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BatchManagementInitiationV01Document ToDocument()
    {
        return new BatchManagementInitiationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BatchManagementInitiationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BatchManagementInitiationV01Document : IOuterDocument<BatchManagementInitiationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.001.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BatchManagementInitiationV01"/> is required.
    /// </summary>
    public required BatchManagementInitiationV01 Message { get; init; }
}