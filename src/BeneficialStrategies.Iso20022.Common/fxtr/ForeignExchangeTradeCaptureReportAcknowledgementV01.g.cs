﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ForeignExchangeTradeCaptureReportAcknowledgementV01.  ISO2002 ID# _5_POYHO0EeSG-OV0nXMl5w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// This record is an implementation of the fxtr.033.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForeignExchangeTradeCaptureReportAcknowledgement message is sent by trading members to the trading system for notifying the trade capture report is received.
/// 
/// Usage
/// The acknowledgement is sent by the trading member to the trading system after they received the trade capture report. 
/// Note that one capture acknowledgement responds to one capture report.
/// </summary>
[Description(@"Scope|The ForeignExchangeTradeCaptureReportAcknowledgement message is sent by trading members to the trading system for notifying the trade capture report is received.||Usage|The acknowledgement is sent by the trading member to the trading system after they received the trade capture report. |Note that one capture acknowledgement responds to one capture report.")]
[IsoId("_5_POYHO0EeSG-OV0nXMl5w")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Foreign Exchange Trade Capture Report Acknowledgement V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForeignExchangeTradeCaptureReportAcknowledgementV01 : IOuterRecord<ForeignExchangeTradeCaptureReportAcknowledgementV01,ForeignExchangeTradeCaptureReportAcknowledgementV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.033.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradCaptrRptAck";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ForeignExchangeTradeCaptureReportAcknowledgementV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ForeignExchangeTradeCaptureReportAcknowledgementV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchangeTradeCaptureReportAcknowledgementV01( System.String reqTradeIdentification,Status5Code reqStatus )
    {
        TradeIdentification = reqTradeIdentification;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the acknowledgement message.
    /// </summary>
    [IsoId("_BoI5cHO1EeSG-OV0nXMl5w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Acknowledgement Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageIdentification1? AcknowledgementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1? AcknowledgementIdentification { get; init; } 
    #else
    public MessageIdentification1? AcknowledgementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference identification assigned to the trade by the instructing party. This reference will be used throughout the trade life cycle to identify the particular trade.
    /// </summary>
    [IsoId("_EnLdcHO1EeSG-OV0nXMl5w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TradeIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String TradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradeIdentification { get; init; } 
    #else
    public System.String TradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Acknowlegement status of recevied trade capture report.
    /// </summary>
    [IsoId("_I7vC4HO1EeSG-OV0nXMl5w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status5Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Status5Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status5Code Status { get; init; } 
    #else
    public Status5Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the acknowledge, specifies the message this acknowledge responds to.
    /// </summary>
    [IsoId("_OS-0YHO1EeSG-OV0nXMl5w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReferences? Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReferences? Reference { get; init; } 
    #else
    public AdditionalReferences? Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ankbAKHiEeS69KkQis5bYg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
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
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ForeignExchangeTradeCaptureReportAcknowledgementV01 Message { get; init; }
    #else
    public ForeignExchangeTradeCaptureReportAcknowledgementV01 Message { get; init; }
    #endif
}
