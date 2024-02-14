﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralSubstitutionResponse2.  ISO2002 ID# _QnYHFNp-Ed-ak6NoX_4Aeg_-1313655286.
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
/// Provides details about the rejected collateral substitution.
/// </summary>
[IsoId("_QnYHFNp-Ed-ak6NoX_4Aeg_-1313655286")]
[DisplayName("Collateral Substitution Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralSubstitutionResponse2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralSubstitutionResponse2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralSubstitutionResponse2( System.String reqCollateralSubstitutionRequestIdentification,System.Decimal reqRejectedAmount,RejectionReasonV021Code reqRejectionReason )
    {
        CollateralSubstitutionRequestIdentification = reqCollateralSubstitutionRequestIdentification;
        RejectedAmount = reqRejectedAmount;
        RejectionReason = reqRejectionReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the collateral substitution request identification.
    /// </summary>
    [IsoId("_QnYHFdp-Ed-ak6NoX_4Aeg_1984239657")]
    [DisplayName("Collateral Substitution Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSbstitnReqId")]
    #endif
    [IsoXmlTag("CollSbstitnReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CollateralSubstitutionRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CollateralSubstitutionRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CollateralSubstitutionRequestIdentification { get; init; } 
    #else
    public System.String CollateralSubstitutionRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the collateral substitution amount that is rejected.
    /// </summary>
    [IsoId("_QnYHFtp-Ed-ak6NoX_4Aeg_873328238")]
    [DisplayName("Rejected Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctdAmt")]
    #endif
    [IsoXmlTag("RjctdAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAndAmount RejectedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal RejectedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal RejectedAmount { get; init; } 
    #else
    public System.Decimal RejectedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reasons why the collateral substitution is rejected.
    /// </summary>
    [IsoId("_QnYHF9p-Ed-ak6NoX_4Aeg_-776739063")]
    [DisplayName("Rejection Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnRsn")]
    #endif
    [IsoXmlTag("RjctnRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectionReasonV021Code RejectionReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectionReasonV021Code RejectionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectionReasonV021Code RejectionReason { get; init; } 
    #else
    public RejectionReasonV021Code RejectionReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the collateral substitution request rejection.
    /// </summary>
    [IsoId("_QnYHGNp-Ed-ak6NoX_4Aeg_1784143773")]
    [DisplayName("Rejection Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnRsnInf")]
    #endif
    [IsoXmlTag("RjctnRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? RejectionReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RejectionReasonInformation { get; init; } 
    #else
    public System.String? RejectionReasonInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
