﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Deletion1.  ISO2002 ID# _UtVP1tp-Ed-ak6NoX_4Aeg_1632709893.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deletion of the current element.
/// </summary>
public partial record Deletion1
     : IIsoXmlSerilizable<Deletion1>
{
    #nullable enable
    
    /// <summary>
    /// Content of the deleted element.
    /// </summary>
    public required IsoMax140Text DeletedValue { get; init; } 
    
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
        writer.WriteStartElement(null, "DeltdVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax140Text(DeletedValue)); // data type Max140Text System.String
        writer.WriteEndElement();
    }
    public static Deletion1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
