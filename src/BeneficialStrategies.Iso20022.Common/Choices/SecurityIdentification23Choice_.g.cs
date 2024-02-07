﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecurityIdentification23Choice.  ISO2002 ID# _B2G4ASGQEeW7gKYhAMEFCw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the identification of a financial instrument.
/// </summary>
[KnownType(typeof(SecurityIdentification23Choice.ISIN))]
[KnownType(typeof(SecurityIdentification23Choice.SEDOL))]
[KnownType(typeof(SecurityIdentification23Choice.CUSIP))]
[KnownType(typeof(SecurityIdentification23Choice.RIC))]
[KnownType(typeof(SecurityIdentification23Choice.TickerSymbol))]
[KnownType(typeof(SecurityIdentification23Choice.Bloomberg))]
[KnownType(typeof(SecurityIdentification23Choice.CTA))]
[KnownType(typeof(SecurityIdentification23Choice.QUICK))]
[KnownType(typeof(SecurityIdentification23Choice.Wertpapier))]
[KnownType(typeof(SecurityIdentification23Choice.Dutch))]
[KnownType(typeof(SecurityIdentification23Choice.Valoren))]
[KnownType(typeof(SecurityIdentification23Choice.Sicovam))]
[KnownType(typeof(SecurityIdentification23Choice.Belgian))]
[KnownType(typeof(SecurityIdentification23Choice.Common))]
[KnownType(typeof(SecurityIdentification23Choice.OtherProprietaryIdentification))]
public abstract partial record SecurityIdentification23Choice_ : IIsoXmlSerilizable<SecurityIdentification23Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SecurityIdentification23Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "ISIN" => SecurityIdentification23Choice.ISIN.Deserialize(elementWithPayload),
             "SEDOL" => SecurityIdentification23Choice.SEDOL.Deserialize(elementWithPayload),
             "CUSIP" => SecurityIdentification23Choice.CUSIP.Deserialize(elementWithPayload),
             "RIC" => SecurityIdentification23Choice.RIC.Deserialize(elementWithPayload),
             "TckrSymb" => SecurityIdentification23Choice.TickerSymbol.Deserialize(elementWithPayload),
             "Blmbrg" => SecurityIdentification23Choice.Bloomberg.Deserialize(elementWithPayload),
             "CTA" => SecurityIdentification23Choice.CTA.Deserialize(elementWithPayload),
             "QUICK" => SecurityIdentification23Choice.QUICK.Deserialize(elementWithPayload),
             "Wrtppr" => SecurityIdentification23Choice.Wertpapier.Deserialize(elementWithPayload),
             "Dtch" => SecurityIdentification23Choice.Dutch.Deserialize(elementWithPayload),
             "Vlrn" => SecurityIdentification23Choice.Valoren.Deserialize(elementWithPayload),
             "SCVM" => SecurityIdentification23Choice.Sicovam.Deserialize(elementWithPayload),
             "Belgn" => SecurityIdentification23Choice.Belgian.Deserialize(elementWithPayload),
             "Cmon" => SecurityIdentification23Choice.Common.Deserialize(elementWithPayload),
             "OthrPrtryId" => SecurityIdentification23Choice.OtherProprietaryIdentification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SecurityIdentification23Choice choice.")
        };
    }
}
