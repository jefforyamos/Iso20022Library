﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _V5oD09p-Ed-ak6NoX_4Aeg_434826094.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ReturnReason4Choice;

/// <summary>
/// Reason for the return not catered for by the available codes.
/// </summary>
public partial record Proprietary : ReturnReason4Choice_
     , IIsoXmlSerilizable<Proprietary>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// EPC Technical validation subset restricted RR01 or SL01 code.
    /// </summary>
    public required IsoRestrictedRR01SL01CodeText Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Prtry", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedRR01SL01CodeText(Value)); // data type RestrictedRR01SL01CodeText System.String
        writer.WriteEndElement();
    }
    public static new Proprietary Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
