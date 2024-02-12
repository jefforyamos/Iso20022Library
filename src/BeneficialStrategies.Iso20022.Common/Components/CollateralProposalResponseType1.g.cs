﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralProposalResponseType1.  ISO2002 ID# _Un0dsdp-Ed-ak6NoX_4Aeg_2130391972.
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
/// Provides details on the response for a collateral proposal.
/// </summary>
[IsoId("_Un0dsdp-Ed-ak6NoX_4Aeg_2130391972")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Collateral Proposal Response Type")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralProposalResponseType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralProposalResponseType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralProposalResponseType1( System.String reqCollateralProposalIdentification,CollateralProposalResponse1Code reqType,Status4Code reqResponseType )
    {
        CollateralProposalIdentification = reqCollateralProposalIdentification;
        Type = reqType;
        ResponseType = reqResponseType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a collateral proposal.
    /// </summary>
    [IsoId("_Un0dstp-Ed-ak6NoX_4Aeg_218527511")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral Proposal Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CollateralProposalIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String CollateralProposalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CollateralProposalIdentification { get; init; } 
    #else
    public System.String CollateralProposalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the collateral proposal is an initial or a counter proposal.
    /// </summary>
    [IsoId("_Un0ds9p-Ed-ak6NoX_4Aeg_-14002491")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralProposalResponse1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CollateralProposalResponse1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralProposalResponse1Code Type { get; init; } 
    #else
    public CollateralProposalResponse1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of the collateral proposal.
    /// </summary>
    [IsoId("_Un0dtNp-Ed-ak6NoX_4Aeg_901549876")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Response Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status4Code ResponseType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Status4Code ResponseType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status4Code ResponseType { get; init; } 
    #else
    public Status4Code ResponseType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason why the instruction/cancellation request has a rejected status.
    /// </summary>
    [IsoId("_Un0dtdp-Ed-ak6NoX_4Aeg_-1564918581")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rejection Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RejectionReasonV021Code? RejectionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectionReasonV021Code? RejectionReason { get; init; } 
    #else
    public RejectionReasonV021Code? RejectionReason { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information regarding why the collateral proposal has a rejected status.
    /// </summary>
    [IsoId("_Un0dttp-Ed-ak6NoX_4Aeg_-1917789059")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rejection Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RejectionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RejectionInformation { get; init; } 
    #else
    public System.String? RejectionInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
