﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Identification.  ISO2002 ID# _Tq_ecE9kEeSn2-3swbRbzg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PledgeeFormat1Choice;

/// <summary>
/// Identification of the entity to which the financial instruments are pledged expressed as a code and a narrative description.
/// </summary>
public partial record Identification : PledgeeFormat1Choice_
     , IIsoXmlSerilizable<Identification>
{
    #nullable enable
    
    public IsoMax35Text? Value { get; init; } 
    /// <summary>
    /// Entity to which the financial instruments are pledged expressed as a code.
    /// </summary>
    public required PledgeeType1Code PledgeeType { get; init; } 
    
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
        if (Value is IsoMax35Text ValueValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ValueValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PldgeeTp", xmlNamespace );
        writer.WriteValue(PledgeeType.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Identification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
