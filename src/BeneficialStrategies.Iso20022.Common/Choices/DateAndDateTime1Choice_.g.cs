﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateAndDateTime1Choice.  ISO2002 ID# _Axs_MNokEeC60axPepSq7g_-1588891689.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a date or a date and time format.
/// </summary>
[KnownType(typeof(DateAndDateTime1Choice.Date))]
[KnownType(typeof(DateAndDateTime1Choice.DateTime))]
public abstract partial record DateAndDateTime1Choice_ : IIsoXmlSerilizable<DateAndDateTime1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static DateAndDateTime1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Dt" => DateAndDateTime1Choice.Date.Deserialize(elementWithPayload),
             "DtTm" => DateAndDateTime1Choice.DateTime.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid DateAndDateTime1Choice choice.")
        };
    }
}
