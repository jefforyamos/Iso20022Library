﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvoiceTaxReportTransactionStatus1.  ISO2002 ID# _8pkzYU53Eeaine-lsNAGsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of each individual invoice tax report transaction.
/// </summary>
public partial record InvoiceTaxReportTransactionStatus1
     : IIsoXmlSerilizable<InvoiceTaxReportTransactionStatus1>
{
    #nullable enable
    
    /// <summary>
    /// Report identification, for example invoice number or report number from point of sales system.
    /// </summary>
    public required IsoMax35Text TaxReportIdentification { get; init; } 
    /// <summary>
    /// Defines status of the reported transaction.
    /// </summary>
    public required TaxReportingStatus2Code Status { get; init; } 
    /// <summary>
    /// Provides the details of the rule which could not be validated.
    /// </summary>
    public GenericValidationRuleIdentification1? ValidationRule { get; init; } 
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
        writer.WriteStartElement(null, "TaxRptId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(TaxReportIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Sts", xmlNamespace );
        writer.WriteValue(Status.ToString()); // Enum value
        writer.WriteEndElement();
        if (ValidationRule is GenericValidationRuleIdentification1 ValidationRuleValue)
        {
            writer.WriteStartElement(null, "VldtnRule", xmlNamespace );
            ValidationRuleValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static InvoiceTaxReportTransactionStatus1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
