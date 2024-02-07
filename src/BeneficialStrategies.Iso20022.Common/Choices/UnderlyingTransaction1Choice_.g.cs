﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnderlyingTransaction1Choice.  ISO2002 ID# _P9DXuNp-Ed-ak6NoX_4Aeg_-2030379979.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the details of the underlying transaction on which the investigation is processed.
/// </summary>
[KnownType(typeof(UnderlyingTransaction1Choice.Initiation))]
[KnownType(typeof(UnderlyingTransaction1Choice.Interbank))]
[KnownType(typeof(UnderlyingTransaction1Choice.StatementEntry))]
public abstract partial record UnderlyingTransaction1Choice_ : IIsoXmlSerilizable<UnderlyingTransaction1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static UnderlyingTransaction1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Initn" => UnderlyingTransaction1Choice.Initiation.Deserialize(elementWithPayload),
             "IntrBk" => UnderlyingTransaction1Choice.Interbank.Deserialize(elementWithPayload),
             "StmtNtry" => UnderlyingTransaction1Choice.StatementEntry.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid UnderlyingTransaction1Choice choice.")
        };
    }
}
