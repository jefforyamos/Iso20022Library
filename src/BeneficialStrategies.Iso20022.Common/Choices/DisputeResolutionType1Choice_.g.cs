﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DisputeResolutionType1Choice.  ISO2002 ID# _QmogNdp-Ed-ak6NoX_4Aeg_1282948020.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a code or a proprietary code as to the nature of the dispute about the collateral amount.
/// </summary>
[KnownType(typeof(DisputeResolutionType1Choice.Code))]
[KnownType(typeof(DisputeResolutionType1Choice.ProprietaryIdentification))]
public abstract partial record DisputeResolutionType1Choice_ : IIsoXmlSerilizable<DisputeResolutionType1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static DisputeResolutionType1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => DisputeResolutionType1Choice.Code.Deserialize(elementWithPayload),
             "PrtryId" => DisputeResolutionType1Choice.ProprietaryIdentification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid DisputeResolutionType1Choice choice.")
        };
    }
}
