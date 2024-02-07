﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Quantity.  ISO2002 ID# _i1n9MSp6EeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.BalanceQuantity13Choice;

/// <summary>
/// Total quantity of financial instruments of the balance.
/// </summary>
public partial record Quantity : BalanceQuantity13Choice_
     , IIsoXmlSerilizable<Quantity>
{
    #nullable enable
    
    
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
    }
    public static new Quantity Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
