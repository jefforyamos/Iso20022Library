﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AcknowledgementReason2Choice.  ISO2002 ID# _UXuzRNp-Ed-ak6NoX_4Aeg_2050241792.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the acknowledgement reason.
/// </summary>
[KnownType(typeof(AcknowledgementReason2Choice.Code))]
[KnownType(typeof(AcknowledgementReason2Choice.Proprietary))]
public abstract partial record AcknowledgementReason2Choice_ : IIsoXmlSerilizable<AcknowledgementReason2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AcknowledgementReason2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => AcknowledgementReason2Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => AcknowledgementReason2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AcknowledgementReason2Choice choice.")
        };
    }
}
