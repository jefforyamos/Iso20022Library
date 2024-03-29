﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionStandingInstructionCancellationRejectionStatus1.  ISO2002 ID# _Rk6tZNp-Ed-ak6NoX_4Aeg_1198444441.
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
/// Provides reason of the rejection of a standing instruction cancellation request.
/// </summary>
[IsoId("_Rk6tZNp-Ed-ak6NoX_4Aeg_1198444441")]
[DisplayName("Corporate Action Standing Instruction Cancellation Rejection Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionStandingInstructionCancellationRejectionStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// The rejection reason.
    /// </summary>
    [IsoId("_Rk6tZdp-Ed-ak6NoX_4Aeg_1289872620")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    public ValueList<RejectionReason10FormatChoice_> Reason { get; init; } = new ValueList<RejectionReason10FormatChoice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Rk6tZdp-Ed-ak6NoX_4Aeg_1289872620
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_Rk6tZtp-Ed-ak6NoX_4Aeg_1289872650")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
