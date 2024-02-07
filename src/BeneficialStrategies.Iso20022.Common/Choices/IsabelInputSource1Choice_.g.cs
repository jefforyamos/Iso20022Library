﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for IsabelInputSource1Choice.  ISO2002 ID# _OGcMMMmMEeWAGphE2LvqeA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of input source for the generation of the file.
/// </summary>
[KnownType(typeof(IsabelInputSource1Choice.Code))]
[KnownType(typeof(IsabelInputSource1Choice.Proprietary))]
public abstract partial record IsabelInputSource1Choice_ : IIsoXmlSerilizable<IsabelInputSource1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static IsabelInputSource1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => IsabelInputSource1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => IsabelInputSource1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid IsabelInputSource1Choice choice.")
        };
    }
}
