﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Balance.  ISO2002 ID# _lHIu4Tq5EeWQ1Y7f8kds2A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat6Choice;

/// <summary>
/// Provides information about balance related to a corporate action.
/// </summary>
public partial record Balance : BalanceFormat6Choice_
     , IIsoXmlSerilizable<Balance>
{
    #nullable enable
    
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    public required Quantity19Choice_ QuantityChoice { get; init; } 
    
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
        writer.WriteStartElement(null, "ShrtLngPos", xmlNamespace );
        writer.WriteValue(ShortLongPosition.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "QtyChc", xmlNamespace );
        QuantityChoice.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new Balance Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
