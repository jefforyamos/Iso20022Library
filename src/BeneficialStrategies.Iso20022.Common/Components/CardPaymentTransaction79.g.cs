﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction79.  ISO2002 ID# _0yJ9EdmqEeeN3v2fup_Shw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the original transaction.
/// </summary>
public partial record CardPaymentTransaction79
     : IIsoXmlSerilizable<CardPaymentTransaction79>
{
    #nullable enable
    
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    public GenericIdentification32? POIIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    public IsoMax35Text? RecipientTransactionIdentification { get; init; } 
    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    public required CardPaymentServiceType12Code TransactionType { get; init; } 
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    public CardPaymentServiceType9Code? AdditionalService { get; init; } 
    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; } 
    /// <summary>
    /// Entry mode of the card information.
    /// </summary>
    public CardDataReading5Code? CardDataEntryMode { get; init; } 
    /// <summary>
    /// Result of the original transaction.
    /// </summary>
    public CardPaymentTransactionResult3? TransactionResult { get; init; } 
    
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
        if (SaleReferenceIdentification is IsoMax35Text SaleReferenceIdentificationValue)
        {
            writer.WriteStartElement(null, "SaleRefId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SaleReferenceIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (POIIdentification is GenericIdentification32 POIIdentificationValue)
        {
            writer.WriteStartElement(null, "POIId", xmlNamespace );
            POIIdentificationValue.Serialize(writer, xmlNamespace);
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
        if (CardDataEntryMode is CardDataReading5Code CardDataEntryModeValue)
        {
            writer.WriteStartElement(null, "CardDataNtryMd", xmlNamespace );
            writer.WriteValue(CardDataEntryModeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (TransactionResult is CardPaymentTransactionResult3 TransactionResultValue)
        {
            writer.WriteStartElement(null, "TxRslt", xmlNamespace );
            TransactionResultValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardPaymentTransaction79 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
