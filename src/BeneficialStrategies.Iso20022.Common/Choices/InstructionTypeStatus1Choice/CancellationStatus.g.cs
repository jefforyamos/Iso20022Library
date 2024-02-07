﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CancellationStatus.  ISO2002 ID# _RCfVwdp-Ed-ak6NoX_4Aeg_545780069.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InstructionTypeStatus1Choice;

/// <summary>
/// Status applying to the instruction cancellation request received. The instruction cancellation is identified by the InstructionCancellationIdentification.
/// </summary>
public partial record CancellationStatus : InstructionTypeStatus1Choice_
     , IIsoXmlSerilizable<CancellationStatus>
{
    #nullable enable
    
    
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
    }
    public static new CancellationStatus Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
