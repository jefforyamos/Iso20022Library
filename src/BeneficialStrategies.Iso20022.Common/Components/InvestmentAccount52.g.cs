﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccount52.  ISO2002 ID# _y6hWMSFSEeWgV9SQSyaAog.
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
/// Information about a securities account and its characteristics.
/// </summary>
[IsoId("_y6hWMSFSEeWgV9SQSyaAog")]
[DisplayName("Investment Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentAccount52
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_zWVvhSFSEeWgV9SQSyaAog")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_zWVvhyFSEeWgV9SQSyaAog")]
    [DisplayName("Designation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dsgnt")]
    #endif
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Designation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Designation { get; init; } 
    #else
    public System.String? Designation { get; set; } 
    #endif
    
    /// <summary>
    /// Legal form of the fund, for example, UCITS, SICAV, OEIC, Unit Trust, and FCP.
    /// </summary>
    [IsoId("_zWVviSFSEeWgV9SQSyaAog")]
    [DisplayName("Fund Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndTp")]
    #endif
    [IsoXmlTag("FndTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FundType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FundType { get; init; } 
    #else
    public System.String? FundType { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_zWVviyFSEeWgV9SQSyaAog")]
    [DisplayName("Fund Family Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndFmlyNm")]
    #endif
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? FundFamilyName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FundFamilyName { get; init; } 
    #else
    public System.String? FundFamilyName { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information about the investment fund associated to the account.
    /// </summary>
    [IsoId("_zWVvjSFSEeWgV9SQSyaAog")]
    [DisplayName("Security Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyDtls")]
    #endif
    [IsoXmlTag("SctyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument45? SecurityDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument45? SecurityDetails { get; init; } 
    #else
    public FinancialInstrument45? SecurityDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Owner of the account.
    /// </summary>
    [IsoId("_fF8jACFTEeWgV9SQSyaAog")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountOwner1Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountOwner1Choice_? AccountOwner { get; init; } 
    #else
    public AccountOwner1Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Intermediary or other party related to the management of the account. In some markets, when this intermediary is a party acting on behalf of the investor for which it has opened an account at, for example, a central securities depository or international central securities depository, this party is known by the investor as the &apos;account controller&apos;.
    /// </summary>
    [IsoId("_zWVvkyFSEeWgV9SQSyaAog")]
    [DisplayName("Intermediary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrmy")]
    #endif
    [IsoXmlTag("Intrmy")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary33> Intermediary { get; init; } = new ValueList<Intermediary33>(){};
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_zWVvlSFSEeWgV9SQSyaAog")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification70Choice_? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification70Choice_? AccountServicer { get; init; } 
    #else
    public PartyIdentification70Choice_? AccountServicer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
