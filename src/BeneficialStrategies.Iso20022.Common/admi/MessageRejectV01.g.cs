﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MessageRejectV01.  ISO2002 ID# _8LH5WNE9Ed-BzquC8wXy7w_-1942533103.
//
namespace BeneficialStrategies.Iso20022.admi;

/// <summary>
/// Scope
/// The MessageReject message is sent by a central system to notify the rejection of a previously received message.
/// Usage
/// The message provides specific information about the rejection reason.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MessageReject message is sent by a central system to notify the rejection of a previously received message.|Usage|The message provides specific information about the rejection reason.")]
public partial record MessageRejectV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "admi.002.001.01";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MessageRejectV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MessageRejectV01Document ToDocument()
    {
        return new MessageRejectV01Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The MessageReject message is sent by a central system to notify the rejection of a previously received message.
/// Usage
/// The message provides specific information about the rejection reason.
/// This is the outer document that contains <seealso cref="MessageRejectV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MessageRejectV01Document : IOuterDocument<MessageRejectV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.002.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MessageRejectV01"/> is required.
    /// </summary>
    public required MessageRejectV01 Message { get; init; }
}
