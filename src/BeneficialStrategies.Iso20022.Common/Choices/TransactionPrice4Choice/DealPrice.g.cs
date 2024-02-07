﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DealPrice.  ISO2002 ID# _-XasI7TUEee_k7HqaUKERA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TransactionPrice4Choice;

/// <summary>
/// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
/// </summary>
public partial record DealPrice : TransactionPrice4Choice_
     , IIsoXmlSerilizable<DealPrice>
{
    #nullable enable
    
    /// <summary>
    /// Specification of the price type.
    /// </summary>
    public required YieldedOrValueType1Choice_ Type { get; init; } 
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    public required PriceRateOrAmount3Choice_ Value { get; init; } 
    
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
    public static new DealPrice Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
