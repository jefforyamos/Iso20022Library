﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OriginalMandate.  ISO2002 ID# _Z7tR9W49EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate7Choice;

/// <summary>
/// Provides the original mandate data.
/// </summary>
public partial record OriginalMandate : OriginalMandate7Choice_
     , IIsoXmlSerilizable<OriginalMandate>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the responsible party (such as the creditor) or agent (such as the debtor agent), to unambiguously identify the mandate.
    /// </summary>
    public IsoMax35Text? MandateIdentification { get; init; } 
    /// <summary>
    /// Identification for the mandate request, as assigned by the initiating party.
    /// </summary>
    public IsoMax35Text? MandateRequestIdentification { get; init; } 
    /// <summary>
    /// Specifies the transport authentication details related to the mandate.
    /// </summary>
    public MandateAuthentication1? Authentication { get; init; } 
    /// <summary>
    /// Specifies the type of mandate, such as paper, electronic or scheme.
    /// </summary>
    public MandateTypeInformation2? Type { get; init; } 
    /// <summary>
    /// Provides details of the duration of the mandate and occurrence of the underlying transactions.
    /// </summary>
    public MandateOccurrences4? Occurrences { get; init; } 
    /// <summary>
    /// Specifies whether the direct debit instructions should be automatically re-submitted periodically when bilaterally agreed.
    /// </summary>
    public required IsoTrueFalseIndicator TrackingIndicator { get; init; } 
    /// <summary>
    /// Amount different from the collection amount, as it includes the costs associated with the first debited amount.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? FirstCollectionAmount { get; init; } 
    /// <summary>
    /// Fixed amount to be collected from the debtor's account.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; init; } 
    /// <summary>
    /// Maximum amount that may be collected from the debtor's account, per instruction.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; init; } 
    /// <summary>
    /// Specifies the characteristics of the adjustment applied to the collection amount of a direct debit instruction.
    /// </summary>
    public MandateAdjustment1? Adjustment { get; init; } 
    /// <summary>
    /// Provides the reason for the setup of the mandate.
    /// </summary>
    public MandateSetupReason1Choice_? Reason { get; init; } 
    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    public PartyIdentification135? CreditorSchemeIdentification { get; init; } 
    /// <summary>
    /// Party that signs the mandate and to whom an amount of money is due.
    /// </summary>
    public required PartyIdentification135 Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    public CashAccount38? CreditorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    public PartyIdentification135? UltimateCreditor { get; init; } 
    /// <summary>
    /// Party that signs the mandate and owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public required PartyIdentification135 Debtor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor, to which a debit entry will be made as a result of the transaction.
    /// </summary>
    public CashAccount38? DebtorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; } 
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public PartyIdentification135? UltimateDebtor { get; init; } 
    /// <summary>
    /// Reference assigned by a creditor or ultimate creditor for internal usage for the mandate.
    /// </summary>
    public IsoMax35Text? MandateReference { get; init; } 
    /// <summary>
    /// Provides information to identify the underlying documents associated with the mandate.
    /// </summary>
    public ReferredMandateDocument1? ReferredDocument { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (MandateIdentification is IsoMax35Text MandateIdentificationValue)
        {
            writer.WriteStartElement(null, "MndtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MandateIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (MandateRequestIdentification is IsoMax35Text MandateRequestIdentificationValue)
        {
            writer.WriteStartElement(null, "MndtReqId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MandateRequestIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Authentication is MandateAuthentication1 AuthenticationValue)
        {
            writer.WriteStartElement(null, "Authntcn", xmlNamespace );
            AuthenticationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Type is MandateTypeInformation2 TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            TypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Occurrences is MandateOccurrences4 OccurrencesValue)
        {
            writer.WriteStartElement(null, "Ocrncs", xmlNamespace );
            OccurrencesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TrckgInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(TrackingIndicator)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
        if (FirstCollectionAmount is IsoActiveOrHistoricCurrencyAndAmount FirstCollectionAmountValue)
        {
            writer.WriteStartElement(null, "FrstColltnAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(FirstCollectionAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CollectionAmount is IsoActiveOrHistoricCurrencyAndAmount CollectionAmountValue)
        {
            writer.WriteStartElement(null, "ColltnAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(CollectionAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (MaximumAmount is IsoActiveOrHistoricCurrencyAndAmount MaximumAmountValue)
        {
            writer.WriteStartElement(null, "MaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(MaximumAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Adjustment is MandateAdjustment1 AdjustmentValue)
        {
            writer.WriteStartElement(null, "Adjstmnt", xmlNamespace );
            AdjustmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Reason is MandateSetupReason1Choice_ ReasonValue)
        {
            writer.WriteStartElement(null, "Rsn", xmlNamespace );
            ReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorSchemeIdentification is PartyIdentification135 CreditorSchemeIdentificationValue)
        {
            writer.WriteStartElement(null, "CdtrSchmeId", xmlNamespace );
            CreditorSchemeIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Cdtr", xmlNamespace );
        Creditor.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CreditorAccount is CashAccount38 CreditorAccountValue)
        {
            writer.WriteStartElement(null, "CdtrAcct", xmlNamespace );
            CreditorAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorAgent is BranchAndFinancialInstitutionIdentification6 CreditorAgentValue)
        {
            writer.WriteStartElement(null, "CdtrAgt", xmlNamespace );
            CreditorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UltimateCreditor is PartyIdentification135 UltimateCreditorValue)
        {
            writer.WriteStartElement(null, "UltmtCdtr", xmlNamespace );
            UltimateCreditorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Dbtr", xmlNamespace );
        Debtor.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DebtorAccount is CashAccount38 DebtorAccountValue)
        {
            writer.WriteStartElement(null, "DbtrAcct", xmlNamespace );
            DebtorAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DbtrAgt", xmlNamespace );
        DebtorAgent.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (UltimateDebtor is PartyIdentification135 UltimateDebtorValue)
        {
            writer.WriteStartElement(null, "UltmtDbtr", xmlNamespace );
            UltimateDebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MandateReference is IsoMax35Text MandateReferenceValue)
        {
            writer.WriteStartElement(null, "MndtRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MandateReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ReferredDocument is ReferredMandateDocument1 ReferredDocumentValue)
        {
            writer.WriteStartElement(null, "RfrdDoc", xmlNamespace );
            ReferredDocumentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new OriginalMandate Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
