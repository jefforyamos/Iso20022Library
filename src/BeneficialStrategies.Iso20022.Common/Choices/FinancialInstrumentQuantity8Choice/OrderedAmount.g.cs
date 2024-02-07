﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OrderedAmount.  ISO2002 ID# _Rg5JCNp-Ed-ak6NoX_4Aeg_1589726483.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity8Choice;

/// <summary>
/// Amount of money used to derive the quantity of investment fund units to be sold.
/// </summary>
public partial record OrderedAmount : FinancialInstrumentQuantity8Choice_
     , IIsoXmlSerilizable<OrderedAmount>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// A number of monetary units specified in an active or a historic currency where the unit of currency is explicit and compliant with ISO 4217.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Value { get; init; } 
    
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
        writer.WriteStartElement(null, "OrdrdAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(Value)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static new OrderedAmount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
