﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StatusOrStatement10Choice.  ISO2002 ID# _LSk41_fZEeiNZp_PtLohLw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the status or statement that is requested.
/// </summary>
[KnownType(typeof(StatusOrStatement10Choice.StatusAdvice))]
[KnownType(typeof(StatusOrStatement10Choice.Statement))]
public abstract partial record StatusOrStatement10Choice_ : IIsoXmlSerilizable<StatusOrStatement10Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static StatusOrStatement10Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "StsAdvc" => StatusOrStatement10Choice.StatusAdvice.Deserialize(elementWithPayload),
             "Stmt" => StatusOrStatement10Choice.Statement.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid StatusOrStatement10Choice choice.")
        };
    }
}
