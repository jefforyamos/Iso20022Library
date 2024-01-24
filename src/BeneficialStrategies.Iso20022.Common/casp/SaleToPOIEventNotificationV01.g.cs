﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIEventNotificationV01.  ISO2002 ID# _ebPkwYYCEemxIqbaFEE8-w.
//
namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// An Event Notification message is sent by the POI when an event occurs.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"An Event Notification message is sent by the POI when an event occurs.")]
public partial record SaleToPOIEventNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIEvtNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIEventNotificationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIEventNotificationV01Document ToDocument()
    {
        return new SaleToPOIEventNotificationV01Document { Message = this };
    }
}

/// <summary>
/// An Event Notification message is sent by the POI when an event occurs.
/// This is the outer document that contains <seealso cref="SaleToPOIEventNotificationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOIEventNotificationV01Document : IOuterDocument<SaleToPOIEventNotificationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.012.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIEventNotificationV01"/> is required.
    /// </summary>
    public required SaleToPOIEventNotificationV01 Message { get; init; }
}
