﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for UndertakingStatusReportV01.  ISO2002 ID# _9h8tJXltEeG7BsjMvd1mEw_-329334493.
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


namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// This record is an implementation of the tsrv.019.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingStatusReport message is exchanged between parties that have an interest in the referenced undertaking transaction. It notifies the recipient of the status of the transaction, such as acceptance or rejection, withdrawal, or non-conformation. The sender may add additional information, as appropriate.
/// </summary>
[Description(@"The UndertakingStatusReport message is exchanged between parties that have an interest in the referenced undertaking transaction. It notifies the recipient of the status of the transaction, such as acceptance or rejection, withdrawal, or non-conformation. The sender may add additional information, as appropriate.")]
[IsoId("_9h8tJXltEeG7BsjMvd1mEw_-329334493")]
[DisplayName("Undertaking Status Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingStatusReportV01 : IOuterRecord<UndertakingStatusReportV01,UndertakingStatusReportV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.019.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgStsRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => UndertakingStatusReportV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingStatusReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingStatusReportV01( UndertakingStatusAdvice1 reqUndertakingStatusReportDetails )
    {
        UndertakingStatusReportDetails = reqUndertakingStatusReportDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details of the undertaking status report.
    /// </summary>
    [IsoId("_9h8tJnltEeG7BsjMvd1mEw_-1217857261")]
    [DisplayName("Undertaking Status Report Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgStsRptDtls")]
    #endif
    [IsoXmlTag("UdrtkgStsRptDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingStatusAdvice1 UndertakingStatusReportDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingStatusAdvice1 UndertakingStatusReportDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingStatusAdvice1 UndertakingStatusReportDetails { get; init; } 
    #else
    public UndertakingStatusAdvice1 UndertakingStatusReportDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature of the report.
    /// </summary>
    [IsoId("_9h8tJ3ltEeG7BsjMvd1mEw_1390197264")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature2? DigitalSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;UndertakingStatusReportV01Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public UndertakingStatusReportV01Document ToDocument()
    {
        return new UndertakingStatusReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;UndertakingStatusReportV01&quot;/&gt;.
/// </summary>
[Serializable]
public partial record UndertakingStatusReportV01Document : IOuterDocument<UndertakingStatusReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.019.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;UndertakingStatusReportV01&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingStatusReportV01 Message { get; init; }
    #else
    public UndertakingStatusReportV01 Message { get; init; }
    #endif
}
