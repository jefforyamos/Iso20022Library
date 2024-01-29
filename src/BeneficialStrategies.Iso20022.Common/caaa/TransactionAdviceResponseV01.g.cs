﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransactionAdviceResponseV01.  ISO2002 ID# _gnEDgBBkEeqgJK7e3n_EXA.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The TransactionAdviceResponse message is sent by the POI to acknowledge the Acquirer (or its agent) about the notification of the transaction advice.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The TransactionAdviceResponse message is sent by the POI to acknowledge the Acquirer (or its agent) about the notification of the transaction advice.")]
public partial record TransactionAdviceResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TxAdvcRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Completion advice message management information.
    /// </summary>
    [IsoId("_ugw-QRBkEeqgJK7e3n_EXA")]
    [Description(@"Completion advice message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the transaction advice response.
    /// </summary>
    [IsoId("_xYYEkRBkEeqgJK7e3n_EXA")]
    [Description(@"Information related to the transaction advice response.")]
    [DataMember(Name="TxAdvcRspn")]
    [XmlElement(ElementName="TxAdvcRspn")]
    [Required]
    public required SomeTransactionAdviceResponseRecord TransactionAdviceResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_13mB4RBkEeqgJK7e3n_EXA")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransactionAdviceResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransactionAdviceResponseV01Document ToDocument()
    {
        return new TransactionAdviceResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransactionAdviceResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransactionAdviceResponseV01Document : IOuterDocument<TransactionAdviceResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.021.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransactionAdviceResponseV01"/> is required.
    /// </summary>
    public required TransactionAdviceResponseV01 Message { get; init; }
}