﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CancellationPending.  ISO2002 ID# _A4HJM9okEeC60axPepSq7g_754049523.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CancellationProcessingStatus6Choice;

/// <summary>
/// Trade is in cancelation pending.
/// </summary>
public partial record CancellationPending : CancellationProcessingStatus6Choice_
     , IIsoXmlSerilizable<CancellationPending>
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
    public static new CancellationPending Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
