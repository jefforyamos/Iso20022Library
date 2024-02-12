﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMService20.  ISO2002 ID# _pwwdwa4aEeW_TaP-ygI0SQ.
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
/// Context in which the transaction is performed.
/// </summary>
[IsoId("_pwwdwa4aEeW_TaP-ygI0SQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("ATM Service")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMService20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMService20 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMService20( ATMServiceType5Code reqServiceType )
    {
        ServiceType = reqServiceType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the withdrawal service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_p7VWEa4aEeW_TaP-ygI0SQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Service Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
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
    [IsoId("_p7VWE64aEeW_TaP-ygI0SQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("ATM Service Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ATMServiceCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ATMServiceCode { get; init; } 
    #else
    public System.String? ATMServiceCode { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the type of inquiry selected by the customer or the ATM.
    /// </summary>
    [IsoId("_p7VWFa4aEeW_TaP-ygI0SQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Service Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMServiceType5Code ServiceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ATMServiceType5Code ServiceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMServiceType5Code ServiceType { get; init; } 
    #else
    public ATMServiceType5Code ServiceType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    [IsoId("_x56WMK4aEeW_TaP-ygI0SQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Service Variant Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ServiceVariantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceVariantIdentification { get; init; } 
    #else
    public System.String? ServiceVariantIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
