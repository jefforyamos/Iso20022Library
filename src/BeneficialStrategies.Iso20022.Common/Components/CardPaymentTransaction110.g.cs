﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction110.  ISO2002 ID# _dua1MS83Eeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data associated with the transaction for a potential currency conversion.
/// </summary>
public partial record CardPaymentTransaction110
     : IIsoXmlSerilizable<CardPaymentTransaction110>
{
    #nullable enable
    
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    public IsoTrueFalseIndicator? TransactionCapture { get; init; } 
    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    public required CardPaymentServiceType5Code TransactionType { get; init; } 
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
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the initiator of the request. For instance refers to POITransactionIdentification if used inside an authorisation request or to SaleTransactionIdentification if the message is a payment request initiated by a sale system.
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    public CardPaymentTransaction112? OriginalTransaction { get; init; } 
    /// <summary>
    /// Unique identification of the Acquirer/Acceptor reconciliation period.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    public IsoMax140Text? IssuerReferenceData { get; init; } 
    /// <summary>
    /// Details of the transaction.
    /// </summary>
    public required CardPaymentTransactionDetails49 TransactionDetails { get; init; } 
    /// <summary>
    /// Merchant information that must be returned unchanged in the response.
    /// </summary>
    public IsoMax70Text? MerchantReferenceData { get; init; } 
    /// <summary>
    /// Customer Order processing data.
    /// </summary>
    public CustomerOrder1? CustomerOrder { get; init; } 
    /// <summary>
    /// Customer payment token information.
    /// </summary>
    public CardPaymentToken5? CustomerToken { get; init; } 
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
    /// The POI System receives this information.
    /// </summary>
    public IsoMax70Text? SaleToPOIData { get; init; } 
    /// <summary>
    /// Sale information intended for the Acquirer.
    /// </summary>
    public IsoMax70Text? SaleToAcquirerData { get; init; } 
    /// <summary>
    /// Sale information intended for the Issuer.
    /// </summary>
    public IsoMax70Text? SaleToIssuerData { get; init; } 
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
        writer.WriteStartElement(null, "TxTp", xmlNamespace );
        writer.WriteValue(TransactionType.ToString()); // Enum value
        writer.WriteEndElement();
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
        if (SaleReferenceIdentification is IsoMax35Text SaleReferenceIdentificationValue)
        {
            writer.WriteStartElement(null, "SaleRefId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SaleReferenceIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OriginalTransaction is CardPaymentTransaction112 OriginalTransactionValue)
        {
            writer.WriteStartElement(null, "OrgnlTx", xmlNamespace );
            OriginalTransactionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReconciliationIdentification is IsoMax35Text ReconciliationIdentificationValue)
        {
            writer.WriteStartElement(null, "RcncltnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReconciliationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (IssuerReferenceData is IsoMax140Text IssuerReferenceDataValue)
        {
            writer.WriteStartElement(null, "IssrRefData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(IssuerReferenceDataValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxDtls", xmlNamespace );
        TransactionDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MerchantReferenceData is IsoMax70Text MerchantReferenceDataValue)
        {
            writer.WriteStartElement(null, "MrchntRefData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(MerchantReferenceDataValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (CustomerOrder is CustomerOrder1 CustomerOrderValue)
        {
            writer.WriteStartElement(null, "CstmrOrdr", xmlNamespace );
            CustomerOrderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CustomerToken is CardPaymentToken5 CustomerTokenValue)
        {
            writer.WriteStartElement(null, "CstmrTkn", xmlNamespace );
            CustomerTokenValue.Serialize(writer, xmlNamespace);
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
        if (SaleToPOIData is IsoMax70Text SaleToPOIDataValue)
        {
            writer.WriteStartElement(null, "SaleToPOIData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(SaleToPOIDataValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (SaleToAcquirerData is IsoMax70Text SaleToAcquirerDataValue)
        {
            writer.WriteStartElement(null, "SaleToAcqrrData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(SaleToAcquirerDataValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (SaleToIssuerData is IsoMax70Text SaleToIssuerDataValue)
        {
            writer.WriteStartElement(null, "SaleToIssrData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(SaleToIssuerDataValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalTransactionData is IsoMax70Text AdditionalTransactionDataValue)
        {
            writer.WriteStartElement(null, "AddtlTxData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(AdditionalTransactionDataValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
    }
    public static CardPaymentTransaction110 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
