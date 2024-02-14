﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MoneyMarketOvernightIndexSwapsStatisticalReportV01.  ISO2002 ID# _HeIa8aicEeWHO_l3hf2rlA.
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
/// This record is an implementation of the auth.015.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The MoneyMarketOvernightIndexSwapsStatisticalReport message is sent by the reporting agents to the relevant competent authority, to report the daily overnight index swaps (OIS) transactions.
/// </summary>
[Description(@"The MoneyMarketOvernightIndexSwapsStatisticalReport message is sent by the reporting agents to the relevant competent authority, to report the daily overnight index swaps (OIS) transactions.")]
[IsoId("_HeIa8aicEeWHO_l3hf2rlA")]
[DisplayName("Money Market Overnight Index Swaps Statistical Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MoneyMarketOvernightIndexSwapsStatisticalReportV01 : IOuterRecord<MoneyMarketOvernightIndexSwapsStatisticalReportV01,MoneyMarketOvernightIndexSwapsStatisticalReportV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.015.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MnyMktOvrnghtIndxSwpsSttstclRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MoneyMarketOvernightIndexSwapsStatisticalReportV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MoneyMarketOvernightIndexSwapsStatisticalReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MoneyMarketOvernightIndexSwapsStatisticalReportV01( MoneyMarketReportHeader1 reqReportHeader,OvernightIndexSwap3Choice_ reqOvernightIndexSwapsReport )
    {
        ReportHeader = reqReportHeader;
        OvernightIndexSwapsReport = reqOvernightIndexSwapsReport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the elements specific to the report.
    /// </summary>
    [IsoId("_HeIa86icEeWHO_l3hf2rlA")]
    [DisplayName("Report Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptHdr")]
    #endif
    [IsoXmlTag("RptHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MoneyMarketReportHeader1 ReportHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MoneyMarketReportHeader1 ReportHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MoneyMarketReportHeader1 ReportHeader { get; init; } 
    #else
    public MoneyMarketReportHeader1 ReportHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the reason why no activity is reported or the required list of transactions for the overnight index swaps segment.
    /// </summary>
    [IsoId("_HeIa9aicEeWHO_l3hf2rlA")]
    [DisplayName("Overnight Index Swaps Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OvrnghtIndxSwpsRpt")]
    #endif
    [IsoXmlTag("OvrnghtIndxSwpsRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OvernightIndexSwap3Choice_ OvernightIndexSwapsReport { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OvernightIndexSwap3Choice_ OvernightIndexSwapsReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OvernightIndexSwap3Choice_ OvernightIndexSwapsReport { get; init; } 
    #else
    public OvernightIndexSwap3Choice_ OvernightIndexSwapsReport { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_HeIa96icEeWHO_l3hf2rlA")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;MoneyMarketOvernightIndexSwapsStatisticalReportV01Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MoneyMarketOvernightIndexSwapsStatisticalReportV01Document ToDocument()
    {
        return new MoneyMarketOvernightIndexSwapsStatisticalReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;MoneyMarketOvernightIndexSwapsStatisticalReportV01&quot;/&gt;.
/// </summary>
[Serializable]
public partial record MoneyMarketOvernightIndexSwapsStatisticalReportV01Document : IOuterDocument<MoneyMarketOvernightIndexSwapsStatisticalReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.015.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;MoneyMarketOvernightIndexSwapsStatisticalReportV01&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MoneyMarketOvernightIndexSwapsStatisticalReportV01 Message { get; init; }
    #else
    public MoneyMarketOvernightIndexSwapsStatisticalReportV01 Message { get; init; }
    #endif
}
