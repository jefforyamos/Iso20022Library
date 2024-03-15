﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstitutionIdentification19.  ISO2002 ID# _N5WqoW5OEeiU9cctagi5ow.
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
/// Identification of a financial institution.
/// </summary>
[IsoId("_N5WqoW5OEeiU9cctagi5ow")]
[DisplayName("Financial Institution Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstitutionIdentification19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Business identification code of the financial institution.
    /// </summary>
    [IsoId("_ODyZAW5OEeiU9cctagi5ow")]
    [DisplayName("BICFI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BICFI")]
    #endif
    [IsoXmlTag("BICFI")]
    [IsoSimpleType(IsoSimpleType.BICFIDec2014Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBICFIDec2014Identifier? BICFI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BICFI { get; init; } 
    #else
    public System.String? BICFI { get; set; } 
    #endif
    
    /// <summary>
    /// Information used to identify a member within a clearing system.
    /// </summary>
    [IsoId("_ODyZA25OEeiU9cctagi5ow")]
    [DisplayName("Clearing System Member Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSysMmbId")]
    #endif
    [IsoXmlTag("ClrSysMmbId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; } 
    #else
    public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_jnptgK9REeiTd4HhN4n9hw")]
    [DisplayName("LEI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LEI")]
    #endif
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? LEI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LEI { get; init; } 
    #else
    public System.String? LEI { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of an agent, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_ODyZBW5OEeiU9cctagi5ow")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericFinancialIdentification1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericFinancialIdentification1? Other { get; init; } 
    #else
    public GenericFinancialIdentification1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
