﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GlobalNote2Choice.  ISO2002 ID# _TiBdgeLaEeWFtOV72FbX9w.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for global note.
/// </summary>
[KnownType(typeof(GlobalNote2Choice.Code))]
[KnownType(typeof(GlobalNote2Choice.Proprietary))]
public abstract partial record GlobalNote2Choice_ : IIsoXmlSerilizable<GlobalNote2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static GlobalNote2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => GlobalNote2Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => GlobalNote2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid GlobalNote2Choice choice.")
        };
    }
}
