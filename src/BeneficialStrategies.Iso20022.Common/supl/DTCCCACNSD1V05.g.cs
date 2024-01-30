﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCACNSD1V05.  ISO2002 ID# _ltky8axSEeS0K5hpCwL11w.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCACNSD1 message extends ISO corporate action cancellation advise (CACN) message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCACNSD1 message extends ISO corporate action cancellation advise (CACN) message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCACNSD1V05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACNSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information to be extended as supplementary data to cancellation advice.
    /// </summary>
    [IsoId("_ltky86xSEeS0K5hpCwL11w")]
    [Description(@"Information to be extended as supplementary data to cancellation advice.")]
    [DataMember(Name="Ntfctn")]
    [XmlElement(ElementName="Ntfctn")]
    public CorporateActionNotificationSD1? Notification { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to cancellation advice general information.
    /// </summary>
    [IsoId("_ltky9axSEeS0K5hpCwL11w")]
    [Description(@"Information to be extended as supplementary data to cancellation advice general information.")]
    [DataMember(Name="GnlInf")]
    [XmlElement(ElementName="GnlInf")]
    public CorporateActionGeneralInformationSD19? GeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as events linkage supplementary data to events to cancellation advice.
    /// </summary>
    [IsoId("_ltky96xSEeS0K5hpCwL11w")]
    [Description(@"Information to be extended as events linkage supplementary data to events to cancellation advice.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public CorporateActionCancellationSD1? EventsLinkage { get; init; }
    
    /// <summary>
    /// Information to be extended as external comments to cancellation advice.
    /// </summary>
    [IsoId("_ltky-axSEeS0K5hpCwL11w")]
    [Description(@"Information to be extended as external comments to cancellation advice.")]
    [DataMember(Name="XtrnlCmnts")]
    [XmlElement(ElementName="XtrnlCmnts")]
    public CorporateActionCancellationSD2? ExternalComments { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCACNSD1V05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCACNSD1V05Document ToDocument()
    {
        return new DTCCCACNSD1V05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCACNSD1V05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCACNSD1V05Document : IOuterDocument<DTCCCACNSD1V05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.006.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCACNSD1V05"/> is required.
    /// </summary>
    public required DTCCCACNSD1V05 Message { get; init; }
}
