﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PaymentRegulatoryInformationNotificationV02.  ISO2002 ID# _bf9R622PEei3KuUgpx7Xcw.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The PaymentRegulatoryInformationNotification message is sent by the reporting party to the registration agent to provide details on the transaction, when a payment has to be recorded against the registered currency control contract. 
/// In some cases, the registration agent may also sent this message to the reporting party.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The PaymentRegulatoryInformationNotification message is sent by the reporting party to the registration agent to provide details on the transaction, when a payment has to be recorded against the registered currency control contract. ||In some cases, the registration agent may also sent this message to the reporting party.")]
public partial record PaymentRegulatoryInformationNotificationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PmtRgltryInfNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Characteristics shared by all individual items included in the message.
    /// </summary>
    [IsoId("_bf9R7W2PEei3KuUgpx7Xcw")]
    [Description(@"Characteristics shared by all individual items included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required CurrencyControlHeader5 GroupHeader { get; init; }
    
    /// <summary>
    /// Notification of information related to a regulatory reporting on a payment.
    /// </summary>
    [IsoId("_bf9R722PEei3KuUgpx7Xcw")]
    [Description(@"Notification of information related to a regulatory reporting on a payment.")]
    [DataMember(Name="TxNtfctn")]
    [XmlElement(ElementName="TxNtfctn")]
    [Required]
    public required RegulatoryReportingNotification2 TransactionNotification { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bf9R8W2PEei3KuUgpx7Xcw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PaymentRegulatoryInformationNotificationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PaymentRegulatoryInformationNotificationV02Document ToDocument()
    {
        return new PaymentRegulatoryInformationNotificationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PaymentRegulatoryInformationNotificationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PaymentRegulatoryInformationNotificationV02Document : IOuterDocument<PaymentRegulatoryInformationNotificationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.024.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PaymentRegulatoryInformationNotificationV02"/> is required.
    /// </summary>
    public required PaymentRegulatoryInformationNotificationV02 Message { get; init; }
}
