﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ReservationCriteria5Choice.  ISO2002 ID# _xgiPUQy_Ee2Wmf2RrXviyA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
/// </summary>
[KnownType(typeof(ReservationCriteria5Choice.QueryName))]
[KnownType(typeof(ReservationCriteria5Choice.NewCriteria))]
public abstract partial record ReservationCriteria5Choice_ : IIsoXmlSerilizable<ReservationCriteria5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ReservationCriteria5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "QryNm" => ReservationCriteria5Choice.QueryName.Deserialize(elementWithPayload),
             "NewCrit" => ReservationCriteria5Choice.NewCriteria.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ReservationCriteria5Choice choice.")
        };
    }
}
