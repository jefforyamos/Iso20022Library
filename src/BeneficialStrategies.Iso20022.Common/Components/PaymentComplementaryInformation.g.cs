﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentComplementaryInformation.  ISO2002 ID# _PgmFMdp-Ed-ak6NoX_4Aeg_-1588306924.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information from the underlying payment instruction which cannot be transferred in a regular statement message.
/// </summary>
public partial record PaymentComplementaryInformation
     : IIsoXmlSerilizable<PaymentComplementaryInformation>
{
    #nullable enable
    
    /// <summary>
    /// Remittance information.
    /// </summary>
    public RemittanceInformation3Choice_? RemittanceChoice { get; init; } 
    /// <summary>
    /// Debtor or Ordering customer of the payment instruction.
    /// </summary>
    public PartyIdentification1? Debtor { get; init; } 
    /// <summary>
    /// Debtor account or Ordering customer account.
    /// </summary>
    public CashAccount3? DebtorAccount { get; init; } 
    /// <summary>
    /// First Agent or Field 52 in Fin messages.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification? FirstAgent { get; init; } 
    /// <summary>
    /// Instructed amount of the payment instruction (Field 33B).
    /// </summary>
    public AmountType1Choice_? Amount { get; init; } 
    /// <summary>
    /// Indicates the account used to cover a payment.
    /// </summary>
    public CashAccount3? NostroVostroAccount { get; init; } 
    /// <summary>
    /// Intermediary bank.
    /// </summary>
    public Intermediary1? Intermediary { get; init; } 
    /// <summary>
    /// Correspondent of the first agent (Field 53 in MT202).
    /// </summary>
    public BranchAndFinancialInstitutionIdentification? FirstSettlementAgent { get; init; } 
    /// <summary>
    /// Correspondent of the Final agent (Field 54 of Mt 202).
    /// </summary>
    public BranchAndFinancialInstitutionIdentification? LastSettlementAgent { get; init; } 
    /// <summary>
    /// Equivalent to Field 55 in MT202.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification? IntermediarySettlementAgent { get; init; } 
    /// <summary>
    /// Creditor or Beneficiary customer of the payment instruction.
    /// </summary>
    public PartyIdentification1? Creditor { get; init; } 
    /// <summary>
    /// Creditor account or Beneficiary customer account.
    /// </summary>
    public CashAccount3? CreditorAccount { get; init; } 
    /// <summary>
    /// Unformatted information from the sender to the receiver.
    /// </summary>
    public SimpleValueList<IsoMax35Text> SenderToReceiverInformation { get; init; } = [];
    
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
        if (RemittanceChoice is RemittanceInformation3Choice_ RemittanceChoiceValue)
        {
            writer.WriteStartElement(null, "RmtChc", xmlNamespace );
            RemittanceChoiceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Debtor is PartyIdentification1 DebtorValue)
        {
            writer.WriteStartElement(null, "Dbtr", xmlNamespace );
            DebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DebtorAccount is CashAccount3 DebtorAccountValue)
        {
            writer.WriteStartElement(null, "DbtrAcct", xmlNamespace );
            DebtorAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FirstAgent is BranchAndFinancialInstitutionIdentification FirstAgentValue)
        {
            writer.WriteStartElement(null, "FrstAgt", xmlNamespace );
            FirstAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Amount is AmountType1Choice_ AmountValue)
        {
            writer.WriteStartElement(null, "Amt", xmlNamespace );
            AmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NostroVostroAccount is CashAccount3 NostroVostroAccountValue)
        {
            writer.WriteStartElement(null, "NstrVstrAcct", xmlNamespace );
            NostroVostroAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Intermediary is Intermediary1 IntermediaryValue)
        {
            writer.WriteStartElement(null, "Intrmy", xmlNamespace );
            IntermediaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FirstSettlementAgent is BranchAndFinancialInstitutionIdentification FirstSettlementAgentValue)
        {
            writer.WriteStartElement(null, "FrstSttlmAgt", xmlNamespace );
            FirstSettlementAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LastSettlementAgent is BranchAndFinancialInstitutionIdentification LastSettlementAgentValue)
        {
            writer.WriteStartElement(null, "LastSttlmAgt", xmlNamespace );
            LastSettlementAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediarySettlementAgent is BranchAndFinancialInstitutionIdentification IntermediarySettlementAgentValue)
        {
            writer.WriteStartElement(null, "IntrmySttlmAgt", xmlNamespace );
            IntermediarySettlementAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Creditor is PartyIdentification1 CreditorValue)
        {
            writer.WriteStartElement(null, "Cdtr", xmlNamespace );
            CreditorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorAccount is CashAccount3 CreditorAccountValue)
        {
            writer.WriteStartElement(null, "CdtrAcct", xmlNamespace );
            CreditorAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SndrToRcvrInf", xmlNamespace );
        SenderToReceiverInformation.Serialize(writer, xmlNamespace, "Max35Text", SerializationFormatter.IsoMax35Text );
        writer.WriteEndElement();
    }
    public static PaymentComplementaryInformation Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
