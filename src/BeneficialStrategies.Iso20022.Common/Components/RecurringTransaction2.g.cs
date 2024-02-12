﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RecurringTransaction2.  ISO2002 ID# _3s3JETDhEeO9waS4ina8CA.
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
/// Financial loan (instalment) or a recurring transaction.
/// </summary>
[IsoId("_3s3JETDhEeO9waS4ina8CA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Recurring Transaction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RecurringTransaction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of instalment plan.
    /// </summary>
    [IsoId("_gVyDADDjEeO9waS4ina8CA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instalment Plan")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstalmentPlan1Code? InstalmentPlan { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstalmentPlan1Code? InstalmentPlan { get; init; } 
    #else
    public InstalmentPlan1Code? InstalmentPlan { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the instalment plan.
    /// </summary>
    [IsoId("_wDl_sDDjEeO9waS4ina8CA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Plan Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PlanIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlanIdentification { get; init; } 
    #else
    public System.String? PlanIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the recurring/instalment occurrence of the transaction (1 = 1st instalment, 2 = 2nd instalment, etc.).
    /// </summary>
    [IsoId("_37vSkTDhEeO9waS4ina8CA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sequence Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SequenceNumber { get; init; } 
    #else
    public System.UInt64? SequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Period unit between consecutive payments (for example day, month, year).
    /// </summary>
    [IsoId("_37vSkzDhEeO9waS4ina8CA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Period Unit")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency3Code? PeriodUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency3Code? PeriodUnit { get; init; } 
    #else
    public Frequency3Code? PeriodUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Number of period units between consecutive payments.
    /// </summary>
    [IsoId("_37vSlTDhEeO9waS4ina8CA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instalment Period")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? InstalmentPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? InstalmentPeriod { get; init; } 
    #else
    public System.UInt64? InstalmentPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of instalment payments.
    /// </summary>
    [IsoId("_37vSlzDhEeO9waS4ina8CA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Number Of Payments")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TotalNumberOfPayments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalNumberOfPayments { get; init; } 
    #else
    public System.UInt64? TotalNumberOfPayments { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the first payment.
    /// </summary>
    [IsoId("_2bU70DD5EeO9waS4ina8CA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("First Payment Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FirstPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FirstPaymentDate { get; init; } 
    #else
    public System.DateOnly? FirstPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Cumulative amount of all the instalments.
    /// </summary>
    [IsoId("_FDQ1kDD6EeO9waS4ina8CA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoCurrencyAndAmount? TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalAmount { get; init; } 
    #else
    public System.Decimal? TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the first payment.
    /// </summary>
    [IsoId("_kvf90DD6EeO9waS4ina8CA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("First Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? FirstAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? FirstAmount { get; init; } 
    #else
    public System.Decimal? FirstAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Charges related to the transaction.
    /// </summary>
    [IsoId("_c2KFADDkEeO9waS4ina8CA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Charges")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? Charges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Charges { get; init; } 
    #else
    public System.Decimal? Charges { get; set; } 
    #endif
    
    
    #nullable disable
    
}
