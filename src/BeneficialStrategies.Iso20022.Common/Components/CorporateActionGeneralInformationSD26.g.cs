﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformationSD26.  ISO2002 ID# _5UBlEZEsEeajS_7NioJdVA.
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
/// Provides additional information regarding corporate action general information.
/// </summary>
[IsoId("_5UBlEZEsEeajS_7NioJdVA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action General Information SD")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionGeneralInformationSD26
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionGeneralInformationSD26 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionGeneralInformationSD26( System.String reqPlaceAndName,SecurityIdentification15 reqSecurityIdentification,System.String reqSafekeepingAccount )
    {
        PlaceAndName = reqPlaceAndName;
        SecurityIdentification = reqSecurityIdentification;
        SafekeepingAccount = reqSafekeepingAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_5rYVIZEsEeajS_7NioJdVA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Place And Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_5rYVI5EsEeajS_7NioJdVA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification15 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecurityIdentification15 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification15 SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification15 SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_5rYVMZEsEeajS_7NioJdVA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Safekeeping Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SafekeepingAccount { get; init; } 
    #else
    public System.String SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the corporate action event.
    /// </summary>
    [IsoId("_5rYVP5EsEeajS_7NioJdVA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unallocated Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionUnallocatedDetailsSD5? UnallocatedDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionUnallocatedDetailsSD5? UnallocatedDetails { get; init; } 
    #else
    public CorporateActionUnallocatedDetailsSD5? UnallocatedDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
