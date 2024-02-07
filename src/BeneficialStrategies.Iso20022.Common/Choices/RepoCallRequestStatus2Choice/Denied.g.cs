﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Denied.  ISO2002 ID# _UWYvddp-Ed-ak6NoX_4Aeg_-1727603711.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.RepoCallRequestStatus2Choice;

/// <summary>
/// Instruction/Request will not be executed.
/// </summary>
public partial record Denied : RepoCallRequestStatus2Choice_
     , IIsoXmlSerilizable<Denied>
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
    public static new Denied Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
