﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancelledReason1Choice.  ISO2002 ID# _QysmSNp-Ed-ak6NoX_4Aeg_503789636.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request is cancelled.
/// </summary>
[KnownType(typeof(CancelledReason1Choice.Code))]
[KnownType(typeof(CancelledReason1Choice.Proprietary))]
public abstract partial record CancelledReason1Choice_ : IIsoXmlSerilizable<CancelledReason1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CancelledReason1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CancelledReason1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => CancelledReason1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CancelledReason1Choice choice.")
        };
    }
}
