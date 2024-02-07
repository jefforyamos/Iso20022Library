﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StatementEntry.  ISO2002 ID# _X0Xj5WXpEeap-P22vGV91g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingTransaction3Choice;

/// <summary>
/// Reference details on the underlying statement cash entry.
/// </summary>
public partial record StatementEntry : UnderlyingTransaction3Choice_
     , IIsoXmlSerilizable<StatementEntry>
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original message.
    /// </summary>
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
    /// </summary>
    public IsoMax35Text? OriginalStatementIdentification { get; init; } 
    /// <summary>
    /// Original unique identification, as assigned by the account servicer, to unambiguously identify the original entry.
    /// </summary>
    public IsoMax35Text? OriginalEntryIdentification { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (OriginalGroupInformation is OriginalGroupInformation3 OriginalGroupInformationValue)
        {
            writer.WriteStartElement(null, "OrgnlGrpInf", xmlNamespace );
            OriginalGroupInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalStatementIdentification is IsoMax35Text OriginalStatementIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlStmtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalStatementIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalEntryIdentification is IsoMax35Text OriginalEntryIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlNtryId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalEntryIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static new StatementEntry Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
