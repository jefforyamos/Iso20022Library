﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ServiceCategoryTotals2.  ISO2002 ID# _mQH0X-F6EeWCAvUNsZ5u6g.
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
/// Specifies totals related to the invoice.
/// </summary>
[IsoId("_mQH0X-F6EeWCAvUNsZ5u6g")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Service Category Totals")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ServiceCategoryTotals2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ServiceCategoryTotals2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ServiceCategoryTotals2( System.Decimal reqTotalInvoiceAmount,System.String reqServiceCategory )
    {
        TotalInvoiceAmount = reqTotalInvoiceAmount;
        ServiceCategory = reqServiceCategory;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of an securities account or cash account belonging to billed customer.
    /// </summary>
    [IsoId("_ma_AgeF6EeWCAvUNsZ5u6g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification38Choice_? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification38Choice_? AccountIdentification { get; init; } 
    #else
    public AccountIdentification38Choice_? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// BIC of the party which is invoiced by the CSD/NCB.
    /// </summary>
    [IsoId("_ma_Ag-F6EeWCAvUNsZ5u6g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Billed Customer Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBICFIIdentifier? BilledCustomerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BilledCustomerIdentification { get; init; } 
    #else
    public System.String? BilledCustomerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount subject to tax.
    /// </summary>
    [IsoId("_ma_AheF6EeWCAvUNsZ5u6g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Taxable Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? TotalTaxableAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalTaxableAmount { get; init; } 
    #else
    public System.Decimal? TotalTaxableAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of all tax amounts related to the invoice.
    /// </summary>
    [IsoId("_ma_Ah-F6EeWCAvUNsZ5u6g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Tax Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? TotalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalTaxAmount { get; init; } 
    #else
    public System.Decimal? TotalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the invoice, being the sum of total invoice lines amounts, total invoice adjustment amount (discounts, allowances and charges) and total tax amounts.
    /// </summary>
    [IsoId("_ma_AieF6EeWCAvUNsZ5u6g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Invoice Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAndAmount TotalInvoiceAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal TotalInvoiceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal TotalInvoiceAmount { get; init; } 
    #else
    public System.Decimal TotalInvoiceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    [IsoId("_ma_Ai-F6EeWCAvUNsZ5u6g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Service Category")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4AlphaNumericText ServiceCategory { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ServiceCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ServiceCategory { get; init; } 
    #else
    public System.String ServiceCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies totals related to the invoice.
    /// </summary>
    [IsoId("_ma_AjeF6EeWCAvUNsZ5u6g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Service Item Totals")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ServiceItemTotals1? ServiceItemTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceItemTotals1? ServiceItemTotals { get; init; } 
    #else
    public ServiceItemTotals1? ServiceItemTotals { get; set; } 
    #endif
    
    
    #nullable disable
    
}
