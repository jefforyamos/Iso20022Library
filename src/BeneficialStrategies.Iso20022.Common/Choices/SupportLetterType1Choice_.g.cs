﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SupportLetterType1Choice.  ISO2002 ID# _l_Ug0LbxEeu9Cp6InX88Vw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the type of supporting letter.
/// </summary>
[KnownType(typeof(SupportLetterType1Choice.Code))]
[KnownType(typeof(SupportLetterType1Choice.Proprietary))]
public abstract partial record SupportLetterType1Choice_ : IIsoXmlSerilizable<SupportLetterType1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SupportLetterType1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => SupportLetterType1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => SupportLetterType1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SupportLetterType1Choice choice.")
        };
    }
}
