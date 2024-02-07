﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Statement32.  ISO2002 ID# _QkZEgNp-Ed-ak6NoX_4Aeg_-430319811.
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
public partial record Statement32
     : IIsoXmlSerilizable<Statement32>
{
    #nullable enable
    
    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    public required IsoMax35Text StatementIdentification { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    public required Frequency1Code Frequency { get; init; } 
    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    
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
        writer.WriteStartElement(null, "StmtId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(StatementIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ActvtyInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ActivityIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Frqcy", xmlNamespace );
        writer.WriteValue(Frequency.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "StmtDtTm", xmlNamespace );
        StatementDateTime.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static Statement32 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
