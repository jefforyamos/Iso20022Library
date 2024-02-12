﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraPositionDetails34.  ISO2002 ID# _rakyCTnsEeWfSKvvZlhRKg.
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
/// Details of the intra-position movement.
/// </summary>
[IsoId("_rakyCTnsEeWfSKvvZlhRKg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Intra Position Details")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraPositionDetails34
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraPositionDetails34 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraPositionDetails34( FinancialInstrumentQuantity1Choice_ reqSettledQuantity,DateAndDateTimeChoice_ reqSettlementDate,SecuritiesSubBalanceTypeAndQuantityBreakdown3 reqBalanceFrom,SecuritiesSubBalanceTypeAndQuantityBreakdown3 reqBalanceTo )
    {
        SettledQuantity = reqSettledQuantity;
        SettlementDate = reqSettlementDate;
        BalanceFrom = reqBalanceFrom;
        BalanceTo = reqBalanceTo;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_r8pkWTnsEeWfSKvvZlhRKg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settled Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ SettledQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public FinancialInstrumentQuantity1Choice_ SettledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ SettledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ SettledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying a Securities Sub balance Type (example restriction identification etc…).
    /// </summary>
    [IsoId("_r8pkYTnsEeWfSKvvZlhRKg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities Sub Balance Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification37? SecuritiesSubBalanceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification37? SecuritiesSubBalanceIdentification { get; init; } 
    #else
    public GenericIdentification37? SecuritiesSubBalanceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the collateral available for the delivery settlement process at the account level.
    /// </summary>
    [IsoId("_r8pkYznsEeWfSKvvZlhRKg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral Monitor Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection44? CollateralMonitorAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection44? CollateralMonitorAmount { get; init; } 
    #else
    public AmountAndDirection44? CollateralMonitorAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_r8pkZTnsEeWfSKvvZlhRKg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Previously Settled Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_r8pkbTnsEeWfSKvvZlhRKg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Remaining To Be Settled Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities were moved.
    /// </summary>
    [IsoId("_r8pkdTnsEeWfSKvvZlhRKg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ SettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DateAndDateTimeChoice_ SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ SettlementDate { get; init; } 
    #else
    public DateAndDateTimeChoice_ SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time securities become available for sale (if securities become unavailable, this specifies the date/time at which they will become available again).
    /// </summary>
    [IsoId("_r8pkfTnsEeWfSKvvZlhRKg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Available Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? AvailableDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? AvailableDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? AvailableDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_r8pkhTnsEeWfSKvvZlhRKg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Corporate Action Event Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventType29Choice_? CorporateActionEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventType29Choice_? CorporateActionEventType { get; init; } 
    #else
    public CorporateActionEventType29Choice_? CorporateActionEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    [IsoId("_r8pkjTnsEeWfSKvvZlhRKg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance From")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    #else
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    [IsoId("_r8pklTnsEeWfSKvvZlhRKg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance To")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; } 
    #else
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_r8pknTnsEeWfSKvvZlhRKg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instruction Processing Additional Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionProcessingAdditionalDetails { get; init; } 
    #else
    public System.String? InstructionProcessingAdditionalDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
