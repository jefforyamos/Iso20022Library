﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction89.  ISO2002 ID# _X-k7odegEeiJyp_aycJaTw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction information in the completion advice message.
/// </summary>
public partial record CardPaymentTransaction89
     : IIsoXmlSerilizable<CardPaymentTransaction89>
{
    #nullable enable
    
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    public IsoTrueFalseIndicator? TransactionCapture { get; init; } 
    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    public CardPaymentServiceType12Code? TransactionType { get; init; } 
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    public CardPaymentServiceType9Code? AdditionalService { get; init; } 
    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; } 
    /// <summary>
    /// Flag indicating processing of the last transaction.
    /// </summary>
    public IsoTrueFalseIndicator? LastTransactionFlag { get; init; } 
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; } 
    /// <summary>
    /// This enables retailers, if they so wish, to clearly indicate whether the consent of the customer was explicitly obtained for a given service instead of being implicitly derived.
    /// </summary>
    public IsoTrueFalseIndicator? CustomerConsent { get; init; } 
    /// <summary>
    /// The card program proposed by a retailer to a cardholder among a series of payment programmes offered by the retailer.
    /// </summary>
    public IsoMax35Text? CardProgrammeProposed { get; init; } 
    /// <summary>
    /// The card program actually selected by the cardholder among the ones supported by the retailer and/or the one actually proposed to him.
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
    public CardPaymentTransaction79? OriginalTransaction { get; init; } 
    /// <summary>
    /// Outcome of the transaction at the acceptor.
    /// </summary>
    public required IsoTrueFalseIndicator TransactionSuccess { get; init; } 
    /// <summary>
    /// Notify that a previous transaction has to be reversed if this original transaction has been approved by the acquirer.
    /// </summary>
    public IsoTrueFalseIndicator? Reversal { get; init; } 
    /// <summary>
    /// Indicate that the acceptor has forced the transaction in spite of the authorisation result (online or offline), or incident to complete the transaction.
    /// </summary>
    public IsoTrueFalseIndicator? MerchantOverride { get; init; } 
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
    public required CardPaymentTransactionDetails47 TransactionDetails { get; init; } 
    /// <summary>
    /// Outcome of the authorisation request.
    /// </summary>
    public AuthorisationResult11? AuthorisationResult { get; init; } 
    /// <summary>
    /// Result of the performed verifications for the transaction.
    /// </summary>
    public TransactionVerificationResult4? TransactionVerificationResult { get; init; } 
    /// <summary>
    /// Merchant information that must be returned unchanged in the response.
    /// </summary>
    public IsoMax70Text? MerchantReferenceData { get; init; } 
    /// <summary>
    /// Information relevant to the account where the money is taken from.
    /// </summary>
    public CardAccount15? AccountFrom { get; init; } 
    /// <summary>
    /// Information relevant to the account where the money is put.
    /// </summary>
    public CardAccount15? AccountTo { get; init; } 
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
        if (TransactionCapture is IsoTrueFalseIndicator TransactionCaptureValue)
        {
            writer.WriteStartElement(null, "TxCaptr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(TransactionCaptureValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (TransactionType is CardPaymentServiceType12Code TransactionTypeValue)
        {
            writer.WriteStartElement(null, "TxTp", xmlNamespace );
            writer.WriteValue(TransactionTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AdditionalService is CardPaymentServiceType9Code AdditionalServiceValue)
        {
            writer.WriteStartElement(null, "AddtlSvc", xmlNamespace );
            writer.WriteValue(AdditionalServiceValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ServiceAttribute is CardPaymentServiceType3Code ServiceAttributeValue)
        {
            writer.WriteStartElement(null, "SvcAttr", xmlNamespace );
            writer.WriteValue(ServiceAttributeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (LastTransactionFlag is IsoTrueFalseIndicator LastTransactionFlagValue)
        {
            writer.WriteStartElement(null, "LastTxFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(LastTransactionFlagValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (MerchantCategoryCode is IsoMin3Max4Text MerchantCategoryCodeValue)
        {
            writer.WriteStartElement(null, "MrchntCtgyCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMin3Max4Text(MerchantCategoryCodeValue)); // data type Min3Max4Text System.String
            writer.WriteEndElement();
        }
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
        if (OriginalTransaction is CardPaymentTransaction79 OriginalTransactionValue)
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
        if (MerchantOverride is IsoTrueFalseIndicator MerchantOverrideValue)
        {
            writer.WriteStartElement(null, "MrchntOvrrd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(MerchantOverrideValue)); // data type TrueFalseIndicator System.String
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
        if (AuthorisationResult is AuthorisationResult11 AuthorisationResultValue)
        {
            writer.WriteStartElement(null, "AuthstnRslt", xmlNamespace );
            AuthorisationResultValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionVerificationResult is TransactionVerificationResult4 TransactionVerificationResultValue)
        {
            writer.WriteStartElement(null, "TxVrfctnRslt", xmlNamespace );
            TransactionVerificationResultValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MerchantReferenceData is IsoMax70Text MerchantReferenceDataValue)
        {
            writer.WriteStartElement(null, "MrchntRefData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(MerchantReferenceDataValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (AccountFrom is CardAccount15 AccountFromValue)
        {
            writer.WriteStartElement(null, "AcctFr", xmlNamespace );
            AccountFromValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountTo is CardAccount15 AccountToValue)
        {
            writer.WriteStartElement(null, "AcctTo", xmlNamespace );
            AccountToValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalTransactionData is IsoMax70Text AdditionalTransactionDataValue)
        {
            writer.WriteStartElement(null, "AddtlTxData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(AdditionalTransactionDataValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
    }
    public static CardPaymentTransaction89 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
