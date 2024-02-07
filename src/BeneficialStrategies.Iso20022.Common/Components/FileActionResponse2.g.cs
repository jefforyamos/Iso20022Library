﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FileActionResponse2.  ISO2002 ID# _gZVqQYKwEeu4svNQ5N-l6w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the file action.
/// </summary>
public partial record FileActionResponse2
     : IIsoXmlSerilizable<FileActionResponse2>
{
    #nullable enable
    
    /// <summary>
    /// Environment of the file action transaction.
    /// </summary>
    public required Environment22 Environment { get; init; } 
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    public Context17? Context { get; init; } 
    /// <summary>
    /// File action transaction details.
    /// </summary>
    public required Transaction158 Transaction { get; init; } 
    /// <summary>
    /// Results of the file action processing.
    /// </summary>
    public required ResultData9 ProcessingResult { get; init; } 
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    public ProtectedData1? ProtectedData { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
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
        writer.WriteStartElement(null, "Envt", xmlNamespace );
        Environment.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Context is Context17 ContextValue)
        {
            writer.WriteStartElement(null, "Cntxt", xmlNamespace );
            ContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Tx", xmlNamespace );
        Transaction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PrcgRslt", xmlNamespace );
        ProcessingResult.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ProtectedData is ProtectedData1 ProtectedDataValue)
        {
            writer.WriteStartElement(null, "PrtctdData", xmlNamespace );
            ProtectedDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FileActionResponse2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
