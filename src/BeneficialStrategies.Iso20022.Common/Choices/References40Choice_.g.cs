﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for References40Choice.  ISO2002 ID# _SRMKUSGiEeONGJioFgcMDw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of references used to reference a previous transaction.
/// </summary>
[KnownType(typeof(References40Choice.RelatedReference))]
[KnownType(typeof(References40Choice.OtherReference))]
public abstract partial record References40Choice_ : IIsoXmlSerilizable<References40Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static References40Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "RltdRef" => References40Choice.RelatedReference.Deserialize(elementWithPayload),
             "OthrRef" => References40Choice.OtherReference.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid References40Choice choice.")
        };
    }
}
