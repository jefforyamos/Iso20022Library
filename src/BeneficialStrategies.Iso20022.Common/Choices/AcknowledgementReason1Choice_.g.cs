﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AcknowledgementReason1Choice.  ISO2002 ID# _UXuzR9p-Ed-ak6NoX_4Aeg_-355998535.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the acknowledgement reason.
/// </summary>
[KnownType(typeof(AcknowledgementReason1Choice.Code))]
[KnownType(typeof(AcknowledgementReason1Choice.Proprietary))]
public abstract partial record AcknowledgementReason1Choice_ : IIsoXmlSerilizable<AcknowledgementReason1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AcknowledgementReason1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => AcknowledgementReason1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => AcknowledgementReason1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AcknowledgementReason1Choice choice.")
        };
    }
}
