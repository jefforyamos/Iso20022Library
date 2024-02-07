﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StandingOrderOrError7Choice.  ISO2002 ID# _eZL10dcZEeqRFcf2R4bPBw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between the standing order details or an operational error when the requested data cannot be retrieved.
/// </summary>
[KnownType(typeof(StandingOrderOrError7Choice.Report))]
[KnownType(typeof(StandingOrderOrError7Choice.OperationalError))]
public abstract partial record StandingOrderOrError7Choice_ : IIsoXmlSerilizable<StandingOrderOrError7Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static StandingOrderOrError7Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Rpt" => StandingOrderOrError7Choice.Report.Deserialize(elementWithPayload),
             "OprlErr" => StandingOrderOrError7Choice.OperationalError.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid StandingOrderOrError7Choice choice.")
        };
    }
}
