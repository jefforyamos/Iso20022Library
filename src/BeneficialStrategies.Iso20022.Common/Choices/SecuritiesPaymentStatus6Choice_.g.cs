﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesPaymentStatus6Choice.  ISO2002 ID# _5NZ7p5NLEeWGlc8L7oPDIg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the status of payment of a security at a particular time.
/// </summary>
[KnownType(typeof(SecuritiesPaymentStatus6Choice.Code))]
[KnownType(typeof(SecuritiesPaymentStatus6Choice.Proprietary))]
public abstract partial record SecuritiesPaymentStatus6Choice_ : IIsoXmlSerilizable<SecuritiesPaymentStatus6Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SecuritiesPaymentStatus6Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => SecuritiesPaymentStatus6Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => SecuritiesPaymentStatus6Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SecuritiesPaymentStatus6Choice choice.")
        };
    }
}
