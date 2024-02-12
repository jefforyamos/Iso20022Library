﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeTransactionPositionComponent5.  ISO2002 ID# _38nfYf_qEemm3skPVSMJQg.
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
/// Indicates contract that is to be reported as a new trade and also included in a separate position report on the same day.
/// </summary>
[IsoId("_38nfYf_qEemm3skPVSMJQg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Trade Transaction Position Component")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeTransactionPositionComponent5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeTransactionPositionComponent5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeTransactionPositionComponent5( CounterpartyData76 reqCounterpartyData,ModificationLevel1Code reqLevelType )
    {
        CounterpartyData = reqCounterpartyData;
        LevelType = reqLevelType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_4AyNof_qEemm3skPVSMJQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Technical Record Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TechnicalRecordIdentification { get; init; } 
    #else
    public System.String? TechnicalRecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_4AyNo__qEemm3skPVSMJQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Counterparty Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CounterpartyData76 CounterpartyData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CounterpartyData76 CounterpartyData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyData76 CounterpartyData { get; init; } 
    #else
    public CounterpartyData76 CounterpartyData { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the loan used for financing the transaction.
    /// </summary>
    [IsoId("_4AyNpf_qEemm3skPVSMJQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Loan Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionLoanData21Choice_? LoanData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionLoanData21Choice_? LoanData { get; init; } 
    #else
    public TransactionLoanData21Choice_? LoanData { get; set; } 
    #endif
    
    /// <summary>
    /// Information on collateral used in the transaction.
    /// </summary>
    [IsoId("_4AyNp__qEemm3skPVSMJQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralData27? CollateralData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralData27? CollateralData { get; init; } 
    #else
    public CollateralData27? CollateralData { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the reported transaction level type.
    /// </summary>
    [IsoId("_4AyNqf_qEemm3skPVSMJQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Level Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ModificationLevel1Code LevelType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ModificationLevel1Code LevelType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationLevel1Code LevelType { get; init; } 
    #else
    public ModificationLevel1Code LevelType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_4AyNq__qEemm3skPVSMJQg")]
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
