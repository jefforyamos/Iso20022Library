﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransactionReportRequestV03.  ISO2002 ID# _15W1yNE8Ed-BzquC8wXy7w_-2039439363.
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


namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.042.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransactionReportRequest message is sent by a party involved in a transaction to the matching application.
/// This message is used to request a report on details of transactions registered in the matching application.
/// Usage
/// The TransactionReportRequest message can be sent by either party involved in a transaction to request a report on a variety of details of all transactions that the requester is involved in. For example, the message can be used to request a report on all transactions that the requester is involved in with a certain customer.
/// </summary>
[Description(@"Scope|The TransactionReportRequest message is sent by a party involved in a transaction to the matching application.|This message is used to request a report on details of transactions registered in the matching application.|Usage|The TransactionReportRequest message can be sent by either party involved in a transaction to request a report on a variety of details of all transactions that the requester is involved in. For example, the message can be used to request a report on all transactions that the requester is involved in with a certain customer.")]
[IsoId("_15W1yNE8Ed-BzquC8wXy7w_-2039439363")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Transaction Report Request V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionReportRequestV03 : IOuterRecord<TransactionReportRequestV03,TransactionReportRequestV03Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.042.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TxRptReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => TransactionReportRequestV03Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionReportRequestV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionReportRequestV03( MessageIdentification1 reqRequestIdentification,ReportSpecification4 reqReportSpecification )
    {
        RequestIdentification = reqRequestIdentification;
        ReportSpecification = reqReportSpecification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the request message.
    /// </summary>
    [IsoId("_15W1ydE8Ed-BzquC8wXy7w_-2039438961")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Request Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 RequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MessageIdentification1 RequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 RequestIdentification { get; init; } 
    #else
    public MessageIdentification1 RequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters to be used as criteria for the content of the transaction report.
    /// </summary>
    [IsoId("_15W1ytE8Ed-BzquC8wXy7w_-2039439323")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Report Specification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportSpecification4 ReportSpecification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ReportSpecification4 ReportSpecification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportSpecification4 ReportSpecification { get; init; } 
    #else
    public ReportSpecification4 ReportSpecification { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransactionReportRequestV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransactionReportRequestV03Document ToDocument()
    {
        return new TransactionReportRequestV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransactionReportRequestV03"/>.
/// </summary>
[Serializable]
public partial record TransactionReportRequestV03Document : IOuterDocument<TransactionReportRequestV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.042.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransactionReportRequestV03"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionReportRequestV03 Message { get; init; }
    #else
    public TransactionReportRequestV03 Message { get; init; }
    #endif
}
