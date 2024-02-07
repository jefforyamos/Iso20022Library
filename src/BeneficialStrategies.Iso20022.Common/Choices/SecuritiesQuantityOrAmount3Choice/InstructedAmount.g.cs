﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for InstructedAmount.  ISO2002 ID# _nkqqY9NPEee-r40DhxXRmg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesQuantityOrAmount3Choice;

/// <summary>
/// Cash amount to be instructed.
/// </summary>
public partial record InstructedAmount : SecuritiesQuantityOrAmount3Choice_
     , IIsoXmlSerilizable<InstructedAmount>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// A number of monetary units specified in an active currency where the unit of currency is explicit and compliant with ISO 4217.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Value { get; init; } 
    
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
        writer.WriteStartElement(null, "InstdAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(Value)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static new InstructedAmount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
