﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOISessionManagementRequestV03.  ISO2002 ID# _GECVUS5MEeunNvJlR_vCbg.
//
namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// The SaleToPOISessionManagementRequest message is sent by a sale system to select an administrative service related to session management.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SaleToPOISessionManagementRequest message is sent by a sale system to select an administrative service related to session management.")]
public partial record SaleToPOISessionManagementRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOISsnMgmtReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOISessionManagementRequestV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOISessionManagementRequestV03Document ToDocument()
    {
        return new SaleToPOISessionManagementRequestV03Document { Message = this };
    }
}

/// <summary>
/// The SaleToPOISessionManagementRequest message is sent by a sale system to select an administrative service related to session management.
/// This is the outer document that contains <seealso cref="SaleToPOISessionManagementRequestV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOISessionManagementRequestV03Document : IOuterDocument<SaleToPOISessionManagementRequestV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOISessionManagementRequestV03"/> is required.
    /// </summary>
    public required SaleToPOISessionManagementRequestV03 Message { get; init; }
}
