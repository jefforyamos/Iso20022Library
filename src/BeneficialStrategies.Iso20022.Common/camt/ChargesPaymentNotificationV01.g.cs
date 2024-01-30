﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ChargesPaymentNotificationV01.  ISO2002 ID# _rZb4ILR_Eeq3lpO-mRtrig.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// The ChargesPaymentNotification message is sent by the account servicing institution to the account owner to advise charges, interest or other adjustments to the owner's account.  It provides details of charges which are previously unknown to the Receiver.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ChargesPaymentNotification message is sent by the account servicing institution to the account owner to advise charges, interest or other adjustments to the owner's account.  It provides details of charges which are previously unknown to the Receiver.")]
public partial record ChargesPaymentNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ChrgsPmtNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics shared by all individual charges records included in the message.
    /// </summary>
    [IsoId("_6g9sYSm5EeutWNGMV2XKIQ")]
    [Description(@"Set of characteristics shared by all individual charges records included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader102 GroupHeader { get; init; }
    
    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the processing of the underlying transaction.
    /// </summary>
    [IsoId("_DgpvxrSAEeq3lpO-mRtrig")]
    [Description(@"Provides information on the charges to be paid by the charge bearer(s) related to the processing of the underlying transaction.")]
    [DataMember(Name="Chrgs")]
    [XmlElement(ElementName="Chrgs")]
    [Required]
    public required ChargesRecord4 Charges { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Dgpvx7SAEeq3lpO-mRtrig")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ChargesPaymentNotificationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ChargesPaymentNotificationV01Document ToDocument()
    {
        return new ChargesPaymentNotificationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ChargesPaymentNotificationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ChargesPaymentNotificationV01Document : IOuterDocument<ChargesPaymentNotificationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.105.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ChargesPaymentNotificationV01"/> is required.
    /// </summary>
    public required ChargesPaymentNotificationV01 Message { get; init; }
}
