﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditTransferTransaction51.  ISO2002 ID# _bi4-IdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide further details specific to the individual transaction(s) included in the message.
/// </summary>
public partial record CreditTransferTransaction51
     : IIsoXmlSerilizable<CreditTransferTransaction51>
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to reference a payment instruction. 
    /// </summary>
    public required PaymentIdentification6 PaymentIdentification { get; init; } 
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; } 
    /// <summary>
    /// Specifies the rate of tax levied.
    /// </summary>
    public TaxRateMarker1Code? TaxRateMarker { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Set of elements needed to issue a cheque.
    /// </summary>
    public Cheque11? ChequeInstruction { get; init; } 
    /// <summary>
    /// The schedule for a credit payment arrangement. 
    /// </summary>
    public Frequency1? Frequency { get; init; } 
    /// <summary>
    /// Provides further information about the status of transferred scheduled payment(s).
    /// </summary>
    public TransferInstruction1? TransferInstruction { get; init; } 
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public PartyIdentification135? UltimateDebtor { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; } 
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    public PartyIdentification135? Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    public CashAccount40? CreditorAccount { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    public PartyIdentification135? UltimateCreditor { get; init; } 
    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    public InstructionForCreditorAgent3? InstructionForCreditorAgent { get; init; } 
    /// <summary>
    /// Underlying reason for the payment transaction.
    /// Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    public Purpose2Choice_? Purpose { get; init; } 
    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];
    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    public TaxInformation10? Tax { get; init; } 
    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    public ValueList<RemittanceLocation6> RelatedRemittanceInformation { get; init; } = [];
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    public RemittanceInformation21? RemittanceInformation { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "PmtId", xmlNamespace );
        PaymentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PaymentTypeInformation is PaymentTypeInformation26 PaymentTypeInformationValue)
        {
            writer.WriteStartElement(null, "PmtTpInf", xmlNamespace );
            PaymentTypeInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxRateMarker is TaxRateMarker1Code TaxRateMarkerValue)
        {
            writer.WriteStartElement(null, "TaxRateMrkr", xmlNamespace );
            writer.WriteValue(TaxRateMarkerValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(Amount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (ChargeBearer is ChargeBearerType1Code ChargeBearerValue)
        {
            writer.WriteStartElement(null, "ChrgBr", xmlNamespace );
            writer.WriteValue(ChargeBearerValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ChequeInstruction is Cheque11 ChequeInstructionValue)
        {
            writer.WriteStartElement(null, "ChqInstr", xmlNamespace );
            ChequeInstructionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Frequency is Frequency1 FrequencyValue)
        {
            writer.WriteStartElement(null, "Frqcy", xmlNamespace );
            FrequencyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransferInstruction is TransferInstruction1 TransferInstructionValue)
        {
            writer.WriteStartElement(null, "TrfInstr", xmlNamespace );
            TransferInstructionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UltimateDebtor is PartyIdentification135 UltimateDebtorValue)
        {
            writer.WriteStartElement(null, "UltmtDbtr", xmlNamespace );
            UltimateDebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent1 is BranchAndFinancialInstitutionIdentification6 IntermediaryAgent1Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt1", xmlNamespace );
            IntermediaryAgent1Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent2 is BranchAndFinancialInstitutionIdentification6 IntermediaryAgent2Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt2", xmlNamespace );
            IntermediaryAgent2Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent3 is BranchAndFinancialInstitutionIdentification6 IntermediaryAgent3Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt3", xmlNamespace );
            IntermediaryAgent3Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CdtrAgt", xmlNamespace );
        CreditorAgent.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Creditor is PartyIdentification135 CreditorValue)
        {
            writer.WriteStartElement(null, "Cdtr", xmlNamespace );
            CreditorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorAccount is CashAccount40 CreditorAccountValue)
        {
            writer.WriteStartElement(null, "CdtrAcct", xmlNamespace );
            CreditorAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UltimateCreditor is PartyIdentification135 UltimateCreditorValue)
        {
            writer.WriteStartElement(null, "UltmtCdtr", xmlNamespace );
            UltimateCreditorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructionForCreditorAgent is InstructionForCreditorAgent3 InstructionForCreditorAgentValue)
        {
            writer.WriteStartElement(null, "InstrForCdtrAgt", xmlNamespace );
            InstructionForCreditorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Purpose is Purpose2Choice_ PurposeValue)
        {
            writer.WriteStartElement(null, "Purp", xmlNamespace );
            PurposeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RgltryRptg", xmlNamespace );
        RegulatoryReporting.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Tax is TaxInformation10 TaxValue)
        {
            writer.WriteStartElement(null, "Tax", xmlNamespace );
            TaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RltdRmtInf", xmlNamespace );
        RelatedRemittanceInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (RemittanceInformation is RemittanceInformation21 RemittanceInformationValue)
        {
            writer.WriteStartElement(null, "RmtInf", xmlNamespace );
            RemittanceInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CreditTransferTransaction51 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
