﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReconciliationList1.  ISO2002 ID# _OTgzMTk5-AOSNFX-8224490.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a list of reconciliation information concerning financial items.
/// </summary>
public partial record ReconciliationList1
     : IIsoXmlSerilizable<ReconciliationList1>
{
    #nullable enable
    
    /// <summary>
    /// Date of creation of this document.
    /// </summary>
    public required IsoISODate Date { get; init; } 
    /// <summary>
    /// Reference to related documents for example to original assignment in a status response or retry.
    /// </summary>
    public QualifiedDocumentInformation1? RelatedDocument { get; init; } 
    /// <summary>
    /// Party to be advised.
    /// </summary>
    public required QualifiedPartyIdentification1 Recipient { get; init; } 
    /// <summary>
    /// Informing party.
    /// </summary>
    public required QualifiedPartyIdentification1 Advisor { get; init; } 
    /// <summary>
    /// Identification parameters.
    /// </summary>
    public required FinancialItemParameters1 Parameters { get; init; } 
    /// <summary>
    /// Reference to a payment instruction.
    /// </summary>
    public required PaymentIdentification1 PaymentReference { get; init; } 
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    public required PaymentMeans1 PaymentMeans { get; init; } 
    /// <summary>
    /// Effective date of payment.
    /// </summary>
    public required IsoISODate PaymentDate { get; init; } 
    /// <summary>
    /// Terms of the payment.
    /// </summary>
    public required PaymentTerms6 PaymentTerms { get; init; } 
    /// <summary>
    /// Amount of the referenced payment.
    /// </summary>
    public required IsoCurrencyAndAmount PaymentAmount { get; init; } 
    /// <summary>
    /// Financial item impacted by the payment.
    /// </summary>
    public FinancialItem1? Item { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _OTgzNDI5-AOSNFX-8224504
    /// <summary>
    /// Number of individual items contained in the list.
    /// </summary>
    public required IsoMax15NumericText ItemCount { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the list, irrespective of currencies.
    /// </summary>
    public IsoDecimalNumber? ControlSum { get; init; } 
    /// <summary>
    /// Associated free form document.
    /// </summary>
    public QualifiedDocumentInformation1? AssociatedDocument { get; init; } 
    /// <summary>
    /// Additional proprietary formal information concerning the list.
    /// </summary>
    public IsoMax2000Text? AdditionalInformation { get; init; } 
    /// <summary>
    /// Validation status of the list.
    /// </summary>
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "Dt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(Date)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (RelatedDocument is QualifiedDocumentInformation1 RelatedDocumentValue)
        {
            writer.WriteStartElement(null, "RltdDoc", xmlNamespace );
            RelatedDocumentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Rcpt", xmlNamespace );
        Recipient.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Advsr", xmlNamespace );
        Advisor.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Params", xmlNamespace );
        Parameters.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PmtRef", xmlNamespace );
        PaymentReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PmtMeans", xmlNamespace );
        PaymentMeans.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PmtDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(PaymentDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PmtTerms", xmlNamespace );
        PaymentTerms.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PmtAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoCurrencyAndAmount(PaymentAmount)); // data type CurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        // Not sure how to serialize Item, multiplicity Unknown
        writer.WriteStartElement(null, "ItmCnt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax15NumericText(ItemCount)); // data type Max15NumericText System.String
        writer.WriteEndElement();
        if (ControlSum is IsoDecimalNumber ControlSumValue)
        {
            writer.WriteStartElement(null, "CtrlSum", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(ControlSumValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (AssociatedDocument is QualifiedDocumentInformation1 AssociatedDocumentValue)
        {
            writer.WriteStartElement(null, "AssoctdDoc", xmlNamespace );
            AssociatedDocumentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalInformation is IsoMax2000Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax2000Text(AdditionalInformationValue)); // data type Max2000Text System.String
            writer.WriteEndElement();
        }
        if (ValidationStatusInformation is ValidationStatusInformation1 ValidationStatusInformationValue)
        {
            writer.WriteStartElement(null, "VldtnStsInf", xmlNamespace );
            ValidationStatusInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ReconciliationList1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
