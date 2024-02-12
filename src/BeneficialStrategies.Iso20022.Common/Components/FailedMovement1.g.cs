﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FailedMovement1.  ISO2002 ID# _UIrqo9p-Ed-ak6NoX_4Aeg_2140472900.
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
/// Provides information about a movement that failed the settlement.
/// </summary>
[IsoId("_UIrqo9p-Ed-ak6NoX_4Aeg_2140472900")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Failed Movement")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FailedMovement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FailedMovement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FailedMovement1( System.Decimal reqCashAmount,UnitOrFaceAmount1Choice_ reqSecuritiesQuantity,FailedSettlementReason1FormatChoice_ reqReason )
    {
        CashAmount = reqCashAmount;
        SecuritiesQuantity = reqSecuritiesQuantity;
        Reason = reqReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of cash.
    /// </summary>
    [IsoId("_UIrqpNp-Ed-ak6NoX_4Aeg_389375421")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAndAmount CashAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal CashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal CashAmount { get; init; } 
    #else
    public System.Decimal CashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of the financial instrument.
    /// </summary>
    [IsoId("_UIrqpdp-Ed-ak6NoX_4Aeg_-613888276")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOrFaceAmount1Choice_ SecuritiesQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public UnitOrFaceAmount1Choice_ SecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_ SecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_ SecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UIrqptp-Ed-ak6NoX_4Aeg_-647134478")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification7? SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification7? SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification7? SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// The reason for the settlement failure.
    /// </summary>
    [IsoId("_UIrqp9p-Ed-ak6NoX_4Aeg_-124106569")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FailedSettlementReason1FormatChoice_ Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public FailedSettlementReason1FormatChoice_ Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FailedSettlementReason1FormatChoice_ Reason { get; init; } 
    #else
    public FailedSettlementReason1FormatChoice_ Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
