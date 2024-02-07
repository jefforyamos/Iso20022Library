﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for EUDividendStatusType1Choice.  ISO2002 ID# _RgcdEtp-Ed-ak6NoX_4Aeg_-1297197608.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of an EU dividen status type.
/// </summary>
[KnownType(typeof(EUDividendStatusType1Choice.EUDividendStatus))]
[KnownType(typeof(EUDividendStatusType1Choice.Proprietary))]
public abstract partial record EUDividendStatusType1Choice_ : IIsoXmlSerilizable<EUDividendStatusType1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static EUDividendStatusType1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "EUDvddSts" => EUDividendStatusType1Choice.EUDividendStatus.Deserialize(elementWithPayload),
             "Prtry" => EUDividendStatusType1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid EUDividendStatusType1Choice choice.")
        };
    }
}
