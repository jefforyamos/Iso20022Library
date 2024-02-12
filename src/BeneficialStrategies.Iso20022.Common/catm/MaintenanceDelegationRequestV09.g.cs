﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MaintenanceDelegationRequestV09.  ISO2002 ID# _FWjj0XPUEe2pK6udhxEaHA.
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
/// This record is an implementation of the catm.005.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The MaintenanceDelegationRequest message is sent by a terminal manager to the master terminal manager to request delegation of maintenance functions or maintenance operation on the terminal estate managed by the master terminal manager.
/// </summary>
[Description(@"The MaintenanceDelegationRequest message is sent by a terminal manager to the master terminal manager to request delegation of maintenance functions or maintenance operation on the terminal estate managed by the master terminal manager.")]
[IsoId("_FWjj0XPUEe2pK6udhxEaHA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Maintenance Delegation Request V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MaintenanceDelegationRequestV09 : IOuterRecord<MaintenanceDelegationRequestV09,MaintenanceDelegationRequestV09Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.005.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MntncDlgtnReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MaintenanceDelegationRequestV09Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MaintenanceDelegationRequestV09 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MaintenanceDelegationRequestV09( MaintenanceDelegationRequest9 reqMaintenanceDelegationRequest,ContentInformationType33 reqSecurityTrailer )
    {
        MaintenanceDelegationRequest = reqMaintenanceDelegationRequest;
        SecurityTrailer = reqSecurityTrailer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_FWjj03PUEe2pK6udhxEaHA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Header")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TMSHeader1? Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TMSHeader1? Header { get; init; } 
    #else
    public TMSHeader1? Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the request of maintenance delegations.
    /// </summary>
    [IsoId("_FWjj1XPUEe2pK6udhxEaHA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Maintenance Delegation Request")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MaintenanceDelegationRequest9 MaintenanceDelegationRequest { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MaintenanceDelegationRequest9 MaintenanceDelegationRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MaintenanceDelegationRequest9 MaintenanceDelegationRequest { get; init; } 
    #else
    public MaintenanceDelegationRequest9 MaintenanceDelegationRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_FWjj13PUEe2pK6udhxEaHA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Trailer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContentInformationType33 SecurityTrailer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ContentInformationType33 SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType33 SecurityTrailer { get; init; } 
    #else
    public ContentInformationType33 SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MaintenanceDelegationRequestV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MaintenanceDelegationRequestV09Document ToDocument()
    {
        return new MaintenanceDelegationRequestV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MaintenanceDelegationRequestV09"/>.
/// </summary>
[Serializable]
public partial record MaintenanceDelegationRequestV09Document : IOuterDocument<MaintenanceDelegationRequestV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.005.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MaintenanceDelegationRequestV09"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MaintenanceDelegationRequestV09 Message { get; init; }
    #else
    public MaintenanceDelegationRequestV09 Message { get; init; }
    #endif
}
