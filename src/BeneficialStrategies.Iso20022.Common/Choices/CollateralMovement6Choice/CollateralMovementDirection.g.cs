﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralMovementDirection.  ISO2002 ID# _6gAQYSqREeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CollateralMovement6Choice;

/// <summary>
/// Provides the collateral movement direction that is a delivery and optionally a return.
/// </summary>
public partial record CollateralMovementDirection : CollateralMovement6Choice_
     , IIsoXmlSerilizable<CollateralMovementDirection>
{
    #nullable enable
    
    /// <summary>
    /// Provides the collateral movement direction that is a delivery only.
    /// </summary>
    public required Collateral55 Deliver { get; init; } 
    /// <summary>
    /// Provides the collateral movement direction that is a return only.
    /// </summary>
    public Collateral54? Return { get; init; } 
    
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
        writer.WriteStartElement(null, "Dlvr", xmlNamespace );
        Deliver.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Return is Collateral54 ReturnValue)
        {
            writer.WriteStartElement(null, "Rtr", xmlNamespace );
            ReturnValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new CollateralMovementDirection Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
