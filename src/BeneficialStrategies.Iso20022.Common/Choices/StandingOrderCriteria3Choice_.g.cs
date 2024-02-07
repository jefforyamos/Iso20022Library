﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StandingOrderCriteria3Choice.  ISO2002 ID# _GBYcFW4-EeiU9cctagi5ow.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
/// </summary>
[KnownType(typeof(StandingOrderCriteria3Choice.QueryName))]
[KnownType(typeof(StandingOrderCriteria3Choice.NewCriteria))]
public abstract partial record StandingOrderCriteria3Choice_ : IIsoXmlSerilizable<StandingOrderCriteria3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static StandingOrderCriteria3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "QryNm" => StandingOrderCriteria3Choice.QueryName.Deserialize(elementWithPayload),
             "NewCrit" => StandingOrderCriteria3Choice.NewCriteria.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid StandingOrderCriteria3Choice choice.")
        };
    }
}
