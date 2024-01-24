﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIMessageRejectionV02.  ISO2002 ID# _IAhL0Q1UEeqjM-rxn3HuXQ.
//
namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// The SaleToPOIMessageRejection message is sent by one of the parties when it detects a technical or functional error in a previous received message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SaleToPOIMessageRejection message is sent by one of the parties when it detects a technical or functional error in a previous received message.")]
public partial record SaleToPOIMessageRejectionV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIMsgRjctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIMessageRejectionV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIMessageRejectionV02Document ToDocument()
    {
        return new SaleToPOIMessageRejectionV02Document { Message = this };
    }
}

/// <summary>
/// The SaleToPOIMessageRejection message is sent by one of the parties when it detects a technical or functional error in a previous received message.
/// This is the outer document that contains <seealso cref="SaleToPOIMessageRejectionV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOIMessageRejectionV02Document : IOuterDocument<SaleToPOIMessageRejectionV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.013.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIMessageRejectionV02"/> is required.
    /// </summary>
    public required SaleToPOIMessageRejectionV02 Message { get; init; }
}
