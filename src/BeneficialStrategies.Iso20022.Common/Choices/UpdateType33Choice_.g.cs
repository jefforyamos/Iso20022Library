﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UpdateType33Choice.  ISO2002 ID# _lg1sUQleEeuQ1MenzX1l-g.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the type of update requested. That is addition, deletion or modification.
/// </summary>
[KnownType(typeof(UpdateType33Choice.Addition))]
[KnownType(typeof(UpdateType33Choice.Deletion))]
[KnownType(typeof(UpdateType33Choice.Modification))]
public abstract partial record UpdateType33Choice_ : IIsoXmlSerilizable<UpdateType33Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static UpdateType33Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Addtn" => UpdateType33Choice.Addition.Deserialize(elementWithPayload),
             "Deltn" => UpdateType33Choice.Deletion.Deserialize(elementWithPayload),
             "Mod" => UpdateType33Choice.Modification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid UpdateType33Choice choice.")
        };
    }
}
