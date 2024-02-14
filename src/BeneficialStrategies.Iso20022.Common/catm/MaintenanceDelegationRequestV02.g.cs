﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MaintenanceDelegationRequestV02.  ISO2002 ID# _u2Rq4Y4BEeWrZqsymMFdfg.
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


namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// This record is an implementation of the catm.005.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// A terminal manager requests to the master terminal manager the delegation of maintenance functions or maintenance operation on the terminal estate managed by the master terminal manager.
/// </summary>
[Description(@"A terminal manager requests to the master terminal manager the delegation of maintenance functions or maintenance operation on the terminal estate managed by the master terminal manager.")]
[IsoId("_u2Rq4Y4BEeWrZqsymMFdfg")]
[DisplayName("Maintenance Delegation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MaintenanceDelegationRequestV02 : IOuterRecord<MaintenanceDelegationRequestV02,MaintenanceDelegationRequestV02Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.005.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MntncDlgtnReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MaintenanceDelegationRequestV02Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MaintenanceDelegationRequestV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MaintenanceDelegationRequestV02( MaintenanceDelegationRequest2 reqMaintenanceDelegationRequest,ContentInformationType12 reqSecurityTrailer )
    {
        MaintenanceDelegationRequest = reqMaintenanceDelegationRequest;
        SecurityTrailer = reqSecurityTrailer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_u2Rq444BEeWrZqsymMFdfg")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Header29? Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header29? Header { get; init; } 
    #else
    public Header29? Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the request of maintenance delegations.
    /// </summary>
    [IsoId("_u2Rq5Y4BEeWrZqsymMFdfg")]
    [DisplayName("Maintenance Delegation Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MntncDlgtnReq")]
    #endif
    [IsoXmlTag("MntncDlgtnReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MaintenanceDelegationRequest2 MaintenanceDelegationRequest { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MaintenanceDelegationRequest2 MaintenanceDelegationRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MaintenanceDelegationRequest2 MaintenanceDelegationRequest { get; init; } 
    #else
    public MaintenanceDelegationRequest2 MaintenanceDelegationRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_u2Rq544BEeWrZqsymMFdfg")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContentInformationType12 SecurityTrailer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContentInformationType12 SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType12 SecurityTrailer { get; init; } 
    #else
    public ContentInformationType12 SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;MaintenanceDelegationRequestV02Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MaintenanceDelegationRequestV02Document ToDocument()
    {
        return new MaintenanceDelegationRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;MaintenanceDelegationRequestV02&quot;/&gt;.
/// </summary>
[Serializable]
public partial record MaintenanceDelegationRequestV02Document : IOuterDocument<MaintenanceDelegationRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.005.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;MaintenanceDelegationRequestV02&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MaintenanceDelegationRequestV02 Message { get; init; }
    #else
    public MaintenanceDelegationRequestV02 Message { get; init; }
    #endif
}
