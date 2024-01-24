﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ProcessingRequestV01.  ISO2002 ID# _4X6DQJXbEeaYkf5FCqYMeA.
//
namespace BeneficialStrategies.Iso20022.admi;

/// <summary>
/// The Processing Request message is sent by a participant to a central system to request the initiation of a system process suported by a central system.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The Processing Request message is sent by a participant to a central system to request the initiation of a system process suported by a central system.")]
public partial record ProcessingRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrcgReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ProcessingRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ProcessingRequestV01Document ToDocument()
    {
        return new ProcessingRequestV01Document { Message = this };
    }
}

/// <summary>
/// The Processing Request message is sent by a participant to a central system to request the initiation of a system process suported by a central system.
/// This is the outer document that contains <seealso cref="ProcessingRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ProcessingRequestV01Document : IOuterDocument<ProcessingRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.017.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ProcessingRequestV01"/> is required.
    /// </summary>
    public required ProcessingRequestV01 Message { get; init; }
}
