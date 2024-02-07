﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AdditionalBusinessProcessFormat3Choice.  ISO2002 ID# _Q10yw9p-Ed-ak6NoX_4Aeg_861159193.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify the type of the additional business process, that is, a tax refund.
/// </summary>
[KnownType(typeof(AdditionalBusinessProcessFormat3Choice.Code))]
[KnownType(typeof(AdditionalBusinessProcessFormat3Choice.Proprietary))]
public abstract partial record AdditionalBusinessProcessFormat3Choice_ : IIsoXmlSerilizable<AdditionalBusinessProcessFormat3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AdditionalBusinessProcessFormat3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => AdditionalBusinessProcessFormat3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => AdditionalBusinessProcessFormat3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AdditionalBusinessProcessFormat3Choice choice.")
        };
    }
}
