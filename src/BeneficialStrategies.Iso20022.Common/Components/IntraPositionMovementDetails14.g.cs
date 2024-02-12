﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraPositionMovementDetails14.  ISO2002 ID# _ZcRul5wxEeazcsnODTksnQ.
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
[IsoId("_ZcRul5wxEeazcsnODTksnQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Intra Position Movement Details")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraPositionMovementDetails14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraPositionMovementDetails14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraPositionMovementDetails14( FinancialInstrumentQuantity15Choice_ reqSettledQuantity,SecuritiesBalanceType8Choice_ reqBalanceTo,DateAndDateTimeChoice_ reqSettlementDate )
    {
        SettledQuantity = reqSettledQuantity;
        BalanceTo = reqBalanceTo;
        SettlementDate = reqSettlementDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifications (account owner and/or account servicer) of the intra-position movement.
    /// </summary>
    [IsoId("_ZcRum5wxEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public References51Choice_? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References51Choice_? Identification { get; init; } 
    #else
    public References51Choice_? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_ZcRunZwxEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settled Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity15Choice_ SettledQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public FinancialInstrumentQuantity15Choice_ SettledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_ SettledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_ SettledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_ZcRun5wxEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Previously Settled Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? PreviouslySettledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? PreviouslySettledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? PreviouslySettledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_ZcRuoZwxEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Remaining To Be Settled Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? RemainingToBeSettledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? RemainingToBeSettledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? RemainingToBeSettledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying a securities sub-balance type (example restriction identification etc…).
    /// </summary>
    [IsoId("_ZcRuo5wxEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities Sub Balance Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification39? SecuritiesSubBalanceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification39? SecuritiesSubBalanceIdentification { get; init; } 
    #else
    public GenericIdentification39? SecuritiesSubBalanceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Balance to which the securities were moved.
    /// </summary>
    [IsoId("_ZcRupZwxEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance To")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesBalanceType8Choice_ BalanceTo { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecuritiesBalanceType8Choice_ BalanceTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesBalanceType8Choice_ BalanceTo { get; init; } 
    #else
    public SecuritiesBalanceType8Choice_ BalanceTo { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities were moved.
    /// </summary>
    [IsoId("_ZcRup5wxEeazcsnODTksnQ")]
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
    [IsoId("_ZcRuqZwxEeazcsnODTksnQ")]
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
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    [IsoId("_ZcRuq5wxEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Acknowledged Status Time Stamp")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? AcknowledgedStatusTimeStamp { get; init; } 
    #else
    public System.DateTime? AcknowledgedStatusTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_ZcRurZwxEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Corporate Action Event Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventType69Choice_? CorporateActionEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventType69Choice_? CorporateActionEventType { get; init; } 
    #else
    public CorporateActionEventType69Choice_? CorporateActionEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the collateral available for the delivery settlement process at the account level.
    /// </summary>
    [IsoId("_ZcRur5wxEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral Monitor Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection55? CollateralMonitorAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection55? CollateralMonitorAmount { get; init; } 
    #else
    public AmountAndDirection55? CollateralMonitorAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_ZcRusZwxEeazcsnODTksnQ")]
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
    public IsoRestrictedFINXMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionProcessingAdditionalDetails { get; init; } 
    #else
    public System.String? InstructionProcessingAdditionalDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ZcRus5wxEeazcsnODTksnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
