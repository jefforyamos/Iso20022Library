﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for EligibilityIdentification1Choice.  ISO2002 ID# _jBJ_8u5NEeCisYr99QEiWA_59531621.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the eligibility details.
/// </summary>
[KnownType(typeof(EligibilityIdentification1Choice.Country))]
[KnownType(typeof(EligibilityIdentification1Choice.FinancialInstrumentIdentification))]
[KnownType(typeof(EligibilityIdentification1Choice.IssuerCSDIdentification))]
public abstract partial record EligibilityIdentification1Choice_ : IIsoXmlSerilizable<EligibilityIdentification1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static EligibilityIdentification1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Ctry" => EligibilityIdentification1Choice.Country.Deserialize(elementWithPayload),
             "FinInstrmId" => EligibilityIdentification1Choice.FinancialInstrumentIdentification.Deserialize(elementWithPayload),
             "IssrCSDId" => EligibilityIdentification1Choice.IssuerCSDIdentification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid EligibilityIdentification1Choice choice.")
        };
    }
}
