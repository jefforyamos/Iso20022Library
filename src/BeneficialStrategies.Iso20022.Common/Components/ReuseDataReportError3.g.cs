﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReuseDataReportError3.  ISO2002 ID# _4QCyIa4bEemB_csI4yyKLA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates a cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to reporting requirements but was reported to a trade repository by mistake.
/// </summary>
public partial record ReuseDataReportError3
     : IIsoXmlSerilizable<ReuseDataReportError3>
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Date and time of submission of the report to the entitled receiver.
    /// </summary>
    public required IsoISODateTime ReportingDateTime { get; init; } 
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    public required CounterpartyData46 CounterpartyData { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
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
        if (TechnicalRecordIdentification is IsoMax140Text TechnicalRecordIdentificationValue)
        {
            writer.WriteStartElement(null, "TechRcrdId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(TechnicalRecordIdentificationValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RptgDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(ReportingDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CtrPtyData", xmlNamespace );
        CounterpartyData.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ReuseDataReportError3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
