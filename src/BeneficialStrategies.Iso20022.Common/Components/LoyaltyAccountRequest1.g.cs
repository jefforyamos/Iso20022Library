﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoyaltyAccountRequest1.  ISO2002 ID# _6K8t8NuIEeiB5uLfkg9ZJA.
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
/// Data related to a requested Loyalty program or account.
/// </summary>
[IsoId("_6K8t8NuIEeiB5uLfkg9ZJA")]
[DisplayName("Loyalty Account Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoyaltyAccountRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// To retrieve Card Acquisition Data.
    /// </summary>
    [IsoId("_BaKtsNuJEeiB5uLfkg9ZJA")]
    [DisplayName("Customer Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrOrdr")]
    #endif
    [IsoXmlTag("CstmrOrdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerOrder1? CustomerOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerOrder1? CustomerOrder { get; init; } 
    #else
    public CustomerOrder1? CustomerOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_FlL8oNuJEeiB5uLfkg9ZJA")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyAccount1? Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyAccount1? Account { get; init; } 
    #else
    public LoyaltyAccount1? Account { get; set; } 
    #endif
    
    
    #nullable disable
    
}
