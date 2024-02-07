﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PerSecurity.  ISO2002 ID# _vMYu8fNBEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.IncentivePremiumType2Choice;

/// <summary>
/// Number of securities giving right to a premium.
/// </summary>
public partial record PerSecurity : IncentivePremiumType2Choice_
     , IIsoXmlSerilizable<PerSecurity>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Number of objects represented as an integer.
    /// </summary>
    public required IsoNumber Value { get; init; } 
    
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
        writer.WriteStartElement(null, "PerScty", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoNumber(Value)); // data type Number System.UInt64
        writer.WriteEndElement();
    }
    public static new PerSecurity Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
