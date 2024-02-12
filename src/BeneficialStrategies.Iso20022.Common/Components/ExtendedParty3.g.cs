﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ExtendedParty3.  ISO2002 ID# _DrH9IROFEeKjmvxNCObNeQ.
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
/// Other type of party.
/// </summary>
[IsoId("_DrH9IROFEeKjmvxNCObNeQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Extended Party")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExtendedParty3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ExtendedParty3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ExtendedParty3( System.String reqExtendedPartyRole,InvestmentAccountOwnershipInformation6 reqOtherPartyDetails )
    {
        ExtendedPartyRole = reqExtendedPartyRole;
        OtherPartyDetails = reqOtherPartyDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Other type of party's role.
    /// </summary>
    [IsoId("_EAIj0ROFEeKjmvxNCObNeQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Extended Party Role")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedPartyRole { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ExtendedPartyRole { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedPartyRole { get; init; } 
    #else
    public System.String ExtendedPartyRole { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed ownership information about a party.
    /// </summary>
    [IsoId("_EAIj1ROFEeKjmvxNCObNeQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other Party Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccountOwnershipInformation6 OtherPartyDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public InvestmentAccountOwnershipInformation6 OtherPartyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation6 OtherPartyDetails { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation6 OtherPartyDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
