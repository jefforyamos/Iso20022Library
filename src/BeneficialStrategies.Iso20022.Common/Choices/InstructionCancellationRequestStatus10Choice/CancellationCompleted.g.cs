﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CancellationCompleted.  ISO2002 ID# _ce-5rZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus10Choice;

/// <summary>
/// Provides status information related to a instruction cancellation request completed.
/// </summary>
public partial record CancellationCompleted : InstructionCancellationRequestStatus10Choice_
     , IIsoXmlSerilizable<CancellationCompleted>
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
    public static new CancellationCompleted Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
