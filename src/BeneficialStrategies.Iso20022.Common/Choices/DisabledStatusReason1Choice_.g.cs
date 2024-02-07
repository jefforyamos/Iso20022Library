﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DisabledStatusReason1Choice.  ISO2002 ID# _RfDOYUzAEeafiMTDrtSnyw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for a disabled status reason.
/// </summary>
[KnownType(typeof(DisabledStatusReason1Choice.NoSpecifiedReason))]
[KnownType(typeof(DisabledStatusReason1Choice.Reason))]
public abstract partial record DisabledStatusReason1Choice_ : IIsoXmlSerilizable<DisabledStatusReason1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static DisabledStatusReason1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => DisabledStatusReason1Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => DisabledStatusReason1Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid DisabledStatusReason1Choice choice.")
        };
    }
}
