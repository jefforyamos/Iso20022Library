﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InRepairStatus4Choice.  ISO2002 ID# _xydlISY4EeW_ZNn8gbfY7Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Reason for the in repair status.
/// </summary>
[KnownType(typeof(InRepairStatus4Choice.Reason))]
[KnownType(typeof(InRepairStatus4Choice.DataSourceScheme))]
[KnownType(typeof(InRepairStatus4Choice.NoSpecifiedReason))]
public abstract partial record InRepairStatus4Choice_ : IIsoXmlSerilizable<InRepairStatus4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InRepairStatus4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Rsn" => InRepairStatus4Choice.Reason.Deserialize(elementWithPayload),
             "DataSrcSchme" => InRepairStatus4Choice.DataSourceScheme.Deserialize(elementWithPayload),
             "NoSpcfdRsn" => InRepairStatus4Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InRepairStatus4Choice choice.")
        };
    }
}
