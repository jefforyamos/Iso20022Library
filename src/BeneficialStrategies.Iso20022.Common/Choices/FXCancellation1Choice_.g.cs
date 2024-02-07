﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FXCancellation1Choice.  ISO2002 ID# _QtVlIdp-Ed-ak6NoX_4Aeg_615585032.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the FX cancellation information.
/// </summary>
[KnownType(typeof(FXCancellation1Choice.Indicator))]
[KnownType(typeof(FXCancellation1Choice.Proprietary))]
public abstract partial record FXCancellation1Choice_ : IIsoXmlSerilizable<FXCancellation1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FXCancellation1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Ind" => FXCancellation1Choice.Indicator.Deserialize(elementWithPayload),
             "Prtry" => FXCancellation1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FXCancellation1Choice choice.")
        };
    }
}
