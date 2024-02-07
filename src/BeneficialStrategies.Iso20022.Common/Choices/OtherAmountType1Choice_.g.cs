﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OtherAmountType1Choice.  ISO2002 ID# _WLNL4I2NEeeNN9vGwZc5aA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between formats for a type of amount.
/// </summary>
[KnownType(typeof(OtherAmountType1Choice.Code))]
[KnownType(typeof(OtherAmountType1Choice.ProprietaryCode))]
public abstract partial record OtherAmountType1Choice_ : IIsoXmlSerilizable<OtherAmountType1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static OtherAmountType1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => OtherAmountType1Choice.Code.Deserialize(elementWithPayload),
             "PrtryCd" => OtherAmountType1Choice.ProprietaryCode.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid OtherAmountType1Choice choice.")
        };
    }
}
