﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CreateLimitV01.  ISO2002 ID# _P8tBcckHEem3UrxZgQhVAw.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The CreateLimit message is sent by a member to the transaction administrator.
/// It is used to create one or several limits set by the member and managed by the transaction administrator.
/// Usage
/// Based on the criteria defined in the CreateLimit message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CreateLimit message is sent by a member to the transaction administrator.|It is used to create one or several limits set by the member and managed by the transaction administrator.|Usage|Based on the criteria defined in the CreateLimit message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.")]
public partial record CreateLimitV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CretLmt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CreateLimitV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CreateLimitV01Document ToDocument()
    {
        return new CreateLimitV01Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The CreateLimit message is sent by a member to the transaction administrator.
/// It is used to create one or several limits set by the member and managed by the transaction administrator.
/// Usage
/// Based on the criteria defined in the CreateLimit message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.
/// This is the outer document that contains <seealso cref="CreateLimitV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CreateLimitV01Document : IOuterDocument<CreateLimitV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.101.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CreateLimitV01"/> is required.
    /// </summary>
    public required CreateLimitV01 Message { get; init; }
}
