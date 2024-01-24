﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BatchManagementResponseV01.  ISO2002 ID# _O_nm9VW-EeeiG_nL4vgKnQ.
//
namespace BeneficialStrategies.Iso20022.caad;

/// <summary>
/// The BatchManagementResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a BatchManagementInitiation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The BatchManagementResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a BatchManagementInitiation message.")]
public partial record BatchManagementResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BtchMgmtRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BatchManagementResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BatchManagementResponseV01Document ToDocument()
    {
        return new BatchManagementResponseV01Document { Message = this };
    }
}

/// <summary>
/// The BatchManagementResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a BatchManagementInitiation message.
/// This is the outer document that contains <seealso cref="BatchManagementResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BatchManagementResponseV01Document : IOuterDocument<BatchManagementResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.002.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BatchManagementResponseV01"/> is required.
    /// </summary>
    public required BatchManagementResponseV01 Message { get; init; }
}
