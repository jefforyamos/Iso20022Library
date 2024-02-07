﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CertificationTypeFormat4Choice.  ISO2002 ID# _c5WhW5KQEeWHWpTQn1FFVg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify the certification format required.
/// </summary>
[KnownType(typeof(CertificationTypeFormat4Choice.Code))]
[KnownType(typeof(CertificationTypeFormat4Choice.Proprietary))]
public abstract partial record CertificationTypeFormat4Choice_ : IIsoXmlSerilizable<CertificationTypeFormat4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CertificationTypeFormat4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CertificationTypeFormat4Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => CertificationTypeFormat4Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CertificationTypeFormat4Choice choice.")
        };
    }
}
