﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Product.  ISO2002 ID# _t5WBoKsvEeayv9XxdmMwKQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.StressItem1Choice;

/// <summary>
/// Identification and stress size of the major representative product.
/// </summary>
public partial record Product : StressItem1Choice_
     , IIsoXmlSerilizable<Product>
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the product.
    /// </summary>
    public required GenericIdentification168 Identification { get; init; } 
    /// <summary>
    /// Maximum move across the curve for the stressed product.
    /// </summary>
    public required StressSize1Choice_ MaximumStressSize { get; init; } 
    /// <summary>
    /// Minimum move across the curve for the stressed product.
    /// </summary>
    public required StressSize1Choice_ MinimumStressSize { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MaxStrssSz", xmlNamespace );
        MaximumStressSize.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MinStrssSz", xmlNamespace );
        MinimumStressSize.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new Product Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
