﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Statement33.  ISO2002 ID# _mum-Af70EeCKvdA5_Kg7Aw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the statement.
/// </summary>
public partial record Statement33
     : IIsoXmlSerilizable<Statement33>
{
    #nullable enable
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    public Number3Choice_? ReportNumber { get; init; } 
    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    public IsoMax35Text? QueryReference { get; init; } 
    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    public IsoMax35Text? StatementIdentification { get; init; } 
    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    public required Frequency9Choice_ Frequency { get; init; } 
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    public required UpdateType2Choice_ UpdateType { get; init; } 
    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    public required StatementBasis3Choice_ StatementBasis { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the statement reports holdings at subsafekeeping account level.
    /// </summary>
    public required IsoYesNoIndicator SubAccountIndicator { get; init; } 
    
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
        if (ReportNumber is Number3Choice_ ReportNumberValue)
        {
            writer.WriteStartElement(null, "RptNb", xmlNamespace );
            ReportNumberValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (QueryReference is IsoMax35Text QueryReferenceValue)
        {
            writer.WriteStartElement(null, "QryRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(QueryReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (StatementIdentification is IsoMax35Text StatementIdentificationValue)
        {
            writer.WriteStartElement(null, "StmtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(StatementIdentificationValue)); // data type Max35Text System.String
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
        writer.WriteStartElement(null, "StmtBsis", xmlNamespace );
        StatementBasis.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ActvtyInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ActivityIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SubAcctInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(SubAccountIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
    }
    public static Statement33 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
