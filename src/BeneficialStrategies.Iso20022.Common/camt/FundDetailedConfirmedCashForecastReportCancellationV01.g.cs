﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FundDetailedConfirmedCashForecastReportCancellationV01.  ISO2002 ID# _a2gBgNE-Ed-BzquC8wXy7w_2024049330.
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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.045.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FundDetailedConfirmedCashForecastReportCancellation message is sent by a report provider, such as a transfer agent or a designated agent of the fund, to a report user, such as an investment manager, a fund accountant or any other interested party.
/// This message is used to cancel a previously sent FundDetailedConfirmedCashForecastReport message.
/// Usage
/// The FundDetailedConfirmedCashForecastReportCancellation message is used to cancel an entire FundDetailedConfirmedCashForecastReport message that was previously sent by the report provider.
/// This message must contain the reference of the message to be cancelled. This message may also contain details of the message to be cancelled, but this is not recommended.
/// </summary>
[Description(@"Scope|The FundDetailedConfirmedCashForecastReportCancellation message is sent by a report provider, such as a transfer agent or a designated agent of the fund, to a report user, such as an investment manager, a fund accountant or any other interested party.|This message is used to cancel a previously sent FundDetailedConfirmedCashForecastReport message.|Usage|The FundDetailedConfirmedCashForecastReportCancellation message is used to cancel an entire FundDetailedConfirmedCashForecastReport message that was previously sent by the report provider.|This message must contain the reference of the message to be cancelled. This message may also contain details of the message to be cancelled, but this is not recommended.")]
[IsoId("_a2gBgNE-Ed-BzquC8wXy7w_2024049330")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Fund Detailed Confirmed Cash Forecast Report Cancellation V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundDetailedConfirmedCashForecastReportCancellationV01 : IOuterRecord<FundDetailedConfirmedCashForecastReportCancellationV01,FundDetailedConfirmedCashForecastReportCancellationV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.045.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.045.001.01";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => FundDetailedConfirmedCashForecastReportCancellationV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FundDetailedConfirmedCashForecastReportCancellationV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundDetailedConfirmedCashForecastReportCancellationV01( AdditionalReference3 reqPreviousReference )
    {
        PreviousReference = reqPreviousReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_a2gBgdE-Ed-BzquC8wXy7w_82888341")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pool Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? PoolReference { get; init; } 
    #else
    public AdditionalReference3? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_a2gBgtE-Ed-BzquC8wXy7w_953093677")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Previous Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalReference3 PreviousReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AdditionalReference3 PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3 PreviousReference { get; init; } 
    #else
    public AdditionalReference3 PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_a2gBg9E-Ed-BzquC8wXy7w_809025064")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Related Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? RelatedReference { get; init; } 
    #else
    public AdditionalReference3? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// The FundDetailedConfirmedCashForecastReport to be cancelled.
    /// </summary>
    [IsoId("_a2gBhNE-Ed-BzquC8wXy7w_1682674827")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash Forecast Report To Be Cancelled")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundDetailedConfirmedCashForecastReport1? CashForecastReportToBeCancelled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundDetailedConfirmedCashForecastReport1? CashForecastReportToBeCancelled { get; init; } 
    #else
    public FundDetailedConfirmedCashForecastReport1? CashForecastReportToBeCancelled { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FundDetailedConfirmedCashForecastReportCancellationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FundDetailedConfirmedCashForecastReportCancellationV01Document ToDocument()
    {
        return new FundDetailedConfirmedCashForecastReportCancellationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FundDetailedConfirmedCashForecastReportCancellationV01"/>.
/// </summary>
[Serializable]
public partial record FundDetailedConfirmedCashForecastReportCancellationV01Document : IOuterDocument<FundDetailedConfirmedCashForecastReportCancellationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.045.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FundDetailedConfirmedCashForecastReportCancellationV01"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FundDetailedConfirmedCashForecastReportCancellationV01 Message { get; init; }
    #else
    public FundDetailedConfirmedCashForecastReportCancellationV01 Message { get; init; }
    #endif
}
