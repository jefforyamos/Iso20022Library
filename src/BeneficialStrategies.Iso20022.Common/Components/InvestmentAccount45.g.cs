﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccount45.  ISO2002 ID# _uE_94QgwEeSy_NqeitQG4Q.
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
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
[IsoId("_uE_94QgwEeSy_NqeitQG4Q")]
[DisplayName("Investment Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentAccount45
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentAccount45 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentAccount45( AccountIdentification1 reqAccountIdentification )
    {
        AccountIdentification = reqAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_ueusgwgwEeSy_NqeitQG4Q")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification1 AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification1 AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification1 AccountIdentification { get; init; } 
    #else
    public AccountIdentification1 AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_ueushQgwEeSy_NqeitQG4Q")]
    [DisplayName("Account Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctNm")]
    #endif
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountName { get; init; } 
    #else
    public System.String? AccountName { get; set; } 
    #endif
    
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_ueushwgwEeSy_NqeitQG4Q")]
    [DisplayName("Account Designation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDsgnt")]
    #endif
    [IsoXmlTag("AcctDsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountDesignation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountDesignation { get; init; } 
    #else
    public System.String? AccountDesignation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the owner of the account.
    /// </summary>
    [IsoId("_2WM_EQgwEeSy_NqeitQG4Q")]
    [DisplayName("Owner Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnrId")]
    #endif
    [IsoXmlTag("OwnrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OwnerIdentification1Choice_? OwnerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OwnerIdentification1Choice_? OwnerIdentification { get; init; } 
    #else
    public OwnerIdentification1Choice_? OwnerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_ueusjQgwEeSy_NqeitQG4Q")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    #else
    public PartyIdentification2Choice_? AccountServicer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
