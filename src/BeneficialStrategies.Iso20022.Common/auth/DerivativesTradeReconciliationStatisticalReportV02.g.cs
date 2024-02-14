﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DerivativesTradeReconciliationStatisticalReportV02.  ISO2002 ID# _pVVviWmFEe2DRvVJM2Qy-g.
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
/// This record is an implementation of the auth.091.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DerivativesTradeReportReconciliationStatisticalReport message is sent by the trade repositories to the reporting counterparty, to report cumulative information within the reference period for the reconciliation status of the reported and outstanding derivatives.
/// </summary>
[Description(@"The DerivativesTradeReportReconciliationStatisticalReport message is sent by the trade repositories to the reporting counterparty, to report cumulative information within the reference period for the reconciliation status of the reported and outstanding derivatives.")]
[IsoId("_pVVviWmFEe2DRvVJM2Qy-g")]
[DisplayName("Derivatives Trade Reconciliation Statistical Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DerivativesTradeReconciliationStatisticalReportV02 : IOuterRecord<DerivativesTradeReconciliationStatisticalReportV02,DerivativesTradeReconciliationStatisticalReportV02Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.091.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradRcncltnSttstclRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DerivativesTradeReconciliationStatisticalReportV02Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DerivativesTradeReconciliationStatisticalReportV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DerivativesTradeReconciliationStatisticalReportV02( StatisticsPerCounterparty15Choice_ reqReconciliationStatistics )
    {
        ReconciliationStatistics = reqReconciliationStatistics;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Detailed information on reconciliation process.
    /// </summary>
    [IsoId("_pVVvi2mFEe2DRvVJM2Qy-g")]
    [DisplayName("Reconciliation Statistics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnSttstcs")]
    #endif
    [IsoXmlTag("RcncltnSttstcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatisticsPerCounterparty15Choice_ ReconciliationStatistics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatisticsPerCounterparty15Choice_ ReconciliationStatistics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticsPerCounterparty15Choice_ ReconciliationStatistics { get; init; } 
    #else
    public StatisticsPerCounterparty15Choice_ ReconciliationStatistics { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_pVVvjWmFEe2DRvVJM2Qy-g")]
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
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;DerivativesTradeReconciliationStatisticalReportV02Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DerivativesTradeReconciliationStatisticalReportV02Document ToDocument()
    {
        return new DerivativesTradeReconciliationStatisticalReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;DerivativesTradeReconciliationStatisticalReportV02&quot;/&gt;.
/// </summary>
[Serializable]
public partial record DerivativesTradeReconciliationStatisticalReportV02Document : IOuterDocument<DerivativesTradeReconciliationStatisticalReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.091.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;DerivativesTradeReconciliationStatisticalReportV02&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DerivativesTradeReconciliationStatisticalReportV02 Message { get; init; }
    #else
    public DerivativesTradeReconciliationStatisticalReportV02 Message { get; init; }
    #endif
}
