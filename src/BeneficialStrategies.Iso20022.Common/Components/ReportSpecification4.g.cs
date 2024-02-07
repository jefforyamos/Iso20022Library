﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportSpecification4.  ISO2002 ID# _PcRl4dp-Ed-ak6NoX_4Aeg_1375759875.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the parameters for which a transaction report must be generated.
/// </summary>
public partial record ReportSpecification4
     : IIsoXmlSerilizable<ReportSpecification4>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to a transaction, for which the matching application must generate a report.
    /// </summary>
    public IsoMax35Text? TransactionIdentification { get; init; } 
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    public TransactionStatus4? TransactionStatus { get; init; } 
    /// <summary>
    /// Reference to the identification of a transaction of a user, for which the matching application must generate a report.
    /// </summary>
    public IsoMax35Text? SubmitterTransactionReference { get; init; } 
    /// <summary>
    /// Specifies a list of entities for which the matching application must generate a report.
    /// </summary>
    public BICIdentification1? EntitiesToBeReported { get; init; } 
    /// <summary>
    /// Financial institution that is the counterparty to the trade transaction.
    /// </summary>
    public BICIdentification1? Correspondent { get; init; } 
    /// <summary>
    /// Financial institution that is a data set submitting bank to the transaction.
    /// </summary>
    public BICIdentification1? SubmittingBank { get; init; } 
    /// <summary>
    /// Financial institution that is an obligor bank to the transaction.
    /// </summary>
    public BICIdentification1? ObligorBank { get; init; } 
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    public PartyIdentification28? Buyer { get; init; } 
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    public PartyIdentification28? Seller { get; init; } 
    /// <summary>
    /// Country of the buyer.
    /// </summary>
    public CountryCode? BuyerCountry { get; init; } 
    /// <summary>
    /// Country of the seller.
    /// </summary>
    public CountryCode? SellerCountry { get; init; } 
    /// <summary>
    /// Country of the financial institution which is the other party to the trade.
    /// </summary>
    public CountryCode? CorrespondentCountry { get; init; } 
    /// <summary>
    /// Specifies a pending request for action for which the matching application must generate a report.
    /// </summary>
    public PendingActivity1? PendingRequestForAction { get; init; } 
    
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
        if (TransactionIdentification is IsoMax35Text TransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "TxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TransactionStatus is TransactionStatus4 TransactionStatusValue)
        {
            writer.WriteStartElement(null, "TxSts", xmlNamespace );
            TransactionStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SubmitterTransactionReference is IsoMax35Text SubmitterTransactionReferenceValue)
        {
            writer.WriteStartElement(null, "SubmitrTxRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SubmitterTransactionReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (EntitiesToBeReported is BICIdentification1 EntitiesToBeReportedValue)
        {
            writer.WriteStartElement(null, "NttiesToBeRptd", xmlNamespace );
            EntitiesToBeReportedValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Correspondent is BICIdentification1 CorrespondentValue)
        {
            writer.WriteStartElement(null, "Crspdt", xmlNamespace );
            CorrespondentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SubmittingBank is BICIdentification1 SubmittingBankValue)
        {
            writer.WriteStartElement(null, "SubmitgBk", xmlNamespace );
            SubmittingBankValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ObligorBank is BICIdentification1 ObligorBankValue)
        {
            writer.WriteStartElement(null, "OblgrBk", xmlNamespace );
            ObligorBankValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Buyer is PartyIdentification28 BuyerValue)
        {
            writer.WriteStartElement(null, "Buyr", xmlNamespace );
            BuyerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Seller is PartyIdentification28 SellerValue)
        {
            writer.WriteStartElement(null, "Sellr", xmlNamespace );
            SellerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BuyerCountry is CountryCode BuyerCountryValue)
        {
            writer.WriteStartElement(null, "BuyrCtry", xmlNamespace );
            writer.WriteValue(BuyerCountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SellerCountry is CountryCode SellerCountryValue)
        {
            writer.WriteStartElement(null, "SellrCtry", xmlNamespace );
            writer.WriteValue(SellerCountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CorrespondentCountry is CountryCode CorrespondentCountryValue)
        {
            writer.WriteStartElement(null, "CrspdtCtry", xmlNamespace );
            writer.WriteValue(CorrespondentCountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PendingRequestForAction is PendingActivity1 PendingRequestForActionValue)
        {
            writer.WriteStartElement(null, "PdgReqForActn", xmlNamespace );
            PendingRequestForActionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ReportSpecification4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
