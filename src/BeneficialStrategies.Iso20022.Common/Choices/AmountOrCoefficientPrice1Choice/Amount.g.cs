﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _jBdh8O5NEeCisYr99QEiWA_185435194.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AmountOrCoefficientPrice1Choice;

/// <summary>
/// Provides details of the price when expressed with an amount.
/// </summary>
public partial record Amount : AmountOrCoefficientPrice1Choice_
     , IIsoXmlSerilizable<Amount>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Number of monetary units specified in a currency where the unit of currency is implied by the context and compliant with ISO 4217. The decimal separator is a dot.|Note: a zero amount is considered a positive amount.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(Value)); // data type ImpliedCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static new Amount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
