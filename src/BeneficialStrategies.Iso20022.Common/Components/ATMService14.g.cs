﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMService14.  ISO2002 ID# _htdPUa4SEeWZgJQOa6iKCQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Withdrawal service provided by the ATM inside the session.
/// </summary>
[IsoId("_htdPUa4SEeWZgJQOa6iKCQ")]
[DisplayName("ATM Service")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMService14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMService14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMService14( ATMServiceType7Code reqServiceType )
    {
        ServiceType = reqServiceType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_h4Cusa4SEeWZgJQOa6iKCQ")]
    [DisplayName("Service Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcRef")]
    #endif
    [IsoXmlTag("SvcRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ServiceReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceReference { get; init; } 
    #else
    public System.String? ServiceReference { get; set; } 
    #endif
    
    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    [IsoId("_h4Cus64SEeWZgJQOa6iKCQ")]
    [DisplayName("ATM Service Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMSvcCd")]
    #endif
    [IsoXmlTag("ATMSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ATMServiceCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ATMServiceCode { get; init; } 
    #else
    public System.String? ATMServiceCode { get; set; } 
    #endif
    
    /// <summary>
    /// Codification of the type of service for the host.
    /// </summary>
    [IsoId("_h4Cuta4SEeWZgJQOa6iKCQ")]
    [DisplayName("Host Service Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstSvcCd")]
    #endif
    [IsoXmlTag("HstSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? HostServiceCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HostServiceCode { get; init; } 
    #else
    public System.String? HostServiceCode { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the type of transaction selected by the customer.
    /// </summary>
    [IsoId("_h4Cut64SEeWZgJQOa6iKCQ")]
    [DisplayName("Service Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcTp")]
    #endif
    [IsoXmlTag("SvcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMServiceType7Code ServiceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMServiceType7Code ServiceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMServiceType7Code ServiceType { get; init; } 
    #else
    public ATMServiceType7Code ServiceType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    [IsoId("_zFfSIK4SEeWZgJQOa6iKCQ")]
    [DisplayName("Service Variant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcVarntId")]
    #endif
    [IsoXmlTag("SvcVarntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ServiceVariantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceVariantIdentification { get; init; } 
    #else
    public System.String? ServiceVariantIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
