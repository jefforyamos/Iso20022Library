﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DerivativesTradeRejectionStatisticalReportV02.  ISO2002 ID# _F_KeAd1bEeqxpKDfBZC1vg.
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
/// This record is an implementation of the auth.092.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DerivativesTradeRejectionStatisticalReport message is sent by the the trade repositories to the supervisory authority system, to report statistical information on derivatives submissions.
/// </summary>
[Description(@"The DerivativesTradeRejectionStatisticalReport message is sent by the the trade repositories to the supervisory authority system, to report statistical information on derivatives submissions.")]
[IsoId("_F_KeAd1bEeqxpKDfBZC1vg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Derivatives Trade Rejection Statistical Report V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DerivativesTradeRejectionStatisticalReportV02 : IOuterRecord<DerivativesTradeRejectionStatisticalReportV02,DerivativesTradeRejectionStatisticalReportV02Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.092.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradRjctnSttstclRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DerivativesTradeRejectionStatisticalReportV02Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DerivativesTradeRejectionStatisticalReportV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DerivativesTradeRejectionStatisticalReportV02( StatisticsPerCounterparty3Choice_ reqStatisticsPerCounterparty )
    {
        StatisticsPerCounterparty = reqStatisticsPerCounterparty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Detailed information on statistics per combination of counterparties.
    /// </summary>
    [IsoId("_F_KeA91bEeqxpKDfBZC1vg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Statistics Per Counterparty")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatisticsPerCounterparty3Choice_ StatisticsPerCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public StatisticsPerCounterparty3Choice_ StatisticsPerCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticsPerCounterparty3Choice_ StatisticsPerCounterparty { get; init; } 
    #else
    public StatisticsPerCounterparty3Choice_ StatisticsPerCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_F_KeBd1bEeqxpKDfBZC1vg")]
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
    /// Using the state of this record, returns a populated <seealso cref="DerivativesTradeRejectionStatisticalReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DerivativesTradeRejectionStatisticalReportV02Document ToDocument()
    {
        return new DerivativesTradeRejectionStatisticalReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DerivativesTradeRejectionStatisticalReportV02"/>.
/// </summary>
[Serializable]
public partial record DerivativesTradeRejectionStatisticalReportV02Document : IOuterDocument<DerivativesTradeRejectionStatisticalReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.092.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DerivativesTradeRejectionStatisticalReportV02"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DerivativesTradeRejectionStatisticalReportV02 Message { get; init; }
    #else
    public DerivativesTradeRejectionStatisticalReportV02 Message { get; init; }
    #endif
}
