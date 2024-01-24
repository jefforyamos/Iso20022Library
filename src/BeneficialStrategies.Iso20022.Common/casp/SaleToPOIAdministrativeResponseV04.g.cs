﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIAdministrativeResponseV04.  ISO2002 ID# _c7ODcU6ZEeyGi9JAv6wq7Q.
//
namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// The SaleToPOIAdministrativeResponse message is sent by a POI System to a sale system to provide response to an administrative service.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SaleToPOIAdministrativeResponse message is sent by a POI System to a sale system to provide response to an administrative service.")]
public partial record SaleToPOIAdministrativeResponseV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIAdmstvRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIAdministrativeResponseV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIAdministrativeResponseV04Document ToDocument()
    {
        return new SaleToPOIAdministrativeResponseV04Document { Message = this };
    }
}

/// <summary>
/// The SaleToPOIAdministrativeResponse message is sent by a POI System to a sale system to provide response to an administrative service.
/// This is the outer document that contains <seealso cref="SaleToPOIAdministrativeResponseV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOIAdministrativeResponseV04Document : IOuterDocument<SaleToPOIAdministrativeResponseV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.008.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIAdministrativeResponseV04"/> is required.
    /// </summary>
    public required SaleToPOIAdministrativeResponseV04 Message { get; init; }
}
