﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CardManagementResponseV02.  ISO2002 ID# _0fzzwYN1EeuHqfO1LgkE9Q.
//
namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// The CardManagementResponse message is sent by an issuer or an agent to an acquirer in response to a CardManagementInitiation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CardManagementResponse message is sent by an issuer or an agent to an acquirer in response to a CardManagementInitiation message.")]
public partial record CardManagementResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CardMgmtRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CardManagementResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CardManagementResponseV02Document ToDocument()
    {
        return new CardManagementResponseV02Document { Message = this };
    }
}

/// <summary>
/// The CardManagementResponse message is sent by an issuer or an agent to an acquirer in response to a CardManagementInitiation message.
/// This is the outer document that contains <seealso cref="CardManagementResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CardManagementResponseV02Document : IOuterDocument<CardManagementResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.024.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CardManagementResponseV02"/> is required.
    /// </summary>
    public required CardManagementResponseV02 Message { get; init; }
}
