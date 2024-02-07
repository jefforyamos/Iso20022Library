﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InvestigationRequestStatus1Choice.  ISO2002 ID# _ffuncWQCEe297MhDQvVHLQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the status of the investigation request.
/// </summary>
[KnownType(typeof(InvestigationRequestStatus1Choice.Code))]
[KnownType(typeof(InvestigationRequestStatus1Choice.Proprietary))]
public abstract partial record InvestigationRequestStatus1Choice_ : IIsoXmlSerilizable<InvestigationRequestStatus1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InvestigationRequestStatus1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => InvestigationRequestStatus1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => InvestigationRequestStatus1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InvestigationRequestStatus1Choice choice.")
        };
    }
}
