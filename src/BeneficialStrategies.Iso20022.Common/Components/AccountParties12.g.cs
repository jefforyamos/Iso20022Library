﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountParties12.  ISO2002 ID# _I9Ac_QhDEeSUPbC7DbLJpQ.
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
/// Information about a party's account.
/// </summary>
[IsoId("_I9Ac_QhDEeSUPbC7DbLJpQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Account Parties")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountParties12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountParties12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountParties12( AccountParties7Choice_ reqPrincipalAccountParty )
    {
        PrincipalAccountParty = reqPrincipalAccountParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    [IsoId("_JYYKVwhDEeSUPbC7DbLJpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Principal Account Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountParties7Choice_ PrincipalAccountParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AccountParties7Choice_ PrincipalAccountParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountParties7Choice_ PrincipalAccountParty { get; init; } 
    #else
    public AccountParties7Choice_ PrincipalAccountParty { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_JYYKWQhDEeSUPbC7DbLJpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Secondary Owner")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation10? SecondaryOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation10? SecondaryOwner { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation10? SecondaryOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_JYYKWwhDEeSUPbC7DbLJpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Beneficiary")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation10? Beneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation10? Beneficiary { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation10? Beneficiary { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_JYYKXQhDEeSUPbC7DbLJpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Power Of Attorney")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation10? PowerOfAttorney { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation10? PowerOfAttorney { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation10? PowerOfAttorney { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_JYYKXwhDEeSUPbC7DbLJpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Legal Guardian")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation10? LegalGuardian { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation10? LegalGuardian { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation10? LegalGuardian { get; set; } 
    #endif
    
    /// <summary>
    /// Deceased's estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_JYYKYQhDEeSUPbC7DbLJpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Successor On Death")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(5)]
    #endif
    public ValueList<InvestmentAccountOwnershipInformation10> SuccessorOnDeath { get; init; } = new ValueList<InvestmentAccountOwnershipInformation10>(){};
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_JYYKYwhDEeSUPbC7DbLJpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Administrator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation10? Administrator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation10? Administrator { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation10? Administrator { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_JYYKZQhDEeSUPbC7DbLJpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExtendedParty7? OtherParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExtendedParty7? OtherParty { get; init; } 
    #else
    public ExtendedParty7? OtherParty { get; set; } 
    #endif
    
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_JYYKZwhDEeSUPbC7DbLJpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Granter")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(5)]
    #endif
    public ValueList<InvestmentAccountOwnershipInformation10> Granter { get; init; } = new ValueList<InvestmentAccountOwnershipInformation10>(){};
    
    /// <summary>
    /// Entity that creates a trust or contributes assets to the trust.
    /// </summary>
    [IsoId("_JYYKaQhDEeSUPbC7DbLJpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(5)]
    #endif
    public ValueList<InvestmentAccountOwnershipInformation10> Settlor { get; init; } = new ValueList<InvestmentAccountOwnershipInformation10>(){};
    
    
    #nullable disable
    
}
