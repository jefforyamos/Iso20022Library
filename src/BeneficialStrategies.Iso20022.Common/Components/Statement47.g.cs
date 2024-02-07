﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Statement47.  ISO2002 ID# _wW8KkUKNEeW5mJpUa0D_fg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General characteristics related to a statement which reports information.
/// </summary>
public partial record Statement47
     : IIsoXmlSerilizable<Statement47>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the statement contains missing instructions only or all instructions.
    /// </summary>
    public required CorporateActionStatementType1Code StatementType { get; init; } 
    /// <summary>
    /// Indicates whether the statement report on account holdings for corporate action events is for single account/multiple events or multiple accounts/single event.
    /// </summary>
    public required CorporateActionStatementReportingType1Code ReportingType { get; init; } 
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    public required IsoMax35Text StatementIdentification { get; init; } 
    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    public IsoMax5NumericText? ReportNumber { get; init; } 
    /// <summary>
    /// Date of the statement.
    /// </summary>
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    public required Frequency25Choice_ Frequency { get; init; } 
    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    public required UpdateType15Choice_ UpdateType { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Period during which identification deadline has been set.
    /// </summary>
    public DateOrDateTimePeriodChoice_? NotificationDeadlinePeriod { get; init; } 
    
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
        writer.WriteStartElement(null, "StmtTp", xmlNamespace );
        writer.WriteValue(StatementType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RptgTp", xmlNamespace );
        writer.WriteValue(ReportingType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "StmtId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(StatementIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (ReportNumber is IsoMax5NumericText ReportNumberValue)
        {
            writer.WriteStartElement(null, "RptNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax5NumericText(ReportNumberValue)); // data type Max5NumericText System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "StmtDtTm", xmlNamespace );
        StatementDateTime.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Frqcy", xmlNamespace );
        Frequency.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "UpdTp", xmlNamespace );
        UpdateType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ActvtyInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ActivityIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (NotificationDeadlinePeriod is DateOrDateTimePeriodChoice_ NotificationDeadlinePeriodValue)
        {
            writer.WriteStartElement(null, "NtfctnDdlnPrd", xmlNamespace );
            NotificationDeadlinePeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Statement47 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
