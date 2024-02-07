﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MarketClaimCancellationRequestStatus1Choice.  ISO2002 ID# _1TcqZtx4EeqESbVR5AloZQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between different instruction cancellation request statuses.
/// </summary>
[KnownType(typeof(MarketClaimCancellationRequestStatus1Choice.CancellationCompleted))]
[KnownType(typeof(MarketClaimCancellationRequestStatus1Choice.Accepted))]
[KnownType(typeof(MarketClaimCancellationRequestStatus1Choice.Rejected))]
[KnownType(typeof(MarketClaimCancellationRequestStatus1Choice.PendingCancellation))]
[KnownType(typeof(MarketClaimCancellationRequestStatus1Choice.ProprietaryStatus))]
public abstract partial record MarketClaimCancellationRequestStatus1Choice_ : IIsoXmlSerilizable<MarketClaimCancellationRequestStatus1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static MarketClaimCancellationRequestStatus1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "CxlCmpltd" => MarketClaimCancellationRequestStatus1Choice.CancellationCompleted.Deserialize(elementWithPayload),
             "Accptd" => MarketClaimCancellationRequestStatus1Choice.Accepted.Deserialize(elementWithPayload),
             "Rjctd" => MarketClaimCancellationRequestStatus1Choice.Rejected.Deserialize(elementWithPayload),
             "PdgCxl" => MarketClaimCancellationRequestStatus1Choice.PendingCancellation.Deserialize(elementWithPayload),
             "PrtrySts" => MarketClaimCancellationRequestStatus1Choice.ProprietaryStatus.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid MarketClaimCancellationRequestStatus1Choice choice.")
        };
    }
}
