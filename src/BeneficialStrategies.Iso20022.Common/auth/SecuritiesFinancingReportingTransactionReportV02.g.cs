﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesFinancingReportingTransactionReportV02.  ISO2002 ID# _0kYl0cKvEeuzU9S_IANlog.
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


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.052.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SecuritiesFinancingReportingTransactionReport message is sent by the report submitting entity to the trade repository (TR) to report on the securities financing transactions or sent by the trade repository (TR) to the authority or made available by the trade repository (TR) to the  report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable.
/// </summary>
[Description(@"The SecuritiesFinancingReportingTransactionReport message is sent by the report submitting entity to the trade repository (TR) to report on the securities financing transactions or sent by the trade repository (TR) to the authority or made available by the trade repository (TR) to the  report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable.")]
[IsoId("_0kYl0cKvEeuzU9S_IANlog")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Securities Financing Reporting Transaction Report V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesFinancingReportingTransactionReportV02 : IOuterRecord<SecuritiesFinancingReportingTransactionReportV02,SecuritiesFinancingReportingTransactionReportV02Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.052.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgRptgTxRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesFinancingReportingTransactionReportV02Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesFinancingReportingTransactionReportV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesFinancingReportingTransactionReportV02( TradeData40Choice_ reqTradeData )
    {
        TradeData = reqTradeData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of data concerning the reporting trade.
    /// </summary>
    [IsoId("_0kYl08KvEeuzU9S_IANlog")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeData40Choice_ TradeData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TradeData40Choice_ TradeData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeData40Choice_ TradeData { get; init; } 
    #else
    public TradeData40Choice_ TradeData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_0kYl1cKvEeuzU9S_IANlog")]
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
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesFinancingReportingTransactionReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesFinancingReportingTransactionReportV02Document ToDocument()
    {
        return new SecuritiesFinancingReportingTransactionReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesFinancingReportingTransactionReportV02"/>.
/// </summary>
[Serializable]
public partial record SecuritiesFinancingReportingTransactionReportV02Document : IOuterDocument<SecuritiesFinancingReportingTransactionReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.052.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesFinancingReportingTransactionReportV02"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesFinancingReportingTransactionReportV02 Message { get; init; }
    #else
    public SecuritiesFinancingReportingTransactionReportV02 Message { get; init; }
    #endif
}
