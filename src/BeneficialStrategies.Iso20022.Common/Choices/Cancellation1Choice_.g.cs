﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Cancellation1Choice.  ISO2002 ID# _GYMTExg1EeK-_89we2b-bA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between cancellation by reference or by transfer details.
/// </summary>
[KnownType(typeof(Cancellation1Choice.Reference))]
[KnownType(typeof(Cancellation1Choice.TransferOutDetails))]
public abstract partial record Cancellation1Choice_ : IIsoXmlSerilizable<Cancellation1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Cancellation1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Ref" => Cancellation1Choice.Reference.Deserialize(elementWithPayload),
             "TrfOutDtls" => Cancellation1Choice.TransferOutDetails.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Cancellation1Choice choice.")
        };
    }
}
