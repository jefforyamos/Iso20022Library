﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TEFRARules3Choice.  ISO2002 ID# _ighyQeLcEeWFtOV72FbX9w.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for TEFRA rules.
/// </summary>
[KnownType(typeof(TEFRARules3Choice.Code))]
[KnownType(typeof(TEFRARules3Choice.Proprietary))]
public abstract partial record TEFRARules3Choice_ : IIsoXmlSerilizable<TEFRARules3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static TEFRARules3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => TEFRARules3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => TEFRARules3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid TEFRARules3Choice choice.")
        };
    }
}
