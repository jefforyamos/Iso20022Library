﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DateCode.  ISO2002 ID# _nlQDOckdEee7W-rN1yqPMg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat49Choice;

/// <summary>
/// Specifies the type of date.
/// </summary>
public partial record DateCode : DateFormat49Choice_
     , IIsoXmlSerilizable<DateCode>
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
    public static new DateCode Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
