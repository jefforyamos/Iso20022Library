﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriorityNumeric1Choice.  ISO2002 ID# _QuYG8Np-Ed-ak6NoX_4Aeg_827565267.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the priority.
/// </summary>
[KnownType(typeof(PriorityNumeric1Choice.Numeric))]
[KnownType(typeof(PriorityNumeric1Choice.Proprietary))]
public abstract partial record PriorityNumeric1Choice_ : IIsoXmlSerilizable<PriorityNumeric1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PriorityNumeric1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Nmrc" => PriorityNumeric1Choice.Numeric.Deserialize(elementWithPayload),
             "Prtry" => PriorityNumeric1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PriorityNumeric1Choice choice.")
        };
    }
}
