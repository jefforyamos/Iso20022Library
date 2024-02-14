﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestForOrderStatusReportV02.  ISO2002 ID# _wWrFyNE7Ed-BzquC8wXy7w_-1373686594.
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


namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.018.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RequestForOrderStatusReport is sent by an instructing party, eg, an investment manager or its authorised representative, to the executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party.
/// This message requests the status of one or several order instruction or order cancellation messages.
/// Usage
/// The RequestForOrderStatusReport message is used to request the status of:
/// - one or several order messages,
/// - one or several cancellation messages,
/// - one or several individual orders within a bulk or multiple order message.
/// If the RequestForOrderStatusReport message is used to request the status of several messages, then the instructing party will receive several reply messages from the executing party, ie, several OrderInstructionStatusReport messages and/or OrderCancellationStatusReport messages. The number of reply messages will match the number of references stated in the RequestForOrderStatusReport message.
/// The RequestForOrderStatusReport message may not be used to request the status of an investment account, a transfer or the status of a financial instrument.
/// </summary>
[Description(@"Scope|The RequestForOrderStatusReport is sent by an instructing party, eg, an investment manager or its authorised representative, to the executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party.|This message requests the status of one or several order instruction or order cancellation messages.|Usage|The RequestForOrderStatusReport message is used to request the status of:|- one or several order messages,|- one or several cancellation messages,|- one or several individual orders within a bulk or multiple order message.|If the RequestForOrderStatusReport message is used to request the status of several messages, then the instructing party will receive several reply messages from the executing party, ie, several OrderInstructionStatusReport messages and/or OrderCancellationStatusReport messages. The number of reply messages will match the number of references stated in the RequestForOrderStatusReport message.|The RequestForOrderStatusReport message may not be used to request the status of an investment account, a transfer or the status of a financial instrument.")]
[IsoId("_wWrFyNE7Ed-BzquC8wXy7w_-1373686594")]
[DisplayName("Request For Order Status Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestForOrderStatusReportV02 : IOuterRecord<RequestForOrderStatusReportV02,RequestForOrderStatusReportV02Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.018.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.018.001.02";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => RequestForOrderStatusReportV02Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequestForOrderStatusReportV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestForOrderStatusReportV02( MessageAndBusinessReference2 reqRequestDetails )
    {
        RequestDetails = reqRequestDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information to identify the order(s) for which the status is requested.
    /// </summary>
    [IsoId("_wWrFydE7Ed-BzquC8wXy7w_93958643")]
    [DisplayName("Request Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqDtls")]
    #endif
    [IsoXmlTag("ReqDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageAndBusinessReference2 RequestDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageAndBusinessReference2 RequestDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageAndBusinessReference2 RequestDetails { get; init; } 
    #else
    public MessageAndBusinessReference2 RequestDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;RequestForOrderStatusReportV02Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestForOrderStatusReportV02Document ToDocument()
    {
        return new RequestForOrderStatusReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;RequestForOrderStatusReportV02&quot;/&gt;.
/// </summary>
[Serializable]
public partial record RequestForOrderStatusReportV02Document : IOuterDocument<RequestForOrderStatusReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.018.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;RequestForOrderStatusReportV02&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RequestForOrderStatusReportV02 Message { get; init; }
    #else
    public RequestForOrderStatusReportV02 Message { get; init; }
    #endif
}
