﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MaintenanceDelegationResponseV02.  ISO2002 ID# _FyShYY4HEeWrZqsymMFdfg.
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
/// This record is an implementation of the catm.006.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The master terminal manager provides the outcome of a maintenance delegation request to a terminal manager.
/// </summary>
[Description(@"The master terminal manager provides the outcome of a maintenance delegation request to a terminal manager.")]
[IsoId("_FyShYY4HEeWrZqsymMFdfg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Maintenance Delegation Response V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MaintenanceDelegationResponseV02 : IOuterRecord<MaintenanceDelegationResponseV02,MaintenanceDelegationResponseV02Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.006.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MntncDlgtnRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MaintenanceDelegationResponseV02Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MaintenanceDelegationResponseV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MaintenanceDelegationResponseV02( Header29 reqHeader,MaintenanceDelegationResponse2 reqMaintenanceDelegationResponse )
    {
        Header = reqHeader;
        MaintenanceDelegationResponse = reqMaintenanceDelegationResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Maintenance delegation response message management information.
    /// </summary>
    [IsoId("_FyShY44HEeWrZqsymMFdfg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Header")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header29 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Header29 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header29 Header { get; init; } 
    #else
    public Header29 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the request of maintenance delegations.
    /// </summary>
    [IsoId("_FyShZY4HEeWrZqsymMFdfg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Maintenance Delegation Response")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MaintenanceDelegationResponse2 MaintenanceDelegationResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MaintenanceDelegationResponse2 MaintenanceDelegationResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MaintenanceDelegationResponse2 MaintenanceDelegationResponse { get; init; } 
    #else
    public MaintenanceDelegationResponse2 MaintenanceDelegationResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_FyShZ44HEeWrZqsymMFdfg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Trailer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType12? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType12? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType12? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MaintenanceDelegationResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MaintenanceDelegationResponseV02Document ToDocument()
    {
        return new MaintenanceDelegationResponseV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MaintenanceDelegationResponseV02"/>.
/// </summary>
[Serializable]
public partial record MaintenanceDelegationResponseV02Document : IOuterDocument<MaintenanceDelegationResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.006.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MaintenanceDelegationResponseV02"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MaintenanceDelegationResponseV02 Message { get; init; }
    #else
    public MaintenanceDelegationResponseV02 Message { get; init; }
    #endif
}
