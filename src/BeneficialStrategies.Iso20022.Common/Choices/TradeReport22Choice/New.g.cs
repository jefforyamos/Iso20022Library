﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for New.  ISO2002 ID# _zvSsccg3EeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.TradeReport22Choice
{
    /// <summary>
    /// Indicates whether transaction is reported for the first time.
    /// </summary>
    [IsoId("_zvSsccg3EeuGrNSsxk3B0A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("New")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record New : TradeReport22Choice_
    #else
    public partial class New : TradeReport22Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a New instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public New( CounterpartyData88 reqCounterpartySpecificData,TransactionLoanData30Choice_ reqLoanData,ModificationLevel1Code reqLevelType )
        {
            CounterpartySpecificData = reqCounterpartySpecificData;
            LoanData = reqLoanData;
            LevelType = reqLevelType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_zwwsEcg3EeuGrNSsxk3B0A")]
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
        /// Set of information specific to counterparties and related fields.
        /// </summary>
        [IsoId("_zwwsE8g3EeuGrNSsxk3B0A")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Counterparty Specific Data")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CounterpartyData88 CounterpartySpecificData { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public CounterpartyData88 CounterpartySpecificData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CounterpartyData88 CounterpartySpecificData { get; init; } 
        #else
        public CounterpartyData88 CounterpartySpecificData { get; set; } 
        #endif
        
        /// <summary>
        /// Details of the loan used for financing the transaction.
        /// </summary>
        [IsoId("_zwwsFcg3EeuGrNSsxk3B0A")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Loan Data")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required TransactionLoanData30Choice_ LoanData { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public TransactionLoanData30Choice_ LoanData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransactionLoanData30Choice_ LoanData { get; init; } 
        #else
        public TransactionLoanData30Choice_ LoanData { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the details of the collateral used in the transaction.
        /// </summary>
        [IsoId("_zwwsF8g3EeuGrNSsxk3B0A")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Collateral Data")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TransactionCollateralData18Choice_? CollateralData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransactionCollateralData18Choice_? CollateralData { get; init; } 
        #else
        public TransactionCollateralData18Choice_? CollateralData { get; set; } 
        #endif
        
        /// <summary>
        /// Information concerning the reported transaction level type.
        /// </summary>
        [IsoId("_zwwsGcg3EeuGrNSsxk3B0A")]
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
        [IsoId("_zwwsG8g3EeuGrNSsxk3B0A")]
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
}
