﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CentralCounterPartyEligibility1Choice.  ISO2002 ID# _Qvaox9p-Ed-ak6NoX_4Aeg_22450085.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the CCP eligibility information.
/// </summary>
[KnownType(typeof(CentralCounterPartyEligibility1Choice.Indicator))]
[KnownType(typeof(CentralCounterPartyEligibility1Choice.Proprietary))]
public abstract partial record CentralCounterPartyEligibility1Choice_ : IIsoXmlSerilizable<CentralCounterPartyEligibility1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CentralCounterPartyEligibility1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Ind" => CentralCounterPartyEligibility1Choice.Indicator.Deserialize(elementWithPayload),
             "Prtry" => CentralCounterPartyEligibility1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CentralCounterPartyEligibility1Choice choice.")
        };
    }
}
