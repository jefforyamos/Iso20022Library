﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecurityClassificationType1Choice.  ISO2002 ID# _Q7pG4dp-Ed-ak6NoX_4Aeg_-1579220601.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a CFI code or an other type of identification for the classification of the financial instrument.
/// </summary>
[KnownType(typeof(SecurityClassificationType1Choice.CFI))]
[KnownType(typeof(SecurityClassificationType1Choice.AlternateClassification))]
public abstract partial record SecurityClassificationType1Choice_ : IIsoXmlSerilizable<SecurityClassificationType1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SecurityClassificationType1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "CFI" => SecurityClassificationType1Choice.CFI.Deserialize(elementWithPayload),
             "AltrnClssfctn" => SecurityClassificationType1Choice.AlternateClassification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SecurityClassificationType1Choice choice.")
        };
    }
}
