﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CardPaymentDataSetTransaction3Choice.  ISO2002 ID# _EmW5UWmJEeS7iYydEtv3Ug.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Card payment transaction choice between cancellation, authorisation request and authorisation response.
/// </summary>
[KnownType(typeof(CardPaymentDataSetTransaction3Choice.Completion))]
[KnownType(typeof(CardPaymentDataSetTransaction3Choice.Cancellation))]
[KnownType(typeof(CardPaymentDataSetTransaction3Choice.AuthorisationRequest))]
[KnownType(typeof(CardPaymentDataSetTransaction3Choice.AuthorisationResponse))]
public abstract partial record CardPaymentDataSetTransaction3Choice_ : IIsoXmlSerilizable<CardPaymentDataSetTransaction3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CardPaymentDataSetTransaction3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cmpltn" => CardPaymentDataSetTransaction3Choice.Completion.Deserialize(elementWithPayload),
             "Cxl" => CardPaymentDataSetTransaction3Choice.Cancellation.Deserialize(elementWithPayload),
             "AuthstnReq" => CardPaymentDataSetTransaction3Choice.AuthorisationRequest.Deserialize(elementWithPayload),
             "AuthstnRspn" => CardPaymentDataSetTransaction3Choice.AuthorisationResponse.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CardPaymentDataSetTransaction3Choice choice.")
        };
    }
}
