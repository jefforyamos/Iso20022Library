﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TargetMarket1.  ISO2002 ID# _z1KXQDQpEeifw8iDiyZLmQ.
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
/// Target market criteria.
/// </summary>
[IsoId("_z1KXQDQpEeifw8iDiyZLmQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Target Market")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TargetMarket1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Investor for which the financial instrument is targeted.
    /// </summary>
    [IsoId("_CQTyMDQqEeifw8iDiyZLmQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Investor Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorType1? InvestorType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorType1? InvestorType { get; init; } 
    #else
    public InvestorType1? InvestorType { get; set; } 
    #endif
    
    /// <summary>
    /// Knowledge and/or experience of the investor.
    /// </summary>
    [IsoId("_EkCIUDQqEeifw8iDiyZLmQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Knowledge And Or Experience")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorKnowledge1? KnowledgeAndOrExperience { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorKnowledge1? KnowledgeAndOrExperience { get; init; } 
    #else
    public InvestorKnowledge1? KnowledgeAndOrExperience { get; set; } 
    #endif
    
    /// <summary>
    /// Investor’s ability to bear losses.
    /// </summary>
    [IsoId("_GIdvgDQqEeifw8iDiyZLmQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Ability To Bear Losses")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LossBearing1? AbilityToBearLosses { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LossBearing1? AbilityToBearLosses { get; init; } 
    #else
    public LossBearing1? AbilityToBearLosses { get; set; } 
    #endif
    
    /// <summary>
    /// Investor’s tolerance to risk.
    /// </summary>
    [IsoId("_I7IrcDQqEeifw8iDiyZLmQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Risk Tolerance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RiskTolerance1? RiskTolerance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RiskTolerance1? RiskTolerance { get; init; } 
    #else
    public RiskTolerance1? RiskTolerance { get; set; } 
    #endif
    
    /// <summary>
    /// Investor’s investment requirements.
    /// </summary>
    [IsoId("_Kap9cDQqEeifw8iDiyZLmQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Client Objectives And Needs")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorRequirements1? ClientObjectivesAndNeeds { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorRequirements1? ClientObjectivesAndNeeds { get; init; } 
    #else
    public InvestorRequirements1? ClientObjectivesAndNeeds { get; set; } 
    #endif
    
    /// <summary>
    /// Other target market parameter.
    /// </summary>
    [IsoId("_ykOcsD8SEeih8-WNbS6hbA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherTargetMarket1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherTargetMarket1? Other { get; init; } 
    #else
    public OtherTargetMarket1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
