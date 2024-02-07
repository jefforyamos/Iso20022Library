﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProductCharacteristics3.  ISO2002 ID# _CYo1scNUEeWGDrnsYu2p6g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Product characteristic applicable to this trade product.
/// </summary>
public partial record ProductCharacteristics3
     : IIsoXmlSerilizable<ProductCharacteristics3>
{
    #nullable enable
    
    /// <summary>
    /// Characteristics of the product.
    /// </summary>
    public ProductCharacteristics1Choice_? Characteristic { get; init; } 
    /// <summary>
    /// Measurement value for this product characteristic.
    /// </summary>
    public Quantity10? ValueMeasure { get; init; } 
    
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
        if (Characteristic is ProductCharacteristics1Choice_ CharacteristicValue)
        {
            writer.WriteStartElement(null, "Chrtc", xmlNamespace );
            CharacteristicValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ValueMeasure is Quantity10 ValueMeasureValue)
        {
            writer.WriteStartElement(null, "ValMeasr", xmlNamespace );
            ValueMeasureValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ProductCharacteristics3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
