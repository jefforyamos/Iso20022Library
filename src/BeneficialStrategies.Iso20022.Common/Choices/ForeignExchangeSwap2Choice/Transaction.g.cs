﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Transaction.  ISO2002 ID# _qm-xU52WEeW_58xcYxhewg.
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
namespace BeneficialStrategies.Iso20022.Choices.ForeignExchangeSwap2Choice
{
    /// <summary>
    /// Provides the details of the foreign exchange transaction as reported by the reporting agent.
    /// </summary>
    [IsoId("_qm-xU52WEeW_58xcYxhewg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Transaction : ForeignExchangeSwap2Choice_
    #else
    public partial class Transaction : ForeignExchangeSwap2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Transaction instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Transaction( TransactionOperationType1Code reqReportedTransactionStatus,System.String reqProprietaryTransactionIdentification,CounterpartyIdentification2Choice_ reqCounterpartyIdentification,DateAndDateTimeChoice_ reqTradeDate,System.DateOnly reqSpotValueDate,System.DateOnly reqMaturityDate,SecuritiesTransactionType15Code reqTransactionType,System.Decimal reqTransactionNominalAmount,ForeignExchange1 reqForeignExchange )
        {
            ReportedTransactionStatus = reqReportedTransactionStatus;
            ProprietaryTransactionIdentification = reqProprietaryTransactionIdentification;
            CounterpartyIdentification = reqCounterpartyIdentification;
            TradeDate = reqTradeDate;
            SpotValueDate = reqSpotValueDate;
            MaturityDate = reqMaturityDate;
            TransactionType = reqTransactionType;
            TransactionNominalAmount = reqTransactionNominalAmount;
            ForeignExchange = reqForeignExchange;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Defines the status of the reported transaction, that is details on whether the transaction is a new transaction, an amendment of a previously reported transaction, a cancellation of a previously reported transaction or a correction to a previously reported and rejected transaction.
        /// </summary>
        [IsoId("_qua2EZ2WEeW_58xcYxhewg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Reported Transaction Status")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required TransactionOperationType1Code ReportedTransactionStatus { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public TransactionOperationType1Code ReportedTransactionStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransactionOperationType1Code ReportedTransactionStatus { get; init; } 
        #else
        public TransactionOperationType1Code ReportedTransactionStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous legal entity identification of the branch of the reporting agent in which the transaction has been booked.
        /// Usage: This field must only be provided if the transaction has been conducted and booked by a branch of the reporting agent and only if this branch has its own LEI that the reporting agent can clearly identify. 
        /// Where the transaction has been booked by the head office or the reporting agent cannot be identified by a unique branch-specific LEI, the reporting agent must provide the LEI of the head office.
        /// </summary>
        [IsoId("__L4YwZ2WEeW_58xcYxhewg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Branch Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoLEIIdentifier? BranchIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? BranchIdentification { get; init; } 
        #else
        public System.String? BranchIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unique transaction identifier will be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction during its lifetime.
        /// </summary>
        [IsoId("_qua2E52WEeW_58xcYxhewg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Unique Transaction Identifier")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 105 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax105Text? UniqueTransactionIdentifier { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? UniqueTransactionIdentifier { get; init; } 
        #else
        public System.String? UniqueTransactionIdentifier { get; set; } 
        #endif
        
        /// <summary>
        /// Internal unique transaction identifier used by the reporting agent for each transaction.
        /// </summary>
        [IsoId("_qua2FZ2WEeW_58xcYxhewg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Proprietary Transaction Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 105 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax105Text ProprietaryTransactionIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String ProprietaryTransactionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String ProprietaryTransactionIdentification { get; init; } 
        #else
        public System.String ProprietaryTransactionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Internal unique proprietary transaction identifier as assigned by the counterparty of the reporting agent for each transaction.
        /// </summary>
        [IsoId("_qua2F52WEeW_58xcYxhewg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Counterparty Proprietary Transaction Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 105 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax105Text? CounterpartyProprietaryTransactionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? CounterpartyProprietaryTransactionIdentification { get; init; } 
        #else
        public System.String? CounterpartyProprietaryTransactionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the counterparty of the reporting agent for the reported transaction.
        /// </summary>
        [IsoId("_qua2GZ2WEeW_58xcYxhewg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Counterparty Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CounterpartyIdentification2Choice_ CounterpartyIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public CounterpartyIdentification2Choice_ CounterpartyIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CounterpartyIdentification2Choice_ CounterpartyIdentification { get; init; } 
        #else
        public CounterpartyIdentification2Choice_ CounterpartyIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time on which the parties entered into the reported transaction.
        /// Usage: when time is available, it must be reported.
        /// It is to be reported with only the date when the time of the transaction is not available. 
        /// The reported time is the execution time when available or otherwise the time at which the transaction entered the trading system of the reporting agent.
        /// </summary>
        [IsoId("_qua2G52WEeW_58xcYxhewg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Trade Date")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DateAndDateTimeChoice_ TradeDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public DateAndDateTimeChoice_ TradeDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndDateTimeChoice_ TradeDate { get; init; } 
        #else
        public DateAndDateTimeChoice_ TradeDate { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which one party sells to the other a specified amount of a specified currency against payment of an agreed amount of a specified different currency based on an agreed foreign exchange rate known as foreign exchange spot rate.
        /// </summary>
        [IsoId("_qua2HZ2WEeW_58xcYxhewg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Spot Value Date")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate SpotValueDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.DateOnly SpotValueDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly SpotValueDate { get; init; } 
        #else
        public System.DateOnly SpotValueDate { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the foreign exchange swap transaction expires and the currency sold on the value date is repurchased.
        /// </summary>
        [IsoId("_qua2H52WEeW_58xcYxhewg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Maturity Date")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate MaturityDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.DateOnly MaturityDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly MaturityDate { get; init; } 
        #else
        public System.DateOnly MaturityDate { get; set; } 
        #endif
        
        /// <summary>
        /// Defines whether the amount of money reported under the transaction nominal amount is bought or sold on the spot value date.
        /// </summary>
        [IsoId("_qua2IZ2WEeW_58xcYxhewg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Transaction Type")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SecuritiesTransactionType15Code TransactionType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public SecuritiesTransactionType15Code TransactionType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesTransactionType15Code TransactionType { get; init; } 
        #else
        public SecuritiesTransactionType15Code TransactionType { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the nominal amount of the foreign exchange swap, that is the amount bought/sold on the spot value date and reported as an absolute value.
        /// </summary>
        [IsoId("_qua2I52WEeW_58xcYxhewg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Transaction Nominal Amount")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoActiveCurrencyAndAmount TransactionNominalAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.Decimal TransactionNominalAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal TransactionNominalAmount { get; init; } 
        #else
        public System.Decimal TransactionNominalAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the details of the foreign exchange transaction.
        /// </summary>
        [IsoId("_qua2JZ2WEeW_58xcYxhewg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Foreign Exchange")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ForeignExchange1 ForeignExchange { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public ForeignExchange1 ForeignExchange { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ForeignExchange1 ForeignExchange { get; init; } 
        #else
        public ForeignExchange1 ForeignExchange { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_qua2J52WEeW_58xcYxhewg")]
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
