﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvoiceHeader3.  ISO2002 ID# _xV7LweWoEeevU7McUP3D1w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Collection of data for that is exchanged between two or more parties in written, printed or electronic form.
/// </summary>
public partial record InvoiceHeader3
     : IIsoXmlSerilizable<InvoiceHeader3>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of this invoice document.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    public required ExternalDocumentType1Code TypeCode { get; init; } 
    /// <summary>
    /// Name of invoice document or transaction, for example, tax invoice.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Issue date of the document.
    /// </summary>
    public required IsoISODateTime IssueDateTime { get; init; } 
    /// <summary>
    /// Party that issued this invoice document.
    /// </summary>
    public TradeParty4? Issuer { get; init; } 
    /// <summary>
    /// Unique identifier for a language used in this invoice document.
    /// </summary>
    public LanguageCode? LanguageCode { get; init; } 
    /// <summary>
    /// Indicator that the document is a copy of the|original document.
    /// </summary>
    public IsoYesNoIndicator? CopyIndicator { get; init; } 
    /// <summary>
    /// Specifies the function of the document.
    /// </summary>
    public ExternalDocumentPurpose1Code? DocumentPurpose { get; init; } 
    /// <summary>
    /// Note included in this invoice document.
    /// </summary>
    public AdditionalInformation6? IncludedNote { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TpCd", xmlNamespace );
        writer.WriteValue(TypeCode.ToString()); // Enum value
        writer.WriteEndElement();
        if (Name is IsoMax35Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(NameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "IsseDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(IssueDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (Issuer is TradeParty4 IssuerValue)
        {
            writer.WriteStartElement(null, "Issr", xmlNamespace );
            IssuerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LanguageCode is LanguageCode LanguageCodeValue)
        {
            writer.WriteStartElement(null, "LangCd", xmlNamespace );
            writer.WriteValue(LanguageCodeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CopyIndicator is IsoYesNoIndicator CopyIndicatorValue)
        {
            writer.WriteStartElement(null, "CpyInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CopyIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (DocumentPurpose is ExternalDocumentPurpose1Code DocumentPurposeValue)
        {
            writer.WriteStartElement(null, "DocPurp", xmlNamespace );
            writer.WriteValue(DocumentPurposeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (IncludedNote is AdditionalInformation6 IncludedNoteValue)
        {
            writer.WriteStartElement(null, "InclNote", xmlNamespace );
            IncludedNoteValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static InvoiceHeader3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
