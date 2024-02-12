﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountSubLevel14.  ISO2002 ID# _s1xFgVjBEea1XpTdyimpLA.
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
/// Account and holding of the next sub-level (Level 4).
/// </summary>
[IsoId("_s1xFgVjBEea1XpTdyimpLA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Account Sub Level")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountSubLevel14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountSubLevel14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountSubLevel14( SecuritiesAccount19 reqAccountIdentification,PartyIdentification100 reqAccountOwner,PartyIdentification100 reqAccountServicer )
    {
        AccountIdentification = reqAccountIdentification;
        AccountOwner = reqAccountOwner;
        AccountServicer = reqAccountServicer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the sub-account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_tQ138VjBEea1XpTdyimpLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount19 AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecuritiesAccount19 AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19 AccountIdentification { get; init; } 
    #else
    public SecuritiesAccount19 AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the sub-account.
    /// </summary>
    [IsoId("_tQ1381jBEea1XpTdyimpLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Owner")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification100 AccountOwner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification100 AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification100 AccountOwner { get; init; } 
    #else
    public PartyIdentification100 AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the sub-level account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_tQ139VjBEea1XpTdyimpLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Servicer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification100 AccountServicer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification100 AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification100 AccountServicer { get; init; } 
    #else
    public PartyIdentification100 AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    [IsoId("_tQ1391jBEea1XpTdyimpLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Beneficial Owner")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficialOwner2? BeneficialOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficialOwner2? BeneficialOwner { get; init; } 
    #else
    public BeneficialOwner2? BeneficialOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Report on the net position of a financial instrument on the sub-account (sub-account level 4), for a certain date. The agent, for example, a trade intermediary, may also be specified.
    /// </summary>
    [IsoId("_xAhOsVjBEea1XpTdyimpLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateHoldingBalance3? BalanceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateHoldingBalance3? BalanceDetails { get; init; } 
    #else
    public AggregateHoldingBalance3? BalanceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Holdings of level 5.
    /// </summary>
    [IsoId("_tQ13-1jBEea1XpTdyimpLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Sub Level")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountSubLevel15? AccountSubLevel5 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountSubLevel15? AccountSubLevel5 { get; init; } 
    #else
    public AccountSubLevel15? AccountSubLevel5 { get; set; } 
    #endif
    
    /// <summary>
    /// Difference in holdings between the sub-account at level 4 and the sub-accounts of level 5.
    /// </summary>
    [IsoId("_tQ13_VjBEea1XpTdyimpLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Sub Level 5 Difference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateHoldingBalance2? AccountSubLevel5Difference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateHoldingBalance2? AccountSubLevel5Difference { get; init; } 
    #else
    public AggregateHoldingBalance2? AccountSubLevel5Difference { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_tQ14AVjBEea1XpTdyimpLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
