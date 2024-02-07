﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification.  ISO2002 ID# _NXpRUAzYEeuUZuaHWzkTew.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.References69Choice;

/// <summary>
/// Unambiguous identification of the triparty collateral transaction instruction status advice to be cancelled.
/// </summary>
public partial record TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification : References69Choice_
     , IIsoXmlSerilizable<TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    public required IsoMax35Text Value { get; init; } 
    
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
        writer.WriteStartElement(null, "TrptyCollTxInstrPrcgStsAdvcId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Value)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static new TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
