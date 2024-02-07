﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SupportingDocumentEntry2.  ISO2002 ID# _l1j-wbGJEeuSTr8k0UEM8A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency control document entry supporting the contract registration.
/// </summary>
public partial record SupportingDocumentEntry2
     : IIsoXmlSerilizable<SupportingDocumentEntry2>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the supporting document entry.
    /// </summary>
    public required IsoMax35Text EntryIdentification { get; init; } 
    /// <summary>
    /// Identification of the original document for which the supporting documents are provided.
    /// </summary>
    public required DocumentIdentification22 OriginalDocument { get; init; } 
    /// <summary>
    /// Document type in a coded form.
    /// TBC: Data must support "_".
    /// </summary>
    public required IsoExact4AlphaNumericUnderscoreText DocumentType { get; init; } 
    /// <summary>
    /// Total amount of the supporting document entry.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalAmount { get; init; } 
    /// <summary>
    /// Total amount after shipment of the supporting document entry.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalAmountAfterShipment { get; init; } 
    /// <summary>
    /// Total amount of the supporting document entry in the currency of the contract.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalAmountInContractCurrency { get; init; } 
    /// <summary>
    /// Total amount after shipment of the supporting document entry in the currency of the contract.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalAmountAfterShipmentInContractCurrency { get; init; } 
    /// <summary>
    /// Conditions and attributes related to the shipment.
    /// </summary>
    public required ShipmentAttribute2 ShipmentAttributes { get; init; } 
    /// <summary>
    /// Identification of the document entry amendment.
    /// </summary>
    public DocumentEntryAmendment1? EntryAmendmentIdentification { get; init; } 
    /// <summary>
    /// Indication of contract obligations execution.
    /// </summary>
    public IsoMax35Text? MaturityData { get; init; } 
    /// <summary>
    /// Further details on the supporting document entry.
    /// </summary>
    public IsoMax500Text? AdditionalInformation { get; init; } 
    /// <summary>
    /// Documents provided as attachments to the supporting document entry.
    /// </summary>
    public DocumentGeneralInformation5? Attachment { get; init; } 
    
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
        writer.WriteStartElement(null, "NtryId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(EntryIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OrgnlDoc", xmlNamespace );
        OriginalDocument.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DocTp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoExact4AlphaNumericUnderscoreText(DocumentType)); // data type Exact4AlphaNumericUnderscoreText System.String
        writer.WriteEndElement();
        if (TotalAmount is IsoActiveCurrencyAndAmount TotalAmountValue)
        {
            writer.WriteStartElement(null, "TtlAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TotalAmountAfterShipment is IsoActiveCurrencyAndAmount TotalAmountAfterShipmentValue)
        {
            writer.WriteStartElement(null, "TtlAmtAftrShipmnt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalAmountAfterShipmentValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TotalAmountInContractCurrency is IsoActiveCurrencyAndAmount TotalAmountInContractCurrencyValue)
        {
            writer.WriteStartElement(null, "TtlAmtInCtrctCcy", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalAmountInContractCurrencyValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TotalAmountAfterShipmentInContractCurrency is IsoActiveCurrencyAndAmount TotalAmountAfterShipmentInContractCurrencyValue)
        {
            writer.WriteStartElement(null, "TtlAmtAftrShipmntInCtrctCcy", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalAmountAfterShipmentInContractCurrencyValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ShipmntAttrbts", xmlNamespace );
        ShipmentAttributes.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (EntryAmendmentIdentification is DocumentEntryAmendment1 EntryAmendmentIdentificationValue)
        {
            writer.WriteStartElement(null, "NtryAmdmntId", xmlNamespace );
            EntryAmendmentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MaturityData is IsoMax35Text MaturityDataValue)
        {
            writer.WriteStartElement(null, "MtrtyData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MaturityDataValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalInformation is IsoMax500Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax500Text(AdditionalInformationValue)); // data type Max500Text System.String
            writer.WriteEndElement();
        }
        if (Attachment is DocumentGeneralInformation5 AttachmentValue)
        {
            writer.WriteStartElement(null, "Attchmnt", xmlNamespace );
            AttachmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SupportingDocumentEntry2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
