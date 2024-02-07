﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ValueDefinedAttributes.  ISO2002 ID# __F7tMePJEea7_eMQH225xA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.DefinedAttributes1Choice;

/// <summary>
/// Value defined attributes for derivatives where the terms of the contract define the value of payable per unit of a move in some published index. This includes the floating leg of interest rate swaps which implicitly are payments proportional to the change in the index.
/// </summary>
public partial record ValueDefinedAttributes : DefinedAttributes1Choice_
     , IIsoXmlSerilizable<ValueDefinedAttributes>
{
    #nullable enable
    
    /// <summary>
    /// Reference notional amount of the contract.
    /// </summary>
    public IsoActiveCurrencyAndAmount? Notional { get; init; } 
    /// <summary>
    /// Value of unit move in index if fixed in contract terms, and currency of payments relating to changes in the amount of the underlying.
    /// </summary>
    public required IsoActiveCurrencyAndAmount UnitValue { get; init; } 
    /// <summary>
    /// Unique identifier for underlying index on which final settlement price or periodic payments are calculated.
    /// </summary>
    public required GenericIdentification168 IndexIdentification { get; init; } 
    /// <summary>
    /// Unit index, typically ‘Points’, or for interest rate and CDS products, ‘Bps’.
    /// </summary>
    public required IsoMax35Text IndexUnit { get; init; } 
    /// <summary>
    /// Day count convention for interest payments. Interest rate products only.
    /// </summary>
    public InterestComputationMethod2Code? InterestRateTerms { get; init; } 
    
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
        if (Notional is IsoActiveCurrencyAndAmount NotionalValue)
        {
            writer.WriteStartElement(null, "Ntnl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(NotionalValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "UnitVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(UnitValue)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IndxId", xmlNamespace );
        IndexIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IndxUnit", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(IndexUnit)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (InterestRateTerms is InterestComputationMethod2Code InterestRateTermsValue)
        {
            writer.WriteStartElement(null, "IntrstRateTerms", xmlNamespace );
            writer.WriteValue(InterestRateTermsValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static new ValueDefinedAttributes Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
