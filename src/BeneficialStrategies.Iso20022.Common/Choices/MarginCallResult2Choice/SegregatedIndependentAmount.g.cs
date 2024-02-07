﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SegregatedIndependentAmount.  ISO2002 ID# _9boCQqMPEeCojJW5vEuTEQ_-1606532938.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.MarginCallResult2Choice;

/// <summary>
/// Provides the summation of the call amounts for the segregated independent amount only.
/// </summary>
public partial record SegregatedIndependentAmount : MarginCallResult2Choice_
     , IIsoXmlSerilizable<SegregatedIndependentAmount>
{
    #nullable enable
    
    /// <summary>
    /// Amount payable by party B to party A.
    /// </summary>
    public IsoActiveCurrencyAndAmount? DueToPartyA { get; init; } 
    /// <summary>
    /// Amount payable by party A to party B.
    /// </summary>
    public IsoActiveCurrencyAndAmount? DueToPartyB { get; init; } 
    /// <summary>
    /// Provides additional information related to the collateral that may be requested.
    /// </summary>
    public IsoMax210Text? AdditionalInformation { get; init; } 
    
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
        if (DueToPartyA is IsoActiveCurrencyAndAmount DueToPartyAValue)
        {
            writer.WriteStartElement(null, "DueToPtyA", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(DueToPartyAValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (DueToPartyB is IsoActiveCurrencyAndAmount DueToPartyBValue)
        {
            writer.WriteStartElement(null, "DueToPtyB", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(DueToPartyBValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (AdditionalInformation is IsoMax210Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax210Text(AdditionalInformationValue)); // data type Max210Text System.String
            writer.WriteEndElement();
        }
    }
    public static new SegregatedIndependentAmount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
