﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CurrencyControlRecordStatus2.  ISO2002 ID# _9rC4vW48EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of each individual currency control record.
/// </summary>
public partial record CurrencyControlRecordStatus2
     : IIsoXmlSerilizable<CurrencyControlRecordStatus2>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of each entry/record within the package of transactions.
    /// </summary>
    public required IsoMax35Text RecordIdentification { get; init; } 
    /// <summary>
    /// Defines the status of the reported record.
    /// </summary>
    public required StatisticalReportingStatus1Code Status { get; init; } 
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    public ValidationStatusReason2? StatusReason { get; init; } 
    /// <summary>
    /// Provides the date and time when the status was issued.
    /// </summary>
    public IsoISODateTime? StatusDateTime { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the document.
    /// </summary>
    public DocumentIdentification28? DocumentIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "RcrdId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(RecordIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Sts", xmlNamespace );
        writer.WriteValue(Status.ToString()); // Enum value
        writer.WriteEndElement();
        if (StatusReason is ValidationStatusReason2 StatusReasonValue)
        {
            writer.WriteStartElement(null, "StsRsn", xmlNamespace );
            StatusReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StatusDateTime is IsoISODateTime StatusDateTimeValue)
        {
            writer.WriteStartElement(null, "StsDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(StatusDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (DocumentIdentification is DocumentIdentification28 DocumentIdentificationValue)
        {
            writer.WriteStartElement(null, "DocId", xmlNamespace );
            DocumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CurrencyControlRecordStatus2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
