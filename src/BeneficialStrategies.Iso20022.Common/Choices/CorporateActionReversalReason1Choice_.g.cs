﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionReversalReason1Choice.  ISO2002 ID# _QxDnhNp-Ed-ak6NoX_4Aeg_1723669606.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify the reason for the reversal.
/// </summary>
[KnownType(typeof(CorporateActionReversalReason1Choice.Code))]
[KnownType(typeof(CorporateActionReversalReason1Choice.Proprietary))]
public abstract partial record CorporateActionReversalReason1Choice_ : IIsoXmlSerilizable<CorporateActionReversalReason1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CorporateActionReversalReason1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CorporateActionReversalReason1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => CorporateActionReversalReason1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CorporateActionReversalReason1Choice choice.")
        };
    }
}
