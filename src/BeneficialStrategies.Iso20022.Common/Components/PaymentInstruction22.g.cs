﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentInstruction22.  ISO2002 ID# _k-FloZRsEeazAtAtDSg0Nw.
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
/// Characteristics that apply to the debit side of the payment transactions included in the credit transfer initiation.
/// </summary>
[IsoId("_k-FloZRsEeazAtAtDSg0Nw")]
[DisplayName("Payment Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentInstruction22
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentInstruction22 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentInstruction22( System.String reqPaymentInformationIdentification,PaymentMethod3Code reqPaymentMethod,DateAndDateTimeChoice_ reqRequestedExecutionDate,PartyIdentification43 reqDebtor,CashAccount24 reqDebtorAccount,BranchAndFinancialInstitutionIdentification5 reqDebtorAgent )
    {
        PaymentInformationIdentification = reqPaymentInformationIdentification;
        PaymentMethod = reqPaymentMethod;
        RequestedExecutionDate = reqRequestedExecutionDate;
        Debtor = reqDebtor;
        DebtorAccount = reqDebtorAccount;
        DebtorAgent = reqDebtorAgent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
    /// </summary>
    [IsoId("_lPZ_I5RsEeazAtAtDSg0Nw")]
    [DisplayName("Payment Information Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInfId")]
    #endif
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PaymentInformationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PaymentInformationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PaymentInformationIdentification { get; init; } 
    #else
    public System.String PaymentInformationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    [IsoId("_lPZ_JZRsEeazAtAtDSg0Nw")]
    [DisplayName("Payment Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtMtd")]
    #endif
    [IsoXmlTag("PmtMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentMethod3Code PaymentMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentMethod3Code PaymentMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentMethod3Code PaymentMethod { get; init; } 
    #else
    public PaymentMethod3Code PaymentMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    [IsoId("_lPZ_J5RsEeazAtAtDSg0Nw")]
    [DisplayName("Batch Booking")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchBookg")]
    #endif
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBatchBookingIndicator? BatchBooking { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BatchBooking { get; init; } 
    #else
    public System.String? BatchBooking { get; set; } 
    #endif
    
    /// <summary>
    /// Number of individual transactions contained in the payment information group.
    /// </summary>
    [IsoId("_lPZ_KZRsEeazAtAtDSg0Nw")]
    [DisplayName("Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfTxs")]
    #endif
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? NumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NumberOfTransactions { get; init; } 
    #else
    public System.String? NumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual amounts included in the group, irrespective of currencies.
    /// </summary>
    [IsoId("_lPZ_K5RsEeazAtAtDSg0Nw")]
    [DisplayName("Control Sum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrlSum")]
    #endif
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ControlSum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ControlSum { get; init; } 
    #else
    public System.UInt64? ControlSum { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_lPZ_LZRsEeazAtAtDSg0Nw")]
    [DisplayName("Payment Type Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTpInf")]
    #endif
    [IsoXmlTag("PmtTpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; } 
    #else
    public PaymentTypeInformation19? PaymentTypeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment. |Usage: This is the date on which the debtor&apos;s account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    [IsoId("_lPZ_L5RsEeazAtAtDSg0Nw")]
    [DisplayName("Requested Execution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdExctnDt")]
    #endif
    [IsoXmlTag("ReqdExctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ RequestedExecutionDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ RequestedExecutionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ RequestedExecutionDate { get; init; } 
    #else
    public DateAndDateTimeChoice_ RequestedExecutionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date used for the correction of the value date of a cash pool movement that has been posted with a different value date.
    /// </summary>
    [IsoId("_lPZ_MZRsEeazAtAtDSg0Nw")]
    [DisplayName("Pooling Adjustment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolgAdjstmntDt")]
    #endif
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? PoolingAdjustmentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? PoolingAdjustmentDate { get; init; } 
    #else
    public System.DateOnly? PoolingAdjustmentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_lPZ_M5RsEeazAtAtDSg0Nw")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification43 Debtor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification43 Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43 Debtor { get; init; } 
    #else
    public PartyIdentification43 Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_lPZ_NZRsEeazAtAtDSg0Nw")]
    [DisplayName("Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAcct")]
    #endif
    [IsoXmlTag("DbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount24 DebtorAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount24 DebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24 DebtorAccount { get; init; } 
    #else
    public CashAccount24 DebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_lPZ_N5RsEeazAtAtDSg0Nw")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_lPZ_OZRsEeazAtAtDSg0Nw")]
    [DisplayName("Debtor Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgtAcct")]
    #endif
    [IsoXmlTag("DbtrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? DebtorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? DebtorAgentAccount { get; init; } 
    #else
    public CashAccount24? DebtorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Further information related to the processing of the payment instruction, that may need to be acted upon by the debtor agent, depending on agreement between debtor and the debtor agent.
    /// Usage: when present, then the instructions for the debtor agent apply for all credit transfer transaction information occurrences, present in the payment information.
    /// </summary>
    [IsoId("_lPZ_O5RsEeazAtAtDSg0Nw")]
    [DisplayName("Instruction For Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrForDbtrAgt")]
    #endif
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? InstructionForDebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionForDebtorAgent { get; init; } 
    #else
    public System.String? InstructionForDebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_lPZ_PZRsEeazAtAtDSg0Nw")]
    [DisplayName("Ultimate Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtDbtr")]
    #endif
    [IsoXmlTag("UltmtDbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? UltimateDebtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? UltimateDebtor { get; init; } 
    #else
    public PartyIdentification43? UltimateDebtor { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_lPZ_P5RsEeazAtAtDSg0Nw")]
    [DisplayName("Charge Bearer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBr")]
    #endif
    [IsoXmlTag("ChrgBr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    #else
    public ChargeBearerType1Code? ChargeBearer { get; set; } 
    #endif
    
    /// <summary>
    /// Account used to process charges associated with a transaction.||Usage: Charges account should be used when charges have to be booked to an account different from the account identified in debtor&apos;s account.
    /// </summary>
    [IsoId("_lPZ_QZRsEeazAtAtDSg0Nw")]
    [DisplayName("Charges Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsAcct")]
    #endif
    [IsoXmlTag("ChrgsAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? ChargesAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? ChargesAccount { get; init; } 
    #else
    public CashAccount24? ChargesAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that services a charges account.||Usage: Charges account agent should only be used when the charges account agent is different from the debtor agent.
    /// </summary>
    [IsoId("_lPZ_Q5RsEeazAtAtDSg0Nw")]
    [DisplayName("Charges Account Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsAcctAgt")]
    #endif
    [IsoXmlTag("ChrgsAcctAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? ChargesAccountAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? ChargesAccountAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? ChargesAccountAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the individual transaction(s) included in the message.
    /// </summary>
    [IsoId("_lPZ_RZRsEeazAtAtDSg0Nw")]
    [DisplayName("Credit Transfer Transaction Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtTrfTxInf")]
    #endif
    [IsoXmlTag("CdtTrfTxInf")]
    public CreditTransferTransaction26? CreditTransferTransactionInformation { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _lPZ_RZRsEeazAtAtDSg0Nw
    
    
    #nullable disable
    
}
