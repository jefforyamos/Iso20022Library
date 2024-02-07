﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Indicative.  ISO2002 ID# _SKL8D83yEee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PriceType5Choice;

/// <summary>
/// Estimated price, for valuation purposes.
/// </summary>
public partial record Indicative : PriceType5Choice_
     , IIsoXmlSerilizable<Indicative>
{
    #nullable enable
    
    /// <summary>
    /// Specification of the price type.
    /// </summary>
    public required YieldedOrValueType1Choice_ Type { get; init; } 
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    public required PriceRateOrAmount1Choice_ Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        Type.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Val", xmlNamespace );
        Value.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new Indicative Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
