﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Basis.  ISO2002 ID# _RfQKRtp-Ed-ak6NoX_4Aeg_-1739500184.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TaxCalculationBasisType1Choice;

/// <summary>
/// Basis used to determine the capital gain or loss, eg, the purchase price.
/// </summary>
public partial record Basis : TaxCalculationBasisType1Choice_
     , IIsoXmlSerilizable<Basis>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the tax basis.
    /// </summary>
    public required TaxationBasis2Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Bsis", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Basis Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
