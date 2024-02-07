﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransferCancellationRejectedStatus1Choice.  ISO2002 ID# _U0fAstp-Ed-ak6NoX_4Aeg_330240032.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Reason for the rejected status.
/// </summary>
[KnownType(typeof(TransferCancellationRejectedStatus1Choice.Reason))]
[KnownType(typeof(TransferCancellationRejectedStatus1Choice.DataSourceScheme))]
public abstract partial record TransferCancellationRejectedStatus1Choice_ : IIsoXmlSerilizable<TransferCancellationRejectedStatus1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static TransferCancellationRejectedStatus1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Rsn" => TransferCancellationRejectedStatus1Choice.Reason.Deserialize(elementWithPayload),
             "DataSrcSchme" => TransferCancellationRejectedStatus1Choice.DataSourceScheme.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid TransferCancellationRejectedStatus1Choice choice.")
        };
    }
}
