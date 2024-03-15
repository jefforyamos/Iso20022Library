﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcquirerRejection.  ISO2002 ID# _ohEDEHvSEeS2PZh7wUMQog.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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


namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// This record is an implementation of the cain.013.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcquirerRejection message is sent by any party, to reject an Acquirer to Issuer message.
/// </summary>
[Description(@"The AcquirerRejection message is sent by any party, to reject an Acquirer to Issuer message.")]
[IsoId("_ohEDEHvSEeS2PZh7wUMQog")]
[DisplayName("Acquirer Rejection")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcquirerRejection : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.013.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcqrrRjctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.013.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcquirerRejection instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcquirerRejection( Header19 reqHeader,AcceptorRejection4 reqReject )
    {
        Header = reqHeader;
        Reject = reqReject;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_DiKccHvUEeS7Wv4oKCO8_A")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header19 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header19 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header19 Header { get; init; } 
    #else
    public Header19 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the reject.
    /// </summary>
    [IsoId("_e8V5oHvUEeS7Wv4oKCO8_A")]
    [DisplayName("Reject")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rjct")]
    #endif
    [IsoXmlTag("Rjct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorRejection4 Reject { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptorRejection4 Reject { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorRejection4 Reject { get; init; } 
    #else
    public AcceptorRejection4 Reject { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AcquirerRejectionDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcquirerRejection.

