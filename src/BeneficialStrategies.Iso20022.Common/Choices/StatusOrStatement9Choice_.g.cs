﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StatusOrStatement9Choice.  ISO2002 ID# _9a9TMdBxEeihG9bKfarOOA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the status or statement that is requested.
/// </summary>
[KnownType(typeof(StatusOrStatement9Choice.StatusAdvice))]
[KnownType(typeof(StatusOrStatement9Choice.Statement))]
public abstract partial record StatusOrStatement9Choice_ : IIsoXmlSerilizable<StatusOrStatement9Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static StatusOrStatement9Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "StsAdvc" => StatusOrStatement9Choice.StatusAdvice.Deserialize(elementWithPayload),
             "Stmt" => StatusOrStatement9Choice.Statement.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid StatusOrStatement9Choice choice.")
        };
    }
}
