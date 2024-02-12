﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubscriptionMultipleOrder2.  ISO2002 ID# _VT7Vztp-Ed-ak6NoX_4Aeg_-1053593438.
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
/// Order to invest the investor's principal in an investment fund.
/// </summary>
[IsoId("_VT7Vztp-Ed-ak6NoX_4Aeg_-1053593438")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Subscription Multiple Order")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionMultipleOrder2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionMultipleOrder2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionMultipleOrder2( InvestmentAccount13 reqInvestmentAccountDetails )
    {
        InvestmentAccountDetails = reqInvestmentAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_VT7Vz9p-Ed-ak6NoX_4Aeg_-1053593360")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Place Of Trade")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? PlaceOfTrade { get; init; } 
    #else
    public string? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Date the investor places the order.
    /// </summary>
    [IsoId("_VUFGwNp-Ed-ak6NoX_4Aeg_-282388970")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Order Date Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? OrderDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? OrderDateTime { get; init; } 
    #else
    public System.DateTime? OrderDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("_VUFGwdp-Ed-ak6NoX_4Aeg_1575569284")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Expiry Date Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ExpiryDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ExpiryDateTime { get; init; } 
    #else
    public System.DateTime? ExpiryDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_VUFGwtp-Ed-ak6NoX_4Aeg_-1053593403")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cancellation Right")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationRight1? CancellationRight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationRight1? CancellationRight { get; init; } 
    #else
    public CancellationRight1? CancellationRight { get; set; } 
    #endif
    
    /// <summary>
    /// Account impacted by an investment fund order.
    /// </summary>
    [IsoId("_VUFGw9p-Ed-ak6NoX_4Aeg_-1053593342")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Investment Account Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount13 InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the beneficial owner.
    /// </summary>
    [IsoId("_VUFGxNp-Ed-ak6NoX_4Aeg_127162138")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Beneficiary Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson2? BeneficiaryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson2? BeneficiaryDetails { get; init; } 
    #else
    public IndividualPerson2? BeneficiaryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Order to invest the investor's principal in an investment fund.
    /// </summary>
    [IsoId("_VUFGxdp-Ed-ak6NoX_4Aeg_-1053593051")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Individual Order Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public SubscriptionOrder4? IndividualOrderDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _VUFGxdp-Ed-ak6NoX_4Aeg_-1053593051
    
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VUFGxtp-Ed-ak6NoX_4Aeg_-1053593003")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Bulk Cash Settlement Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction19? BulkCashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction19? BulkCashSettlementDetails { get; init; } 
    #else
    public PaymentTransaction19? BulkCashSettlementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
