﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionAndRepairReason1Choice.  ISO2002 ID# _UWrqZdp-Ed-ak6NoX_4Aeg_-254225608.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the rejection or repair reason.
/// </summary>
[KnownType(typeof(RejectionAndRepairReason1Choice.Code))]
[KnownType(typeof(RejectionAndRepairReason1Choice.Proprietary))]
public abstract partial record RejectionAndRepairReason1Choice_ : IIsoXmlSerilizable<RejectionAndRepairReason1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectionAndRepairReason1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RejectionAndRepairReason1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RejectionAndRepairReason1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectionAndRepairReason1Choice choice.")
        };
    }
}
