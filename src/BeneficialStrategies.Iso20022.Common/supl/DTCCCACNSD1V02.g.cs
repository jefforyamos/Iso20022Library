﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCACNSD1V02.  ISO2002 ID# _1OTt4zL3EeKU9IrkkToqcw_-1610896925.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.supl;


/// <summary>
/// The DTCCCACNSD1 message extends ISO corporate action cancellation advise (CACN) message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCACNSD1 message extends ISO corporate action cancellation advise (CACN) message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCACNSD1V02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACNSD1";
    
    #nullable enable
    /// <summary>
    /// Information to be extended as supplementary data to cancellation advice.
    /// </summary>
    [IsoId("_1OTt5DL3EeKU9IrkkToqcw_-1238632619")]
    [Description(@"Information to be extended as supplementary data to cancellation advice.")]
    [DataMember(Name="NtfctnXtnsn")]
    [XmlElement(ElementName="NtfctnXtnsn")]
    public CorporateActionNotificationSD1? NotificationExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to cancellation advice general information.
    /// </summary>
    [IsoId("_1OTt5TL3EeKU9IrkkToqcw_-2042507692")]
    [Description(@"Information to be extended as supplementary data to cancellation advice general information.")]
    [DataMember(Name="GnlInfXtnsn")]
    [XmlElement(ElementName="GnlInfXtnsn")]
    public CorporateActionGeneralInformationSD2? GeneralInformationExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as events linkage supplementary data to events to cancellation advice.
    /// </summary>
    [IsoId("_1OTt5jL3EeKU9IrkkToqcw_-1867503343")]
    [Description(@"Information to be extended as events linkage supplementary data to events to cancellation advice.")]
    [DataMember(Name="EvtsLkgXtnsn")]
    [XmlElement(ElementName="EvtsLkgXtnsn")]
    public CorporateActionCancellationSD1? EventsLinkageExtension { get; init; }
    
    /// <summary>
    /// Information to be extended as external comments to cancellation advice.
    /// </summary>
    [IsoId("_1OTt5zL3EeKU9IrkkToqcw_-551563388")]
    [Description(@"Information to be extended as external comments to cancellation advice.")]
    [DataMember(Name="XtrnlCmntsXtnsn")]
    [XmlElement(ElementName="XtrnlCmntsXtnsn")]
    public CorporateActionCancellationSD2? ExternalCommentsExtension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCACNSD1V02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCACNSD1V02Document ToDocument()
    {
        return new DTCCCACNSD1V02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCACNSD1V02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCACNSD1V02Document : IOuterDocument<DTCCCACNSD1V02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.006.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCACNSD1V02"/> is required.
    /// </summary>
    public required DTCCCACNSD1V02 Message { get; init; }
}
