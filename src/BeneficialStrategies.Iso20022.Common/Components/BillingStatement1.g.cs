﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BillingStatement1.  ISO2002 ID# _6QZvpZqlEeGSON8vddiWzQ_856759895.
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
/// Details of the statement reporting the bank services billing.
/// </summary>
[IsoId("_6QZvpZqlEeGSON8vddiWzQ_856759895")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Billing Statement")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingStatement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingStatement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingStatement1( System.String reqStatementIdentification,DatePeriod1 reqFromToDate,System.DateTime reqCreationDateTime,BillingStatementStatus1Code reqStatus,CashAccountCharacteristics1 reqAccountCharacteristics )
    {
        StatementIdentification = reqStatementIdentification;
        FromToDate = reqFromToDate;
        CreationDateTime = reqCreationDateTime;
        Status = reqStatus;
        AccountCharacteristics = reqAccountCharacteristics;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the customer billing statement.
    /// </summary>
    [IsoId("_6QZvppqlEeGSON8vddiWzQ_-1768257610")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Statement Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text StatementIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String StatementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String StatementIdentification { get; init; } 
    #else
    public System.String StatementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date range between the start date and the end date for which the statement is issued.
    /// </summary>
    [IsoId("_6QZvp5qlEeGSON8vddiWzQ_-1590138938")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("From To Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DatePeriod1 FromToDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DatePeriod1 FromToDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriod1 FromToDate { get; init; } 
    #else
    public DatePeriod1 FromToDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date the statement message was created.
    /// </summary>
    [IsoId("_6Qi5kJqlEeGSON8vddiWzQ_-1882096676")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creation Date Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the status of the statement.
    /// </summary>
    [IsoId("_6Qi5kZqlEeGSON8vddiWzQ_-122990175")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BillingStatementStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public BillingStatementStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingStatementStatus1Code Status { get; init; } 
    #else
    public BillingStatementStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the details of the account characteristics.
    /// </summary>
    [IsoId("_6Qi5kpqlEeGSON8vddiWzQ_-1896816822")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Characteristics")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccountCharacteristics1 AccountCharacteristics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CashAccountCharacteristics1 AccountCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountCharacteristics1 AccountCharacteristics { get; init; } 
    #else
    public CashAccountCharacteristics1 AccountCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the non tax per annum rate and factor values used within the statement along with any time dependent charge basis.
    /// </summary>
    [IsoId("_6Qi5k5qlEeGSON8vddiWzQ_1222959449")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rate Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingRate1? RateData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingRate1? RateData { get; init; } 
    #else
    public BillingRate1? RateData { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies details related to currency exchange data.
    /// </summary>
    [IsoId("_6Qi5lJqlEeGSON8vddiWzQ_1401078121")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency Exchange")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyExchange6? CurrencyExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyExchange6? CurrencyExchange { get; init; } 
    #else
    public CurrencyExchange6? CurrencyExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the average value of balances held within the statement period.
    /// </summary>
    [IsoId("_6Qi5lZqlEeGSON8vddiWzQ_1109120383")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingBalance1? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingBalance1? Balance { get; init; } 
    #else
    public BillingBalance1? Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the set of values and totals that are used to provide compensation information, service and tax totals.
    /// </summary>
    [IsoId("_6Qi5lpqlEeGSON8vddiWzQ_-1426740412")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Compensation")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingCompensation1? Compensation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingCompensation1? Compensation { get; init; } 
    #else
    public BillingCompensation1? Compensation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the values used for every line item service in the statement.
    /// </summary>
    [IsoId("_6Qi5l5qlEeGSON8vddiWzQ_-519065905")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Service")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingService1? Service { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingService1? Service { get; init; } 
    #else
    public BillingService1? Service { get; set; } 
    #endif
    
    /// <summary>
    /// Tax region(s) that levy a tax on the services within this statement.
    /// </summary>
    [IsoId("_6Qi5mJqlEeGSON8vddiWzQ_1765944533")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax Region")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingTaxRegion1? TaxRegion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingTaxRegion1? TaxRegion { get; init; } 
    #else
    public BillingTaxRegion1? TaxRegion { get; set; } 
    #endif
    
    /// <summary>
    /// One or more sections that identify balance or float adjustments to the account. They can reflect either adjustments to the current statement or adjustments to statements from prior reporting periods.
    /// </summary>
    [IsoId("_6QsqkJqlEeGSON8vddiWzQ_1944063205")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance Adjustment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceAdjustment1? BalanceAdjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceAdjustment1? BalanceAdjustment { get; init; } 
    #else
    public BalanceAdjustment1? BalanceAdjustment { get; set; } 
    #endif
    
    /// <summary>
    /// One or more sections that identify line item service adjustments to the account. They reflect adjustments to statements from prior reporting periods.
    /// </summary>
    [IsoId("_6QsqkZqlEeGSON8vddiWzQ_1652105467")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Service Adjustment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingServiceAdjustment1? ServiceAdjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingServiceAdjustment1? ServiceAdjustment { get; init; } 
    #else
    public BillingServiceAdjustment1? ServiceAdjustment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
