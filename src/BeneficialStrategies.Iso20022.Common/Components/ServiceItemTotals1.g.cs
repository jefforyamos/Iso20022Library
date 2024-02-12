﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ServiceItemTotals1.  ISO2002 ID# _jFoQQO5NEeCisYr99QEiWA_-1267586001.
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
[IsoId("_jFoQQO5NEeCisYr99QEiWA_-1267586001")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Service Item Totals")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ServiceItemTotals1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ServiceItemTotals1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ServiceItemTotals1( System.String reqItemType,System.UInt64 reqQuantity,System.Decimal reqTotalInvoiceAmount )
    {
        ItemType = reqItemType;
        Quantity = reqQuantity;
        TotalInvoiceAmount = reqTotalInvoiceAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies a classification for the service items such as query, report, securities account, etc….
    /// </summary>
    [IsoId("_jFoQQe5NEeCisYr99QEiWA_733684317")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Item Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4AlphaNumericText ItemType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ItemType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ItemType { get; init; } 
    #else
    public System.String ItemType { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of total number units per service item.
    /// </summary>
    [IsoId("_jFoQQu5NEeCisYr99QEiWA_-404470029")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.UInt64 Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Quantity { get; init; } 
    #else
    public System.UInt64 Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the unit of the service item.
    /// </summary>
    [IsoId("_jFoQQ-5NEeCisYr99QEiWA_-482207870")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unit Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? UnitPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? UnitPrice { get; init; } 
    #else
    public System.Decimal? UnitPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount subject to tax.
    /// </summary>
    [IsoId("_jFoQRO5NEeCisYr99QEiWA_1777732204")]
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
    [IsoId("_jFyBQO5NEeCisYr99QEiWA_-1439214754")]
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
    [IsoId("_jFyBQe5NEeCisYr99QEiWA_426525420")]
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
    
    
    #nullable disable
    
}
