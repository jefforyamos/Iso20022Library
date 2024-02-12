﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionUnallocatedBalanceSD1.  ISO2002 ID# _V1OIGqJGEeS6IulNYwkZBg.
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
/// Balance types related to an unallocated redemption payment.
/// </summary>
[IsoId("_V1OIGqJGEeS6IulNYwkZBg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action Unallocated Balance SD")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionUnallocatedBalanceSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_V1OILKJGEeS6IulNYwkZBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Eligible Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat4? TotalEligibleBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat4? TotalEligibleBalance { get; init; } 
    #else
    public SignedQuantityFormat4? TotalEligibleBalance { get; set; } 
    #endif
    
    /// <summary>
    /// The quantity that has been determined to be redeemed if the participant had
    /// position in a redemption security.
    /// </summary>
    [IsoId("_V1OIKqJGEeS6IulNYwkZBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Affected Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat4? AffectedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat4? AffectedBalance { get; init; } 
    #else
    public SignedQuantityFormat4? AffectedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Positions balance remaining after lottery is run.
    /// </summary>
    [IsoId("_V1OIPqJGEeS6IulNYwkZBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unaffected Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat4? UnaffectedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat4? UnaffectedBalance { get; init; } 
    #else
    public SignedQuantityFormat4? UnaffectedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Position that account holders should return to the account servicer to participate in the event or to fulfill their obligation for the event to be complete, for example, return of securities for late announced drawing.
    /// </summary>
    [IsoId("_V1OIM6JGEeS6IulNYwkZBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Obligated Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat4? ObligatedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat4? ObligatedBalance { get; init; } 
    #else
    public SignedQuantityFormat4? ObligatedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Position held in a security as of the day prior to publication date. This position is subject to a redemption lottery call when this is the first lottery. This balance will not be adjusted for the supplemental or concurrent lotteries and will remain constant to report the original position.
    /// </summary>
    [IsoId("_V1OINaJGEeS6IulNYwkZBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat4? OriginalBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat4? OriginalBalance { get; init; } 
    #else
    public SignedQuantityFormat4? OriginalBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC General Free account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    [IsoId("_V1OIKaJGEeS6IulNYwkZBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pledged Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat4? PledgedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat4? PledgedBalance { get; init; } 
    #else
    public SignedQuantityFormat4? PledgedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC General Free account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    [IsoId("_V1OIK6JGEeS6IulNYwkZBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unpledged Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat4? UnpledgedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat4? UnpledgedBalance { get; init; } 
    #else
    public SignedQuantityFormat4? UnpledgedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC Investment account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_V1OINKJGEeS6IulNYwkZBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Investment Pledged Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat4? InvestmentPledgedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat4? InvestmentPledgedBalance { get; init; } 
    #else
    public SignedQuantityFormat4? InvestmentPledgedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC Segregated account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_V1OINqJGEeS6IulNYwkZBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Investment Unpledged Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat4? InvestmentUnpledgedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat4? InvestmentUnpledgedBalance { get; init; } 
    #else
    public SignedQuantityFormat4? InvestmentUnpledgedBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
