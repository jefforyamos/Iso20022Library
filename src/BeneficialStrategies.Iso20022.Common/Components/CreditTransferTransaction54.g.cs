﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditTransferTransaction54.  ISO2002 ID# _e15nSdcZEeqRFcf2R4bPBw.
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
/// Provide further details specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_e15nSdcZEeqRFcf2R4bPBw")]
[DisplayName("Credit Transfer Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditTransferTransaction54
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CreditTransferTransaction54 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreditTransferTransaction54( PaymentIdentification6 reqPaymentIdentification,AmountType4Choice_ reqAmount )
    {
        PaymentIdentification = reqPaymentIdentification;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_e3T8UdcZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtId")]
    #endif
    [IsoXmlTag("PmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentIdentification6 PaymentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentIdentification6 PaymentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification6 PaymentIdentification { get; init; } 
    #else
    public PaymentIdentification6 PaymentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_e3T8U9cZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Type Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTpInf")]
    #endif
    [IsoXmlTag("PmtTpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; } 
    #else
    public PaymentTypeInformation26? PaymentTypeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_e3T8VdcZEeqRFcf2R4bPBw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountType4Choice_ Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountType4Choice_ Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountType4Choice_ Amount { get; init; } 
    #else
    public AmountType4Choice_ Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the currency exchange rate and contract.
    /// </summary>
    [IsoId("_e3T8V9cZEeqRFcf2R4bPBw")]
    [DisplayName("Exchange Rate Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRateInf")]
    #endif
    [IsoXmlTag("XchgRateInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeRate1? ExchangeRateInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeRate1? ExchangeRateInformation { get; init; } 
    #else
    public ExchangeRate1? ExchangeRateInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_e3T8WdcZEeqRFcf2R4bPBw")]
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
    /// Provides further details of the mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("_e3T8W9cZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Related Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MndtRltdInf")]
    #endif
    [IsoXmlTag("MndtRltdInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; } 
    #else
    public CreditTransferMandateData1? MandateRelatedInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements needed to issue a cheque.
    /// </summary>
    [IsoId("_e3T8XdcZEeqRFcf2R4bPBw")]
    [DisplayName("Cheque Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChqInstr")]
    #endif
    [IsoXmlTag("ChqInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Cheque11? ChequeInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cheque11? ChequeInstruction { get; init; } 
    #else
    public Cheque11? ChequeInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_e3T8X9cZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtDbtr")]
    #endif
    [IsoXmlTag("UltmtDbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? UltimateDebtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? UltimateDebtor { get; init; } 
    #else
    public PartyIdentification135? UltimateDebtor { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_e3T8YdcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt1")]
    #endif
    [IsoXmlTag("IntrmyAgt1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_e3T8Y9cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent 1 Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt1Acct")]
    #endif
    [IsoXmlTag("IntrmyAgt1Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? IntermediaryAgent1Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? IntermediaryAgent1Account { get; init; } 
    #else
    public CashAccount40? IntermediaryAgent1Account { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_e3T8ZdcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt2")]
    #endif
    [IsoXmlTag("IntrmyAgt2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_e3T8Z9cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent 2 Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt2Acct")]
    #endif
    [IsoXmlTag("IntrmyAgt2Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? IntermediaryAgent2Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? IntermediaryAgent2Account { get; init; } 
    #else
    public CashAccount40? IntermediaryAgent2Account { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_e3T8adcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt3")]
    #endif
    [IsoXmlTag("IntrmyAgt3")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_e3T8a9cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent 3 Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt3Acct")]
    #endif
    [IsoXmlTag("IntrmyAgt3Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? IntermediaryAgent3Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? IntermediaryAgent3Account { get; init; } 
    #else
    public CashAccount40? IntermediaryAgent3Account { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_e3T8bdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_e3T8b9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgtAcct")]
    #endif
    [IsoXmlTag("CdtrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? CreditorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? CreditorAgentAccount { get; init; } 
    #else
    public CashAccount40? CreditorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_e3T8cdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? Creditor { get; init; } 
    #else
    public PartyIdentification135? Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_e3T8c9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAcct")]
    #endif
    [IsoXmlTag("CdtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? CreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? CreditorAccount { get; init; } 
    #else
    public CashAccount40? CreditorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_e3T8ddcZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtCdtr")]
    #endif
    [IsoXmlTag("UltmtCdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? UltimateCreditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? UltimateCreditor { get; init; } 
    #else
    public PartyIdentification135? UltimateCreditor { get; set; } 
    #endif
    
    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    [IsoId("_e3T8d9cZEeqRFcf2R4bPBw")]
    [DisplayName("Instruction For Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrForCdtrAgt")]
    #endif
    [IsoXmlTag("InstrForCdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructionForCreditorAgent3? InstructionForCreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionForCreditorAgent3? InstructionForCreditorAgent { get; init; } 
    #else
    public InstructionForCreditorAgent3? InstructionForCreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Further information related to the processing of the payment instruction, that may need to be acted upon by the debtor agent, depending on agreement between debtor and the debtor agent.
    /// </summary>
    [IsoId("_e3T8edcZEeqRFcf2R4bPBw")]
    [DisplayName("Instruction For Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrForDbtrAgt")]
    #endif
    [IsoXmlTag("InstrForDbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructionForDebtorAgent1? InstructionForDebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionForDebtorAgent1? InstructionForDebtorAgent { get; init; } 
    #else
    public InstructionForDebtorAgent1? InstructionForDebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_e3T8e9cZEeqRFcf2R4bPBw")]
    [DisplayName("Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Purp")]
    #endif
    [IsoXmlTag("Purp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Purpose2Choice_? Purpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Purpose2Choice_? Purpose { get; init; } 
    #else
    public Purpose2Choice_? Purpose { get; set; } 
    #endif
    
    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("_e3T8fdcZEeqRFcf2R4bPBw")]
    [DisplayName("Regulatory Reporting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryRptg")]
    #endif
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = new ValueList<RegulatoryReporting3>(){};
    
    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    [IsoId("_e3T8f9cZEeqRFcf2R4bPBw")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxInformation10? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxInformation10? Tax { get; init; } 
    #else
    public TaxInformation10? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_e3T8gdcZEeqRFcf2R4bPBw")]
    [DisplayName("Related Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRmtInf")]
    #endif
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = new ValueList<RemittanceLocation7>(){};
    
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_e3T8g9cZEeqRFcf2R4bPBw")]
    [DisplayName("Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtInf")]
    #endif
    [IsoXmlTag("RmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceInformation21? RemittanceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceInformation21? RemittanceInformation { get; init; } 
    #else
    public RemittanceInformation21? RemittanceInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_e3T8hdcZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
