﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCANOServiceDataSD1V03.  ISO2002 ID# _1PgAsDL3EeKU9IrkkToqcw_-1681566292.
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
/// This record is an implementation of the supl.003.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCANOServiceDataSD1 message extends ISO corporate action notification (CANO) message with DTCC validation service specific data elements that are not covered by the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCANOServiceDataSD1 message extends ISO corporate action notification (CANO) message with DTCC validation service specific data elements that are not covered by the standard message.")]
public partial record DTCCCANOServiceDataSD1V03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.003.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOSvcDataSD1";
    
    #nullable enable
    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_1PgAsTL3EeKU9IrkkToqcw_1324370913")]
    [Description(@"Information to be extended as supplementary data to notification general information.")]
    [DataMember(Name="NtfctnGnlInf")]
    [XmlElement(ElementName="NtfctnGnlInf")]
    public CorporateActionNotificationSD6? NotificationGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to events linkage.
    /// </summary>
    [IsoId("_1PgAsjL3EeKU9IrkkToqcw_1207093876")]
    [Description(@"Information to be extended as supplementary data to events linkage.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public CorporateActionEventReferenceSD2? EventsLinkage { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action notification.
    /// </summary>
    [IsoId("_1PgAszL3EeKU9IrkkToqcw_-847715476")]
    [Description(@"Information to be extended as supplementary data to corporate action notification.")]
    [DataMember(Name="CorpActnNtfctn")]
    [XmlElement(ElementName="CorpActnNtfctn")]
    public CorporateActionNotificationSD1? CorporateActionNotification { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security.
    /// </summary>
    [IsoId("_1PgAtDL3EeKU9IrkkToqcw_-195598292")]
    [Description(@"Information to be extended as supplementary data to underlying security.")]
    [DataMember(Name="UndrlygScty")]
    [XmlElement(ElementName="UndrlygScty")]
    public FinancialInstrumentAttributesSD7? UnderlyingSecurity { get; init; }
    
    /// <summary>
    /// Information to be extended as corporate action details supplementary data.
    /// </summary>
    [IsoId("_1PgAtTL3EeKU9IrkkToqcw_1221991011")]
    [Description(@"Information to be extended as corporate action details supplementary data.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateActionSD4? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as corporate action date details supplementary data.
    /// </summary>
    [IsoId("_1PgAtjL3EeKU9IrkkToqcw_-885992761")]
    [Description(@"Information to be extended as corporate action date details supplementary data.")]
    [DataMember(Name="CorpActnDtDtls")]
    [XmlElement(ElementName="CorpActnDtDtls")]
    public CorporateActionDateSD4? CorporateActionDateDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to option details.
    /// </summary>
    [IsoId("_1PpKoDL3EeKU9IrkkToqcw_531596542")]
    [Description(@"Information to be extended as supplementary data to option details.")]
    [DataMember(Name="OptnDtls")]
    [XmlElement(ElementName="OptnDtls")]
    public CorporateActionOptionSD5? OptionDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement details.
    /// </summary>
    [IsoId("_1PpKoTL3EeKU9IrkkToqcw_-1504539626")]
    [Description(@"Information to be extended as supplementary data to securities movement details.")]
    [DataMember(Name="SctiesMvmntDtls")]
    [XmlElement(ElementName="SctiesMvmntDtls")]
    public SecuritiesOptionSD4? SecuritiesMovementDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement security details.
    /// </summary>
    [IsoId("_1PpKojL3EeKU9IrkkToqcw_-86950323")]
    [Description(@"Information to be extended as supplementary data to securities movement security details.")]
    [DataMember(Name="SctiesMvmntSctyDtls")]
    [XmlElement(ElementName="SctiesMvmntSctyDtls")]
    public FinancialInstrumentAttributesSD5? SecuritiesMovementSecurityDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as cash movement supplementary data.
    /// </summary>
    [IsoId("_1PpKozL3EeKU9IrkkToqcw_565166861")]
    [Description(@"Information to be extended as cash movement supplementary data.")]
    [DataMember(Name="CshMvmntDtls")]
    [XmlElement(ElementName="CshMvmntDtls")]
    public CashOptionSD5? CashMovementDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCANOServiceDataSD1V03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCANOServiceDataSD1V03Document ToDocument()
    {
        return new DTCCCANOServiceDataSD1V03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCANOServiceDataSD1V03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCANOServiceDataSD1V03Document : IOuterDocument<DTCCCANOServiceDataSD1V03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.003.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCANOServiceDataSD1V03"/> is required.
    /// </summary>
    public required DTCCCANOServiceDataSD1V03 Message { get; init; }
}
