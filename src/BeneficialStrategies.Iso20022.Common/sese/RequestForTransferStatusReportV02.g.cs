﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestForTransferStatusReportV02.  ISO2002 ID# _oGN9ZdE5Ed-BzquC8wXy7w_2033838549.
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


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.009.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, eg, an investment manager or its authorised representative, sends the RequestForTransferStatusReport to the executing party, eg, a transfer agent to request the status of a previously instructed transfer.
/// Usage
/// The RequestForTransferStatusReport is used to request either:
/// - the status of one or several transfer instructions or,
/// - the status of one or several transfer cancellation instructions.
/// </summary>
[Description(@"Scope|An instructing party, eg, an investment manager or its authorised representative, sends the RequestForTransferStatusReport to the executing party, eg, a transfer agent to request the status of a previously instructed transfer.|Usage|The RequestForTransferStatusReport is used to request either:|- the status of one or several transfer instructions or,|- the status of one or several transfer cancellation instructions.")]
[IsoId("_oGN9ZdE5Ed-BzquC8wXy7w_2033838549")]
[DisplayName("Request For Transfer Status Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestForTransferStatusReportV02 : IOuterRecord<RequestForTransferStatusReportV02,RequestForTransferStatusReportV02Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.009.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqForTrfStsRptV02";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => RequestForTransferStatusReportV02Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequestForTransferStatusReportV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestForTransferStatusReportV02( MessageIdentification1 reqMessageIdentification,MessageAndBusinessReference6 reqRequestDetails )
    {
        MessageIdentification = reqMessageIdentification;
        RequestDetails = reqRequestDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_oGN9ZtE5Ed-BzquC8wXy7w_1731455646")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information to identify the transfer for which the status is requested.|.
    /// </summary>
    [IsoId("_oGN9Z9E5Ed-BzquC8wXy7w_2033838559")]
    [DisplayName("Request Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqDtls")]
    #endif
    [IsoXmlTag("ReqDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageAndBusinessReference6 RequestDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageAndBusinessReference6 RequestDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageAndBusinessReference6 RequestDetails { get; init; } 
    #else
    public MessageAndBusinessReference6 RequestDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_oGN9aNE5Ed-BzquC8wXy7w_240300067")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;RequestForTransferStatusReportV02Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestForTransferStatusReportV02Document ToDocument()
    {
        return new RequestForTransferStatusReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;RequestForTransferStatusReportV02&quot;/&gt;.
/// </summary>
[Serializable]
public partial record RequestForTransferStatusReportV02Document : IOuterDocument<RequestForTransferStatusReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.009.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;RequestForTransferStatusReportV02&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RequestForTransferStatusReportV02 Message { get; init; }
    #else
    public RequestForTransferStatusReportV02 Message { get; init; }
    #endif
}
