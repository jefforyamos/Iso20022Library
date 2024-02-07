﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ElectionAdviceStatus1Choice.  ISO2002 ID# _RiYWxtp-Ed-ak6NoX_4Aeg_896505165.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between the different statuses of an election advice.
/// </summary>
[KnownType(typeof(ElectionAdviceStatus1Choice.ProcessedStatus))]
[KnownType(typeof(ElectionAdviceStatus1Choice.RejectedStatus))]
public abstract partial record ElectionAdviceStatus1Choice_ : IIsoXmlSerilizable<ElectionAdviceStatus1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ElectionAdviceStatus1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PrcdSts" => ElectionAdviceStatus1Choice.ProcessedStatus.Deserialize(elementWithPayload),
             "RjctdSts" => ElectionAdviceStatus1Choice.RejectedStatus.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ElectionAdviceStatus1Choice choice.")
        };
    }
}
