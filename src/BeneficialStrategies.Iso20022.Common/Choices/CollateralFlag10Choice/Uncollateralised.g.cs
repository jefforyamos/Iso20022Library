﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Uncollateralised.  ISO2002 ID# _gI37UwAAEeqefbt-QjTNnA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CollateralFlag10Choice;

/// <summary>
/// Indication that security is not collateralised.
/// </summary>
public partial record Uncollateralised : CollateralFlag10Choice_
     , IIsoXmlSerilizable<Uncollateralised>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies that there is no reason available.
    /// </summary>
    public required NoReasonCode Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Uncollsd", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Uncollateralised Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
