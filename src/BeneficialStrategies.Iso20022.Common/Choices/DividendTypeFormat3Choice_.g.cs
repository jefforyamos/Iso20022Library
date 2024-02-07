﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DividendTypeFormat3Choice.  ISO2002 ID# _KsR2Md3iEd-KAqAOGQOnnw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify the type of dividend.
/// </summary>
[KnownType(typeof(DividendTypeFormat3Choice.Code))]
[KnownType(typeof(DividendTypeFormat3Choice.Proprietary))]
public abstract partial record DividendTypeFormat3Choice_ : IIsoXmlSerilizable<DividendTypeFormat3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static DividendTypeFormat3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => DividendTypeFormat3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => DividendTypeFormat3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid DividendTypeFormat3Choice choice.")
        };
    }
}
