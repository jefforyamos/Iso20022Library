﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StandingOrder5.  ISO2002 ID# _jVCsN5lPEee-Zps0fZQaFQ.
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
/// New standing order values.
/// </summary>
[IsoId("_jVCsN5lPEee-Zps0fZQaFQ")]
[DisplayName("Standing Order")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StandingOrder5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money and currency to be transferred when a payment instruction is created as a result of a standing order.
    /// </summary>
    [IsoId("_jdqcs5lPEee-Zps0fZQaFQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount2Choice_? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2Choice_? Amount { get; init; } 
    #else
    public Amount2Choice_? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Cash account credited from a standing order mechanism.
    /// </summary>
    [IsoId("_jdqctZlPEee-Zps0fZQaFQ")]
    [DisplayName("Creditor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAcct")]
    #endif
    [IsoXmlTag("CdtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? CreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? CreditorAccount { get; init; } 
    #else
    public CashAccount24? CreditorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Cash account debited from a standing order mechanism.
    /// </summary>
    [IsoId("_jdqct5lPEee-Zps0fZQaFQ")]
    [DisplayName("Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAcct")]
    #endif
    [IsoXmlTag("DbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? DebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? DebtorAccount { get; init; } 
    #else
    public CashAccount24? DebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Defines whether the standing order is executed through a time-based or an event-based trigger.
    /// </summary>
    [IsoId("_jdqcuZlPEee-Zps0fZQaFQ")]
    [DisplayName("Execution Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnTp")]
    #endif
    [IsoXmlTag("ExctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExecutionType1Choice_? ExecutionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExecutionType1Choice_? ExecutionType { get; init; } 
    #else
    public ExecutionType1Choice_? ExecutionType { get; set; } 
    #endif
    
    /// <summary>
    /// Regularity with which payment instructions are to be created and processed as a result of the standing order, such as daily, weekly, or monthly.
    /// </summary>
    [IsoId("_jdqcu5lPEee-Zps0fZQaFQ")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency2Code? Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency2Code? Frequency { get; init; } 
    #else
    public Frequency2Code? Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Dates during which the standing order is in effect.
    /// </summary>
    [IsoId("_jdqcvZlPEee-Zps0fZQaFQ")]
    [DisplayName("Validity Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtyPrd")]
    #endif
    [IsoXmlTag("VldtyPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriod2Choice_? ValidityPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriod2Choice_? ValidityPeriod { get; init; } 
    #else
    public DatePeriod2Choice_? ValidityPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the standing order is defined as a zero sweeping order. When true, the liquidity transfer standing order will transfer all amount of money out of the account so the resulting balance is zero.
    /// </summary>
    [IsoId("_jdqcv5lPEee-Zps0fZQaFQ")]
    [DisplayName("Zero Sweep Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ZeroSweepInd")]
    #endif
    [IsoXmlTag("ZeroSweepInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ZeroSweepIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ZeroSweepIndicator { get; init; } 
    #else
    public System.String? ZeroSweepIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
