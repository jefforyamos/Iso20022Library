﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CurrencyControlSupportingDocumentDeliveryV02.  ISO2002 ID# _bf9R822PEei3KuUgpx7Xcw.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The CurrencyControlSupportingDocumentDelivery message is sent by either the reporting party (respectively the registration agent) or the registration agent (respectively the reporting party) in response to the supporting document request.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CurrencyControlSupportingDocumentDelivery message is sent by either the reporting party (respectively the registration agent) or the registration agent (respectively the reporting party) in response to the supporting document request.")]
public partial record CurrencyControlSupportingDocumentDeliveryV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CcyCtrlSpprtgDocDlvry";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CurrencyControlSupportingDocumentDeliveryV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CurrencyControlSupportingDocumentDeliveryV02Document ToDocument()
    {
        return new CurrencyControlSupportingDocumentDeliveryV02Document { Message = this };
    }
}

/// <summary>
/// The CurrencyControlSupportingDocumentDelivery message is sent by either the reporting party (respectively the registration agent) or the registration agent (respectively the reporting party) in response to the supporting document request.
/// This is the outer document that contains <seealso cref="CurrencyControlSupportingDocumentDeliveryV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CurrencyControlSupportingDocumentDeliveryV02Document : IOuterDocument<CurrencyControlSupportingDocumentDeliveryV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.025.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CurrencyControlSupportingDocumentDeliveryV02"/> is required.
    /// </summary>
    public required CurrencyControlSupportingDocumentDeliveryV02 Message { get; init; }
}
