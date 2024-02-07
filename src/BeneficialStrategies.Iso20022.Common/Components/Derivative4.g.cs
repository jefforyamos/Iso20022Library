﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Derivative4.  ISO2002 ID# _PDS2gWp7EemmaZLSPtWX5A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Represents different types of derivative.
/// </summary>
public partial record Derivative4
     : IIsoXmlSerilizable<Derivative4>
{
    #nullable enable
    
    /// <summary>
    /// Parameters for contracts which obligate the buyer to receive and the seller to deliver in the future the assets specified at an agreed price.
    /// </summary>
    public Future4? Future { get; init; } 
    /// <summary>
    /// Contracts which grant to the holder either the privilege to purchase or the privilege to sell the assets specified at a predetermined price or formula at or within a time in the future.
    /// </summary>
    public Option15? Option { get; init; } 
    
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
        if (Future is Future4 FutureValue)
        {
            writer.WriteStartElement(null, "Futr", xmlNamespace );
            FutureValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Option is Option15 OptionValue)
        {
            writer.WriteStartElement(null, "Optn", xmlNamespace );
            OptionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Derivative4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
