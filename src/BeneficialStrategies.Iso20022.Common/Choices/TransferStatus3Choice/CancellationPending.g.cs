﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CancellationPending.  ISO2002 ID# _aeWNYVNUEeijdq8ilaxyOA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus3Choice;

/// <summary>
/// Status of the transfer is cancellation pending.
/// </summary>
public partial record CancellationPending : TransferStatus3Choice_
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
