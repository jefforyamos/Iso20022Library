﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InitialPhysicalForm4Choice.  ISO2002 ID# _UjitceLxEeWOD7aAy2fAcA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for initial physical form.
/// </summary>
[KnownType(typeof(InitialPhysicalForm4Choice.Code))]
[KnownType(typeof(InitialPhysicalForm4Choice.Proprietary))]
public abstract partial record InitialPhysicalForm4Choice_ : IIsoXmlSerilizable<InitialPhysicalForm4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InitialPhysicalForm4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => InitialPhysicalForm4Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => InitialPhysicalForm4Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InitialPhysicalForm4Choice choice.")
        };
    }
}
