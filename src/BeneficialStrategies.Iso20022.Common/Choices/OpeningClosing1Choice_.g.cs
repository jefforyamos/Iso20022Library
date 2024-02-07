﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OpeningClosing1Choice.  ISO2002 ID# _Qs45Ndp-Ed-ak6NoX_4Aeg_-775464350.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the opening closing information.
/// </summary>
[KnownType(typeof(OpeningClosing1Choice.Code))]
[KnownType(typeof(OpeningClosing1Choice.Proprietary))]
public abstract partial record OpeningClosing1Choice_ : IIsoXmlSerilizable<OpeningClosing1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static OpeningClosing1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => OpeningClosing1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => OpeningClosing1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid OpeningClosing1Choice choice.")
        };
    }
}
