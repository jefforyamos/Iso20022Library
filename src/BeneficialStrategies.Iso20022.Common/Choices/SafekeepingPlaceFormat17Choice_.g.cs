﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SafekeepingPlaceFormat17Choice.  ISO2002 ID# _cj_8gZKQEeWHWpTQn1FFVg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between formats for the place of safekeeping.
/// </summary>
[KnownType(typeof(SafekeepingPlaceFormat17Choice.Identification))]
[KnownType(typeof(SafekeepingPlaceFormat17Choice.Country))]
[KnownType(typeof(SafekeepingPlaceFormat17Choice.TypeAndIdentification))]
[KnownType(typeof(SafekeepingPlaceFormat17Choice.Proprietary))]
public abstract partial record SafekeepingPlaceFormat17Choice_ : IIsoXmlSerilizable<SafekeepingPlaceFormat17Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SafekeepingPlaceFormat17Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Id" => SafekeepingPlaceFormat17Choice.Identification.Deserialize(elementWithPayload),
             "Ctry" => SafekeepingPlaceFormat17Choice.Country.Deserialize(elementWithPayload),
             "TpAndId" => SafekeepingPlaceFormat17Choice.TypeAndIdentification.Deserialize(elementWithPayload),
             "Prtry" => SafekeepingPlaceFormat17Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SafekeepingPlaceFormat17Choice choice.")
        };
    }
}
