﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DeniedReason.  ISO2002 ID# _ux5oK1hpEeS8HfHHd4stCA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Reason14Choice;

/// <summary>
/// Specifies the reason why the request was denied.
/// </summary>
public partial record DeniedReason : Reason14Choice_
     , IIsoXmlSerilizable<DeniedReason>
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
    public static new DeniedReason Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
