﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RepurchaseType23Choice.  ISO2002 ID# _ATHRgY-VEeaVK-2bgpxeYw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the repurchase transaction type information.
/// </summary>
[KnownType(typeof(RepurchaseType23Choice.Code))]
[KnownType(typeof(RepurchaseType23Choice.Proprietary))]
public abstract partial record RepurchaseType23Choice_ : IIsoXmlSerilizable<RepurchaseType23Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RepurchaseType23Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RepurchaseType23Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RepurchaseType23Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RepurchaseType23Choice choice.")
        };
    }
}
