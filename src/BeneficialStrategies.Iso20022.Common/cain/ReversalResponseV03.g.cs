﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReversalResponseV03.  ISO2002 ID# _1UjKQYwDEeuC5632vxUfGg.
//
namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// The ReversalResponse message is sent by an issuer or an agent to an acquirer in response to a ReversalInitiation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ReversalResponse message is sent by an issuer or an agent to an acquirer in response to a ReversalInitiation message.")]
public partial record ReversalResponseV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReversalResponseV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReversalResponseV03Document ToDocument()
    {
        return new ReversalResponseV03Document { Message = this };
    }
}

/// <summary>
/// The ReversalResponse message is sent by an issuer or an agent to an acquirer in response to a ReversalInitiation message.
/// This is the outer document that contains <seealso cref="ReversalResponseV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ReversalResponseV03Document : IOuterDocument<ReversalResponseV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.006.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReversalResponseV03"/> is required.
    /// </summary>
    public required ReversalResponseV03 Message { get; init; }
}
