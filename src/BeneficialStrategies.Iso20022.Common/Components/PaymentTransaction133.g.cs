﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransaction133.  ISO2002 ID# _buMPMdcZEeqRFcf2R4bPBw.
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
/// Provides further details on the reference and status on the original transactions, included in the original instruction, to which the return message applies.
/// </summary>
[IsoId("_buMPMdcZEeqRFcf2R4bPBw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Payment Transaction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransaction133
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentTransaction133 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentTransaction133( System.Decimal reqReturnedInterbankSettlementAmount )
    {
        ReturnedInterbankSettlementAmount = reqReturnedInterbankSettlementAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the returned transaction.|Usage: The instructing party is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    [IsoId("_bvqO19cZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Return Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReturnIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReturnIdentification { get; init; } 
    #else
    public System.String? ReturnIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_bvqO2dcZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Group Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
    #else
    public OriginalGroupInformation29? OriginalGroupInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_bvqO29cZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Instruction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalInstructionIdentification { get; init; } 
    #else
    public System.String? OriginalInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_bvqO3dcZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original End To End Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalEndToEndIdentification { get; init; } 
    #else
    public System.String? OriginalEndToEndIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    [IsoId("_bvqO39cZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalTransactionIdentification { get; init; } 
    #else
    public System.String? OriginalTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_bvqO4dcZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original UETR")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoUUIDv4Identifier? OriginalUETR { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalUETR { get; init; } 
    #else
    public System.String? OriginalUETR { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_bvqO49cZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Clearing System Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalClearingSystemReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalClearingSystemReference { get; init; } 
    #else
    public System.String? OriginalClearingSystemReference { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent, as provided in the original instruction.
    /// </summary>
    [IsoId("_bvqO5dcZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Interbank Settlement Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? OriginalInterbankSettlementAmount { get; init; } 
    #else
    public System.Decimal? OriginalInterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// Usage: the OriginalInterbankSettlementDate is the interbank settlement date of the original instruction return message, and not of the return message.
    /// </summary>
    [IsoId("_bvqO59cZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Interbank Settlement Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? OriginalInterbankSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? OriginalInterbankSettlementDate { get; init; } 
    #else
    public System.DateOnly? OriginalInterbankSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of the return transaction.
    /// </summary>
    [IsoId("_pV2nkdfxEeqoweZZxm4TPQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Type Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; } 
    #else
    public PaymentTypeInformation28? PaymentTypeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the instructing agent and the instructed agent in the returned instruction.
    /// </summary>
    [IsoId("_bvqO6dcZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Returned Interbank Settlement Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal ReturnedInterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal ReturnedInterbankSettlementAmount { get; init; } 
    #else
    public System.Decimal ReturnedInterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.||Usage: the InterbankSettlementDate is the interbank settlement date of the return message, and not of the original instruction.
    /// </summary>
    [IsoId("_bvqO69cZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interbank Settlement Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? InterbankSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? InterbankSettlementDate { get; init; } 
    #else
    public System.DateOnly? InterbankSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// Usage: the SettlementPriority is the settlement priority of the return message, and not of the original instruction.
    /// </summary>
    [IsoId("_bvqO7dcZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Priority")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Priority3Code? SettlementPriority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Priority3Code? SettlementPriority { get; init; } 
    #else
    public Priority3Code? SettlementPriority { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the occurred settlement time(s) of the payment transaction.
    /// </summary>
    [IsoId("_bvqO79cZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Time Indication")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; } 
    #else
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the requested settlement time(s) of the payment instruction.
    /// </summary>
    [IsoId("_kAhdcdf4EeqoweZZxm4TPQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Time Request")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; } 
    #else
    public SettlementTimeRequest2? SettlementTimeRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the returned transaction.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_bvqO8dcZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Returned Instructed Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ReturnedInstructedAmount { get; init; } 
    #else
    public System.Decimal? ReturnedInstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_bvqO89cZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Exchange Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExchangeRate { get; init; } 
    #else
    public System.Decimal? ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money asked or paid as compensation for the processing of the instruction.
    /// </summary>
    [IsoId("_bvqO9dcZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Compensation Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CompensationAmount { get; init; } 
    #else
    public System.Decimal? CompensationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the return message, not to the original instruction.
    /// </summary>
    [IsoId("_bvqO99cZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Charge Bearer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    #else
    public ChargeBearerType1Code? ChargeBearer { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the processing of the return transaction.
    /// </summary>
    [IsoId("_bvqO-dcZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Charges Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charges7? ChargesInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charges7? ChargesInformation { get; init; } 
    #else
    public Charges7? ChargesInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference, as assigned by the clearing system, to unambiguously identify the return instruction.
    /// </summary>
    [IsoId("_bvqO-9cZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Clearing System Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClearingSystemReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClearingSystemReference { get; init; } 
    #else
    public System.String? ClearingSystemReference { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).||Usage: The instructing agent is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    [IsoId("_bvqO_dcZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instructing Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).||Usage: The instructed agent is the party receiving the return message and not the party that received the original instruction that is being returned.
    /// </summary>
    [IsoId("_bvqO_9cZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instructed Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Provides all parties (agents and non-agents) involved in a return transaction.
    /// </summary>
    [IsoId("_bvqPAdcZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Return Chain")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionParties10? ReturnChain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionParties10? ReturnChain { get; init; } 
    #else
    public TransactionParties10? ReturnChain { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the return reason.
    /// </summary>
    [IsoId("_bvqPA9cZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Return Reason Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentReturnReason6? ReturnReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentReturnReason6? ReturnReasonInformation { get; init; } 
    #else
    public PaymentReturnReason6? ReturnReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_bvqPBdcZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Transaction Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalTransactionReference36? OriginalTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalTransactionReference36? OriginalTransactionReference { get; init; } 
    #else
    public OriginalTransactionReference36? OriginalTransactionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bvqPB9cZEeqRFcf2R4bPBw")]
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
