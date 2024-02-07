﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Direction2.  ISO2002 ID# _9zN68C0WEe2ZUuvBHegNNg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements indicating the direction of the derivative transaction.
/// </summary>
public partial record Direction2
     : IIsoXmlSerilizable<Direction2>
{
    #nullable enable
    
    /// <summary>
    /// Identifies whether the reporting counterparty is the payer (Taker) or the receiver (Maker) of the first leg as determined at the time of transaction.
    /// </summary>
    public required OptionParty3Code DirectionOfTheFirstLeg { get; init; } 
    /// <summary>
    /// Identifies whether the reporting counterparty is the payer (Taker) or the receiver (Maker) of the second leg as determined at the time of transaction.
    /// </summary>
    public OptionParty3Code? DirectionOfTheSecondLeg { get; init; } 
    
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
        writer.WriteStartElement(null, "DrctnOfTheFrstLeg", xmlNamespace );
        writer.WriteValue(DirectionOfTheFirstLeg.ToString()); // Enum value
        writer.WriteEndElement();
        if (DirectionOfTheSecondLeg is OptionParty3Code DirectionOfTheSecondLegValue)
        {
            writer.WriteStartElement(null, "DrctnOfTheScndLeg", xmlNamespace );
            writer.WriteValue(DirectionOfTheSecondLegValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static Direction2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
