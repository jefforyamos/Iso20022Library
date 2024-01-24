﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIReconciliationRequestV05.  ISO2002 ID# _FqnHEXO6Ee2pK6udhxEaHA.
//
namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// The SaleToPOIReconciliationRequest message is sent by a sale system to request for reconciliation between sale and POI systems.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SaleToPOIReconciliationRequest message is sent by a sale system to request for reconciliation between sale and POI systems.")]
public partial record SaleToPOIReconciliationRequestV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIRcncltnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIReconciliationRequestV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIReconciliationRequestV05Document ToDocument()
    {
        return new SaleToPOIReconciliationRequestV05Document { Message = this };
    }
}

/// <summary>
/// The SaleToPOIReconciliationRequest message is sent by a sale system to request for reconciliation between sale and POI systems.
/// This is the outer document that contains <seealso cref="SaleToPOIReconciliationRequestV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOIReconciliationRequestV05Document : IOuterDocument<SaleToPOIReconciliationRequestV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.003.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIReconciliationRequestV05"/> is required.
    /// </summary>
    public required SaleToPOIReconciliationRequestV05 Message { get; init; }
}
