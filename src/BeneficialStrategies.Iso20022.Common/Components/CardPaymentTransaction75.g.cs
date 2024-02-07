﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction75.  ISO2002 ID# _Ki58QbL1EeaRnrUTla0j3A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction information in the cancellation advice.
/// </summary>
public partial record CardPaymentTransaction75
     : IIsoXmlSerilizable<CardPaymentTransaction75>
{
    #nullable enable
    
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    public required IsoMin3Max4Text MerchantCategoryCode { get; init; } 
    /// <summary>
    /// This enables retailers, if they so wish, to clearly indicate whether the consent of the customer was explicitly obtained for a given service instead of being implicitly derived.
    /// </summary>
    public IsoTrueFalseIndicator? CustomerConsent { get; init; } 
    /// <summary>
    /// The card programme proposed by a retailer to a cardholder among a series of payment programmes offered by the retailer.
    /// </summary>
    public IsoMax35Text? CardProgrammeProposed { get; init; } 
    /// <summary>
    /// The card programme actually selected by the cardholder among the ones supported by the retailer and/or the one actually proposed to him.
    /// </summary>
    public IsoMax35Text? CardProgrammeApplied { get; init; } 
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    public CardPaymentTransaction52? OriginalTransaction { get; init; } 
    /// <summary>
    /// Outcome of the transaction at the acceptor.
    /// </summary>
    public required IsoTrueFalseIndicator TransactionSuccess { get; init; } 
    /// <summary>
    /// Notify that a previous transaction has to be reversed if this original transaction has been approved by the acquirer.
    /// </summary>
    public IsoTrueFalseIndicator? Reversal { get; init; } 
    /// <summary>
    /// List of incidents during the transaction.
    /// </summary>
    public FailureReason3Code? FailureReason { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    public IsoMax35Text? RecipientTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Interchange information related to the card scheme.
    /// </summary>
    public IsoMax140Text? InterchangeData { get; init; } 
    /// <summary>
    /// Details of the transaction.
    /// </summary>
    public required CardPaymentTransactionDetails34 TransactionDetails { get; init; } 
    /// <summary>
    /// Outcome of the authorisation.
    /// </summary>
    public AuthorisationResult12? AuthorisationResult { get; init; } 
    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    public IsoMax70Text? AdditionalTransactionData { get; init; } 
    
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
        writer.WriteStartElement(null, "MrchntCtgyCd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMin3Max4Text(MerchantCategoryCode)); // data type Min3Max4Text System.String
        writer.WriteEndElement();
        if (CustomerConsent is IsoTrueFalseIndicator CustomerConsentValue)
        {
            writer.WriteStartElement(null, "CstmrCnsnt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(CustomerConsentValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (CardProgrammeProposed is IsoMax35Text CardProgrammeProposedValue)
        {
            writer.WriteStartElement(null, "CardPrgrmmPropsd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CardProgrammeProposedValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CardProgrammeApplied is IsoMax35Text CardProgrammeAppliedValue)
        {
            writer.WriteStartElement(null, "CardPrgrmmApld", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CardProgrammeAppliedValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SaleReferenceIdentification is IsoMax35Text SaleReferenceIdentificationValue)
        {
            writer.WriteStartElement(null, "SaleRefId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SaleReferenceIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OriginalTransaction is CardPaymentTransaction52 OriginalTransactionValue)
        {
            writer.WriteStartElement(null, "OrgnlTx", xmlNamespace );
            OriginalTransactionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxSucss", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(TransactionSuccess)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
        if (Reversal is IsoTrueFalseIndicator ReversalValue)
        {
            writer.WriteStartElement(null, "Rvsl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(ReversalValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (FailureReason is FailureReason3Code FailureReasonValue)
        {
            writer.WriteStartElement(null, "FailrRsn", xmlNamespace );
            writer.WriteValue(FailureReasonValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (InitiatorTransactionIdentification is IsoMax35Text InitiatorTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "InitrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(InitiatorTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (RecipientTransactionIdentification is IsoMax35Text RecipientTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "RcptTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(RecipientTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ReconciliationIdentification is IsoMax35Text ReconciliationIdentificationValue)
        {
            writer.WriteStartElement(null, "RcncltnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReconciliationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (InterchangeData is IsoMax140Text InterchangeDataValue)
        {
            writer.WriteStartElement(null, "IntrchngData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(InterchangeDataValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxDtls", xmlNamespace );
        TransactionDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AuthorisationResult is AuthorisationResult12 AuthorisationResultValue)
        {
            writer.WriteStartElement(null, "AuthstnRslt", xmlNamespace );
            AuthorisationResultValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalTransactionData is IsoMax70Text AdditionalTransactionDataValue)
        {
            writer.WriteStartElement(null, "AddtlTxData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(AdditionalTransactionDataValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
    }
    public static CardPaymentTransaction75 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
