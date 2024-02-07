﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for IssuerOrInvestor1Choice.  ISO2002 ID# _hh_UoWliEeGaMcKyqKNRfQ_1655812261.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Defines how the CSD is linked to the security.
/// </summary>
[KnownType(typeof(IssuerOrInvestor1Choice.IssuerCSD))]
[KnownType(typeof(IssuerOrInvestor1Choice.InvestorCSD))]
public abstract partial record IssuerOrInvestor1Choice_ : IIsoXmlSerilizable<IssuerOrInvestor1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static IssuerOrInvestor1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "IssrCSD" => IssuerOrInvestor1Choice.IssuerCSD.Deserialize(elementWithPayload),
             "InvstrCSD" => IssuerOrInvestor1Choice.InvestorCSD.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid IssuerOrInvestor1Choice choice.")
        };
    }
}
