﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CollateralCancellationType1Choice.  ISO2002 ID# _QmogONp-Ed-ak6NoX_4Aeg_-847110751.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a code and a proprietary code for the reason the collateral message has been cancelled.
/// </summary>
[KnownType(typeof(CollateralCancellationType1Choice.Code))]
[KnownType(typeof(CollateralCancellationType1Choice.Proprietary))]
public abstract partial record CollateralCancellationType1Choice_ : IIsoXmlSerilizable<CollateralCancellationType1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CollateralCancellationType1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CollateralCancellationType1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => CollateralCancellationType1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CollateralCancellationType1Choice choice.")
        };
    }
}
