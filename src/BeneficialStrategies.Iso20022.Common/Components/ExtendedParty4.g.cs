﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ExtendedParty4.  ISO2002 ID# _Sxi3wROHEeKjmvxNCObNeQ.
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
/// Other type of party.
/// </summary>
[IsoId("_Sxi3wROHEeKjmvxNCObNeQ")]
[DisplayName("Extended Party")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExtendedParty4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ExtendedParty4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ExtendedParty4( System.String reqExtendedPartyRole,InvestmentAccountOwnershipInformation7 reqOtherPartyDetails )
    {
        ExtendedPartyRole = reqExtendedPartyRole;
        OtherPartyDetails = reqOtherPartyDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Other type of party&apos;s role.
    /// </summary>
    [IsoId("_TGtPcROHEeKjmvxNCObNeQ")]
    [DisplayName("Extended Party Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedPtyRole")]
    #endif
    [IsoXmlTag("XtndedPtyRole")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedPartyRole { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedPartyRole { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedPartyRole { get; init; } 
    #else
    public System.String ExtendedPartyRole { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed ownership information about a party.
    /// </summary>
    [IsoId("_TGtPdROHEeKjmvxNCObNeQ")]
    [DisplayName("Other Party Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPtyDtls")]
    #endif
    [IsoXmlTag("OthrPtyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccountOwnershipInformation7 OtherPartyDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccountOwnershipInformation7 OtherPartyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation7 OtherPartyDetails { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation7 OtherPartyDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
