﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Reversal6Choice.  ISO2002 ID# _f7k5oT8BEeSIqOPJHpnleA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between reversal by reference or by reversal details.
/// </summary>
[KnownType(typeof(Reversal6Choice.Reference))]
[KnownType(typeof(Reversal6Choice.TransferInConfirmationDetails))]
public abstract partial record Reversal6Choice_ : IIsoXmlSerilizable<Reversal6Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Reversal6Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Ref" => Reversal6Choice.Reference.Deserialize(elementWithPayload),
             "TrfInConfDtls" => Reversal6Choice.TransferInConfirmationDetails.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Reversal6Choice choice.")
        };
    }
}
