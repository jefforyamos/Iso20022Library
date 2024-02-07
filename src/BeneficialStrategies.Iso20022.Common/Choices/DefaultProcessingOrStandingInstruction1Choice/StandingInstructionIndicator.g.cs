﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StandingInstructionIndicator.  ISO2002 ID# _Q0VlBNp-Ed-ak6NoX_4Aeg_-857961387.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.DefaultProcessingOrStandingInstruction1Choice;

/// <summary>
/// Indicates whether an account owner has placed a standing order to select this corporate action option.
/// </summary>
public partial record StandingInstructionIndicator : DefaultProcessingOrStandingInstruction1Choice_
     , IIsoXmlSerilizable<StandingInstructionIndicator>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Indicates a "Yes" or "No" type of answer for an element.
    /// </summary>
    public required IsoYesNoIndicator Value { get; init; } 
    
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
        writer.WriteStartElement(null, "StgInstrInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(Value)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
    }
    public static new StandingInstructionIndicator Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
