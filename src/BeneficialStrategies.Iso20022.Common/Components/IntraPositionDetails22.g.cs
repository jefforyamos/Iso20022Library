﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraPositionDetails22.  ISO2002 ID# _VhTX8f8JEeCKBMQETXEXKQ.
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
[IsoId("_VhTX8f8JEeCKBMQETXEXKQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Intra Position Details")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraPositionDetails22
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraPositionDetails22 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraPositionDetails22( FinancialInstrumentQuantity1Choice_ reqSettledQuantity,DateAndDateTimeChoice_ reqSettlementDate,SecuritiesSubBalanceTypeAndQuantityBreakdown1 reqBalanceFrom,SecuritiesSubBalanceTypeAndQuantityBreakdown1 reqBalanceTo )
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
    [IsoId("_VhdJAf8JEeCKBMQETXEXKQ")]
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
    /// Number identifying a Securities Sub balance Type (e.g. restriction identification etc…).
    /// </summary>
    [IsoId("_VhdJC_8JEeCKBMQETXEXKQ")]
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
    [IsoId("_VhdJD_8JEeCKBMQETXEXKQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral Monitor Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? CollateralMonitorAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? CollateralMonitorAmount { get; init; } 
    #else
    public AmountAndDirection9? CollateralMonitorAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_VhdJE_8JEeCKBMQETXEXKQ")]
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
    [IsoId("_VhdJHf8JEeCKBMQETXEXKQ")]
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
    [IsoId("_VhdJJ_8JEeCKBMQETXEXKQ")]
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
    [IsoId("_VhdJMf8JEeCKBMQETXEXKQ")]
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
    [IsoId("_VhdJO_8JEeCKBMQETXEXKQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Corporate Action Event Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventType3Choice_? CorporateActionEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventType3Choice_? CorporateActionEventType { get; init; } 
    #else
    public CorporateActionEventType3Choice_? CorporateActionEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    [IsoId("_VhdJRf8JEeCKBMQETXEXKQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance From")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown1 BalanceFrom { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecuritiesSubBalanceTypeAndQuantityBreakdown1 BalanceFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesSubBalanceTypeAndQuantityBreakdown1 BalanceFrom { get; init; } 
    #else
    public SecuritiesSubBalanceTypeAndQuantityBreakdown1 BalanceFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    [IsoId("_VhdJU_8JEeCKBMQETXEXKQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance To")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown1 BalanceTo { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecuritiesSubBalanceTypeAndQuantityBreakdown1 BalanceTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesSubBalanceTypeAndQuantityBreakdown1 BalanceTo { get; init; } 
    #else
    public SecuritiesSubBalanceTypeAndQuantityBreakdown1 BalanceTo { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_VhdJYf8JEeCKBMQETXEXKQ")]
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
