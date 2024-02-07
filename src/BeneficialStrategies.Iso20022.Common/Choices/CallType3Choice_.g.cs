﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CallType3Choice.  ISO2002 ID# _fBEo0eLcEeWFtOV72FbX9w.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for call type.
/// </summary>
[KnownType(typeof(CallType3Choice.Code))]
[KnownType(typeof(CallType3Choice.Proprietary))]
public abstract partial record CallType3Choice_ : IIsoXmlSerilizable<CallType3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CallType3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CallType3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => CallType3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CallType3Choice choice.")
        };
    }
}
