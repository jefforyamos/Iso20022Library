﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Proposal6.  ISO2002 ID# _5BYWQSqREeyR9JrVGfaMKw.
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
/// Indicates the type of proposal and if the proposal is for the variation margin and the segregated independent amount, or the segregated independent amount only.
/// </summary>
[IsoId("_5BYWQSqREeyR9JrVGfaMKw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Proposal")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Proposal6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Proposal6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Proposal6( ProposalType1Code reqCollateralProposalType,CollateralProposal6Choice_ reqCollateralProposal )
    {
        CollateralProposalType = reqCollateralProposalType;
        CollateralProposal = reqCollateralProposal;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether this is an initial or counter proposal.
    /// </summary>
    [IsoId("_5ZX_gSqREeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral Proposal Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProposalType1Code CollateralProposalType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ProposalType1Code CollateralProposalType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProposalType1Code CollateralProposalType { get; init; } 
    #else
    public ProposalType1Code CollateralProposalType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the proposal for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [IsoId("_5ZX_gyqREeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral Proposal")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralProposal6Choice_ CollateralProposal { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CollateralProposal6Choice_ CollateralProposal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralProposal6Choice_ CollateralProposal { get; init; } 
    #else
    public CollateralProposal6Choice_ CollateralProposal { get; set; } 
    #endif
    
    
    #nullable disable
    
}
