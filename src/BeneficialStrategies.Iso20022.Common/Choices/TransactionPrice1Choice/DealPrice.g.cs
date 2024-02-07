﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DealPrice.  ISO2002 ID# _RUrR9dp-Ed-ak6NoX_4Aeg_1070624770.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TransactionPrice1Choice;

/// <summary>
/// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
/// </summary>
public partial record DealPrice : TransactionPrice1Choice_
     , IIsoXmlSerilizable<DealPrice>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217. The decimal separator is a dot.|Note: A zero amount is considered a positive amount.
    /// </summary>
    public required IsoCurrencyAndAmount Value { get; init; } 
    
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
        writer.WriteStartElement(null, "DealPric", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoCurrencyAndAmount(Value)); // data type CurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static new DealPrice Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
