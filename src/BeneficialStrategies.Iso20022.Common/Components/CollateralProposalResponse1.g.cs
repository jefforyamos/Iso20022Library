﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralProposalResponse1.  ISO2002 ID# _Un0dutp-Ed-ak6NoX_4Aeg_1374174596.
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
/// Provides the collateral proposal response for the variation margin and optionaly the segregated independent amount.
/// </summary>
[IsoId("_Un0dutp-Ed-ak6NoX_4Aeg_1374174596")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Collateral Proposal Response")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralProposalResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralProposalResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralProposalResponse1( CollateralProposalResponseType1 reqVariationMargin )
    {
        VariationMargin = reqVariationMargin;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the collateral proposal response for the variation margin.
    /// </summary>
    [IsoId("_Un-OsNp-Ed-ak6NoX_4Aeg_1523875178")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Variation Margin")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralProposalResponseType1 VariationMargin { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CollateralProposalResponseType1 VariationMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralProposalResponseType1 VariationMargin { get; init; } 
    #else
    public CollateralProposalResponseType1 VariationMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the collateral proposal response for the segregated independent amount.
    /// </summary>
    [IsoId("_Un-Osdp-Ed-ak6NoX_4Aeg_495998961")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Segregated Independent Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralProposalResponseType1? SegregatedIndependentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralProposalResponseType1? SegregatedIndependentAmount { get; init; } 
    #else
    public CollateralProposalResponseType1? SegregatedIndependentAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
