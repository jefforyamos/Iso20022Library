﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Number2Choice.  ISO2002 ID# _Qu0y5Np-Ed-ak6NoX_4Aeg_-1987698151.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice number format.
/// </summary>
[KnownType(typeof(Number2Choice.Short))]
[KnownType(typeof(Number2Choice.Long))]
public abstract partial record Number2Choice_ : IIsoXmlSerilizable<Number2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Number2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Shrt" => Number2Choice.Short.Deserialize(elementWithPayload),
             "Lng" => Number2Choice.Long.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Number2Choice choice.")
        };
    }
}
