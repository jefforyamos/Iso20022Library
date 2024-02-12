﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StatusReportRequestV03.  ISO2002 ID# _0n_7mNE8Ed-BzquC8wXy7w_-619721878.
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
/// This record is an implementation of the tsmt.038.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusReportRequest message is sent by a party involved in a transaction to the matching application.
/// This message is used to request a report on the status of transactions registered in the matching application.
/// Usage
/// The StatusReportRequest message can be sent by either party involved in a transaction to request a report on the status and sub-statuses of all transactions that the requester is involved in.
/// The application will respond to the request by sending a StatusReport message.
/// </summary>
[Description(@"Scope|The StatusReportRequest message is sent by a party involved in a transaction to the matching application.|This message is used to request a report on the status of transactions registered in the matching application.|Usage|The StatusReportRequest message can be sent by either party involved in a transaction to request a report on the status and sub-statuses of all transactions that the requester is involved in.|The application will respond to the request by sending a StatusReport message.")]
[IsoId("_0n_7mNE8Ed-BzquC8wXy7w_-619721878")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Status Report Request V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusReportRequestV03 : IOuterRecord<StatusReportRequestV03,StatusReportRequestV03Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.038.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsRptReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => StatusReportRequestV03Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusReportRequestV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusReportRequestV03( MessageIdentification1 reqRequestIdentification )
    {
        RequestIdentification = reqRequestIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the request message.
    /// </summary>
    [IsoId("_0n_7mdE8Ed-BzquC8wXy7w_-619721785")]
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
    /// Specifies the entities of the submitter for which the transactions have to be reported.
    /// </summary>
    [IsoId("_0n_7mtE8Ed-BzquC8wXy7w_-619721446")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Entities To Be Reported")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BICIdentification1? EntitiesToBeReported { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1? EntitiesToBeReported { get; init; } 
    #else
    public BICIdentification1? EntitiesToBeReported { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StatusReportRequestV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StatusReportRequestV03Document ToDocument()
    {
        return new StatusReportRequestV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="StatusReportRequestV03"/>.
/// </summary>
[Serializable]
public partial record StatusReportRequestV03Document : IOuterDocument<StatusReportRequestV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.038.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StatusReportRequestV03"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatusReportRequestV03 Message { get; init; }
    #else
    public StatusReportRequestV03 Message { get; init; }
    #endif
}
