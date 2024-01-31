﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ForeignExchangeTradeBulkStatusNotificationV04.  ISO2002 ID# _sZyzIZR1Eeak6e8_Fc5fQg.
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
/// Scope|
/// The ForeignExchangeTradeBulkStatusNotification message is sent by a central system to the participant to provide notification of the current status of one or more foreign exchange trades.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope||The ForeignExchangeTradeBulkStatusNotification message is sent by a central system to the participant to provide notification of the current status of one or more foreign exchange trades.")]
public partial record ForeignExchangeTradeBulkStatusNotificationV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradBlkStsNtfctn";
    
    #nullable enable
    /// <summary>
    /// Information on the status of the trade in the central system.
    /// </summary>
    [IsoId("_sZyzI5R1Eeak6e8_Fc5fQg")]
    [Description(@"Information on the status of the trade in the central system.|")]
    [DataMember(Name="StsDtls")]
    [XmlElement(ElementName="StsDtls")]
    [Required]
    public required TradeData12 StatusDetails { get; init; }
    
    /// <summary>
    /// Identifies one or more trades for which the status notification is sent.
    /// </summary>
    [IsoId("_sZyzJZR1Eeak6e8_Fc5fQg")]
    [Description(@"Identifies one or more trades for which the status notification is sent.|")]
    [DataMember(Name="TradData")]
    [XmlElement(ElementName="TradData")]
    [Required]
    public required TradeData11 TradeData { get; init; }
    
    /// <summary>
    /// Page number of the message (within the status report) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_sZyzJ5R1Eeak6e8_Fc5fQg")]
    [Description(@"Page number of the message (within the status report) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the report.")]
    [DataMember(Name="MsgPgntn")]
    [XmlElement(ElementName="MsgPgntn")]
    public Pagination? MessagePagination { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_sZyzKZR1Eeak6e8_Fc5fQg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ForeignExchangeTradeBulkStatusNotificationV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ForeignExchangeTradeBulkStatusNotificationV04Document ToDocument()
    {
        return new ForeignExchangeTradeBulkStatusNotificationV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ForeignExchangeTradeBulkStatusNotificationV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ForeignExchangeTradeBulkStatusNotificationV04Document : IOuterDocument<ForeignExchangeTradeBulkStatusNotificationV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.030.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ForeignExchangeTradeBulkStatusNotificationV04"/> is required.
    /// </summary>
    public required ForeignExchangeTradeBulkStatusNotificationV04 Message { get; init; }
}
