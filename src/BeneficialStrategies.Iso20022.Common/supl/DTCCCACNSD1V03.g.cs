﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCACNSD1V03.  ISO2002 ID# _1Py7oDL3EeKU9IrkkToqcw_1572925188.
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
/// This record is an implementation of the supl.006.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCACNSD1 message extends ISO corporate action cancellation advise (CACN) message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCACNSD1 message extends ISO corporate action cancellation advise (CACN) message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCACNSD1V03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.006.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACNSD1";
    
    #nullable enable
    /// <summary>
    /// Information to be extended as supplementary data to cancellation advice.
    /// </summary>
    [IsoId("_1Py7oTL3EeKU9IrkkToqcw_-1644021770")]
    [Description(@"Information to be extended as supplementary data to cancellation advice.")]
    [DataMember(Name="Ntfctn")]
    [XmlElement(ElementName="Ntfctn")]
    public CorporateActionNotificationSD1? Notification { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to cancellation advice general information.
    /// </summary>
    [IsoId("_1Py7ojL3EeKU9IrkkToqcw_542961754")]
    [Description(@"Information to be extended as supplementary data to cancellation advice general information.")]
    [DataMember(Name="GnlInf")]
    [XmlElement(ElementName="GnlInf")]
    public CorporateActionGeneralInformationSD4? GeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as events linkage supplementary data to events to cancellation advice.
    /// </summary>
    [IsoId("_1Py7ozL3EeKU9IrkkToqcw_1960551057")]
    [Description(@"Information to be extended as events linkage supplementary data to events to cancellation advice.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public CorporateActionCancellationSD1? EventsLinkage { get; init; }
    
    /// <summary>
    /// Information to be extended as external comments to cancellation advice.
    /// </summary>
    [IsoId("_1Py7pDL3EeKU9IrkkToqcw_-147432715")]
    [Description(@"Information to be extended as external comments to cancellation advice.")]
    [DataMember(Name="XtrnlCmnts")]
    [XmlElement(ElementName="XtrnlCmnts")]
    public CorporateActionCancellationSD2? ExternalComments { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCACNSD1V03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCACNSD1V03Document ToDocument()
    {
        return new DTCCCACNSD1V03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCACNSD1V03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCACNSD1V03Document : IOuterDocument<DTCCCACNSD1V03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.006.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCACNSD1V03"/> is required.
    /// </summary>
    public required DTCCCACNSD1V03 Message { get; init; }
}
