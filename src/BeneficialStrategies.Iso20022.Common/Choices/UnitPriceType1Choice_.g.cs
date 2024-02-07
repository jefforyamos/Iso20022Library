﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnitPriceType1Choice.  ISO2002 ID# _RfZ7Qtp-Ed-ak6NoX_4Aeg_911473235.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of unit price type.
/// </summary>
[KnownType(typeof(UnitPriceType1Choice.Type))]
[KnownType(typeof(UnitPriceType1Choice.Proprietary))]
public abstract partial record UnitPriceType1Choice_ : IIsoXmlSerilizable<UnitPriceType1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static UnitPriceType1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Tp" => UnitPriceType1Choice.Type.Deserialize(elementWithPayload),
             "Prtry" => UnitPriceType1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid UnitPriceType1Choice choice.")
        };
    }
}
