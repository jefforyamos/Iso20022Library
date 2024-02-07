﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Individual.  ISO2002 ID# _0jmr8zj3EeSz-s1QOUJaOg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CardTransaction2Choice;

/// <summary>
/// Card transaction details for the individual transaction, as recorded at the POI (point of interaction).
/// </summary>
public partial record Individual : CardTransaction2Choice_
     , IIsoXmlSerilizable<Individual>
{
    #nullable enable
    
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    public IsoMax1025Text? ICCRelatedData { get; init; } 
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    public PaymentContext3? PaymentContext { get; init; } 
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    public CardPaymentServiceType2Code? AdditionalService { get; init; } 
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// This element is also known as the MerchantCategoryCode.
    /// </summary>
    public ExternalCardTransactionCategory1Code? TransactionCategory { get; init; } 
    /// <summary>
    /// Unique identification of the sales reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    public IsoMax35Text? SaleReconciliationIdentification { get; init; } 
    /// <summary>
    /// Unique reference of the sales as provided by the merchant.
    /// </summary>
    public IsoMax35Text? SaleReferenceNumber { get; init; } 
    /// <summary>
    /// Reason for representment of a card transaction.
    /// </summary>
    public ExternalRePresentmentReason1Code? RePresentmentReason { get; init; } 
    /// <summary>
    /// Sequential number of the card transaction, as assigned by the POI (Point of Interaction). |Usage: The sequential number is increased incrementally for each transaction.
    /// </summary>
    public IsoMax35Text? SequenceNumber { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    public TransactionIdentifier1? TransactionIdentification { get; init; } 
    /// <summary>
    /// Product purchased with the transaction.
    /// </summary>
    public Product2? Product { get; init; } 
    /// <summary>
    /// Date when the deposit was validated by the financial institution that collected the cash.
    /// </summary>
    public IsoISODate? ValidationDate { get; init; } 
    /// <summary>
    /// Sequential number of the validation of the cash deposit.
    /// Usage: The sequential number is increased incrementally for each transaction.
    /// </summary>
    public IsoMax35Text? ValidationSequenceNumber { get; init; } 
    
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
        if (ICCRelatedData is IsoMax1025Text ICCRelatedDataValue)
        {
            writer.WriteStartElement(null, "ICCRltdData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax1025Text(ICCRelatedDataValue)); // data type Max1025Text System.String
            writer.WriteEndElement();
        }
        if (PaymentContext is PaymentContext3 PaymentContextValue)
        {
            writer.WriteStartElement(null, "PmtCntxt", xmlNamespace );
            PaymentContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalService is CardPaymentServiceType2Code AdditionalServiceValue)
        {
            writer.WriteStartElement(null, "AddtlSvc", xmlNamespace );
            writer.WriteValue(AdditionalServiceValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (TransactionCategory is ExternalCardTransactionCategory1Code TransactionCategoryValue)
        {
            writer.WriteStartElement(null, "TxCtgy", xmlNamespace );
            writer.WriteValue(TransactionCategoryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SaleReconciliationIdentification is IsoMax35Text SaleReconciliationIdentificationValue)
        {
            writer.WriteStartElement(null, "SaleRcncltnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SaleReconciliationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SaleReferenceNumber is IsoMax35Text SaleReferenceNumberValue)
        {
            writer.WriteStartElement(null, "SaleRefNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SaleReferenceNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (RePresentmentReason is ExternalRePresentmentReason1Code RePresentmentReasonValue)
        {
            writer.WriteStartElement(null, "RePresntmntRsn", xmlNamespace );
            writer.WriteValue(RePresentmentReasonValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SequenceNumber is IsoMax35Text SequenceNumberValue)
        {
            writer.WriteStartElement(null, "SeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SequenceNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TransactionIdentification is TransactionIdentifier1 TransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "TxId", xmlNamespace );
            TransactionIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Product is Product2 ProductValue)
        {
            writer.WriteStartElement(null, "Pdct", xmlNamespace );
            ProductValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ValidationDate is IsoISODate ValidationDateValue)
        {
            writer.WriteStartElement(null, "VldtnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ValidationDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (ValidationSequenceNumber is IsoMax35Text ValidationSequenceNumberValue)
        {
            writer.WriteStartElement(null, "VldtnSeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ValidationSequenceNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static new Individual Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
