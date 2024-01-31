﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ForeignExchangeTradeCaptureReportAcknowledgementV01.  ISO2002 ID# _5_POYHO0EeSG-OV0nXMl5w.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.fxtr;


/// <summary>
/// Scope
/// The ForeignExchangeTradeCaptureReportAcknowledgement message is sent by trading members to the trading system for notifying the trade capture report is received.
/// Usage
/// The acknowledgement is sent by the trading member to the trading system after they received the trade capture report. 
/// Note that one capture acknowledgement responds to one capture report.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ForeignExchangeTradeCaptureReportAcknowledgement message is sent by trading members to the trading system for notifying the trade capture report is received.||Usage|The acknowledgement is sent by the trading member to the trading system after they received the trade capture report. |Note that one capture acknowledgement responds to one capture report.")]
public partial record ForeignExchangeTradeCaptureReportAcknowledgementV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradCaptrRptAck";
    
    #nullable enable
    /// <summary>
    /// Identifies the acknowledgement message.
    /// </summary>
    [IsoId("_BoI5cHO1EeSG-OV0nXMl5w")]
    [Description(@"Identifies the acknowledgement message.")]
    [DataMember(Name="AckId")]
    [XmlElement(ElementName="AckId")]
    public MessageIdentification1? AcknowledgementIdentification { get; init; }
    
    /// <summary>
    /// Unique reference identification assigned to the trade by the instructing party. This reference will be used throughout the trade life cycle to identify the particular trade.
    /// </summary>
    [IsoId("_EnLdcHO1EeSG-OV0nXMl5w")]
    [Description(@"Unique reference identification assigned to the trade by the instructing party. This reference will be used throughout the trade life cycle to identify the particular trade.")]
    [DataMember(Name="TradId")]
    [XmlElement(ElementName="TradId")]
    [Required]
    public required IsoMax35Text TradeIdentification { get; init; }
    
    /// <summary>
    /// Acknowlegement status of recevied trade capture report.
    /// </summary>
    [IsoId("_I7vC4HO1EeSG-OV0nXMl5w")]
    [Description(@"Acknowlegement status of recevied trade capture report.")]
    [DataMember(Name="Sts")]
    [XmlElement(ElementName="Sts")]
    [Required]
    public required Status5Code Status { get; init; }
    
    /// <summary>
    /// Reference of the acknowledge, specifies the message this acknowledge responds to.
    /// </summary>
    [IsoId("_OS-0YHO1EeSG-OV0nXMl5w")]
    [Description(@"Reference of the acknowledge, specifies the message this acknowledge responds to.")]
    [DataMember(Name="Ref")]
    [XmlElement(ElementName="Ref")]
    public AdditionalReferences? Reference { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ankbAKHiEeS69KkQis5bYg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ForeignExchangeTradeCaptureReportAcknowledgementV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ForeignExchangeTradeCaptureReportAcknowledgementV01Document ToDocument()
    {
        return new ForeignExchangeTradeCaptureReportAcknowledgementV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ForeignExchangeTradeCaptureReportAcknowledgementV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ForeignExchangeTradeCaptureReportAcknowledgementV01Document : IOuterDocument<ForeignExchangeTradeCaptureReportAcknowledgementV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.033.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ForeignExchangeTradeCaptureReportAcknowledgementV01"/> is required.
    /// </summary>
    public required ForeignExchangeTradeCaptureReportAcknowledgementV01 Message { get; init; }
}
