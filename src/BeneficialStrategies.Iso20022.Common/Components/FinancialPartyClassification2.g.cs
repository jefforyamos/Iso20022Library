﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialPartyClassification2.  ISO2002 ID# _0lQ2EbHXEemRPNDOvJwndA.
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
/// Specifies the classification of a financial institution.
/// </summary>
[IsoId("_0lQ2EbHXEemRPNDOvJwndA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Financial Party Classification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialPartyClassification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Classification of the business activities of the reporting counterparty.
    /// </summary>
    [IsoId("_0uXHsbHXEemRPNDOvJwndA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Classification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public System.String? Classification { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _0uXHsbHXEemRPNDOvJwndA
    
    /// <summary>
    /// Nature business activities of the reporting counterparty as an investment fund.
    /// </summary>
    [IsoId("_0ugRobHXEemRPNDOvJwndA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Investment Fund Classification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundType2Code? InvestmentFundClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundType2Code? InvestmentFundClassification { get; init; } 
    #else
    public FundType2Code? InvestmentFundClassification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
