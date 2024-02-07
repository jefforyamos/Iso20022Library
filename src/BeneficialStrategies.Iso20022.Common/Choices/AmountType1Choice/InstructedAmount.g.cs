﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for InstructedAmount.  ISO2002 ID# _PrUuh9p-Ed-ak6NoX_4Aeg_-1289727793.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AmountType1Choice;

/// <summary>
/// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.||Usage: Currency of the amount is expressed in the currency (or one of the currencies) of the debtor's account or another currency, eg, pay 1000000 EUR (and debtor's account is is EUR) or pay 1000000 JPY (and debtor's account is in EUR).
/// </summary>
public partial record InstructedAmount : AmountType1Choice_
     , IIsoXmlSerilizable<InstructedAmount>
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
        writer.WriteStartElement(null, "InstdAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoCurrencyAndAmount(Value)); // data type CurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static new InstructedAmount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
