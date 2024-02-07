﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PendingModificationReason.  ISO2002 ID# _itAoT0AAEeCaq78Ig8ATcA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Reason6Choice;

/// <summary>
/// Specifies the reason why the modification request is pending.
/// </summary>
public partial record PendingModificationReason : Reason6Choice_
     , IIsoXmlSerilizable<PendingModificationReason>
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
    public static new PendingModificationReason Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
