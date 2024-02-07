﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Equal.  ISO2002 ID# _7_LCoaMgEeCJ6YNENx4h-w_-73974136.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PercentageRange1Choice;

/// <summary>
/// Exact percentage rate must match to be considered valid.
/// </summary>
public partial record Equal : PercentageRange1Choice_
     , IIsoXmlSerilizable<Equal>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Rate expressed as a percentage, that is, in hundredths, for example, 0.7 is 7/10 of a percent, and 7.0 is 7%.
    /// </summary>
    public required IsoPercentageRate Value { get; init; } 
    
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
        writer.WriteStartElement(null, "EQ", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoPercentageRate(Value)); // data type PercentageRate System.Decimal
        writer.WriteEndElement();
    }
    public static new Equal Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
