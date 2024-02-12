﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TargetMarket3.  ISO2002 ID# _XXkGEc0SEeuAE-cYsQdwHQ.
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
[IsoId("_XXkGEc0SEeuAE-cYsQdwHQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Target Market")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TargetMarket3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date to which the target market data refers. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 01000.
    /// </summary>
    [IsoId("_Xtt8Qc0SEeuAE-cYsQdwHQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reference Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ReferenceDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ReferenceDate { get; init; } 
    #else
    public System.DateOnly? ReferenceDate { get; set; } 
    #endif
    
    /// <summary>
    /// Investor for which the financial instrument is targeted.
    /// </summary>
    [IsoId("_XtujUc0SEeuAE-cYsQdwHQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Investor Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorType2? InvestorType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorType2? InvestorType { get; init; } 
    #else
    public InvestorType2? InvestorType { get; set; } 
    #endif
    
    /// <summary>
    /// Knowledge and/or experience of the investor.
    /// </summary>
    [IsoId("_XtujU80SEeuAE-cYsQdwHQ")]
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
    [IsoId("_XtujVc0SEeuAE-cYsQdwHQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Ability To Bear Losses")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LossBearing2? AbilityToBearLosses { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LossBearing2? AbilityToBearLosses { get; init; } 
    #else
    public LossBearing2? AbilityToBearLosses { get; set; } 
    #endif
    
    /// <summary>
    /// Investor’s tolerance to risk.
    /// </summary>
    [IsoId("_XtujV80SEeuAE-cYsQdwHQ")]
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
    [IsoId("_XtujWc0SEeuAE-cYsQdwHQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Client Objectives And Needs")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorRequirements3? ClientObjectivesAndNeeds { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorRequirements3? ClientObjectivesAndNeeds { get; init; } 
    #else
    public InvestorRequirements3? ClientObjectivesAndNeeds { get; set; } 
    #endif
    
    /// <summary>
    /// Other target market parameter.
    /// </summary>
    [IsoId("_XtujW80SEeuAE-cYsQdwHQ")]
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
