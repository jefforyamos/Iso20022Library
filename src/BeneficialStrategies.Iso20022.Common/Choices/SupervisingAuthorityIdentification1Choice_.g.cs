﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SupervisingAuthorityIdentification1Choice.  ISO2002 ID# _4ZQrMPH-Eeaz_YGUGLjP6A.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the identification of the relevant supervising authority.
/// </summary>
[KnownType(typeof(SupervisingAuthorityIdentification1Choice.ProprietaryIdentification))]
[KnownType(typeof(SupervisingAuthorityIdentification1Choice.FullName))]
public abstract partial record SupervisingAuthorityIdentification1Choice_ : IIsoXmlSerilizable<SupervisingAuthorityIdentification1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SupervisingAuthorityIdentification1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PrtryId" => SupervisingAuthorityIdentification1Choice.ProprietaryIdentification.Deserialize(elementWithPayload),
             "FullNm" => SupervisingAuthorityIdentification1Choice.FullName.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SupervisingAuthorityIdentification1Choice choice.")
        };
    }
}
