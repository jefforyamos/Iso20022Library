﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for LegalFramework1Choice.  ISO2002 ID# _QuYG9tp-Ed-ak6NoX_4Aeg_-359745650.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the legal framework.
/// </summary>
[KnownType(typeof(LegalFramework1Choice.Code))]
[KnownType(typeof(LegalFramework1Choice.Proprietary))]
public abstract partial record LegalFramework1Choice_ : IIsoXmlSerilizable<LegalFramework1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static LegalFramework1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => LegalFramework1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => LegalFramework1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid LegalFramework1Choice choice.")
        };
    }
}
