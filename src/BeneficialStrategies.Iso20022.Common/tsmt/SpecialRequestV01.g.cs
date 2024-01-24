﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SpecialRequestV01.  ISO2002 ID# _u_roONE8Ed-BzquC8wXy7w_-951439872.
//
namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// Scope
/// The SpecialRequest message is sent by a party to the transaction to the matching application if special circumstances are such that it cannot take part any longer to a specific transaction or that it cannot fulfill its role in the transaction.
/// Usage
/// The SpecialRequest message can be sent at any time during the life time of a transaction as long as the transaction is established and not yet closed.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The SpecialRequest message is sent by a party to the transaction to the matching application if special circumstances are such that it cannot take part any longer to a specific transaction or that it cannot fulfill its role in the transaction.|Usage|The SpecialRequest message can be sent at any time during the life time of a transaction as long as the transaction is established and not yet closed.")]
public partial record SpecialRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SpclReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SpecialRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SpecialRequestV01Document ToDocument()
    {
        return new SpecialRequestV01Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The SpecialRequest message is sent by a party to the transaction to the matching application if special circumstances are such that it cannot take part any longer to a specific transaction or that it cannot fulfill its role in the transaction.
/// Usage
/// The SpecialRequest message can be sent at any time during the life time of a transaction as long as the transaction is established and not yet closed.
/// This is the outer document that contains <seealso cref="SpecialRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SpecialRequestV01Document : IOuterDocument<SpecialRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.047.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SpecialRequestV01"/> is required.
    /// </summary>
    public required SpecialRequestV01 Message { get; init; }
}
