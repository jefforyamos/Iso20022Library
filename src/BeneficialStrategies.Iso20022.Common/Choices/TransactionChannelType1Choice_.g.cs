﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransactionChannelType1Choice.  ISO2002 ID# _JtX4MRRGEeOKWo1NF21OVw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the specification of the type of transaction Channel.
/// </summary>
[KnownType(typeof(TransactionChannelType1Choice.Code))]
[KnownType(typeof(TransactionChannelType1Choice.Proprietary))]
public abstract partial record TransactionChannelType1Choice_ : IIsoXmlSerilizable<TransactionChannelType1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static TransactionChannelType1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => TransactionChannelType1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => TransactionChannelType1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid TransactionChannelType1Choice choice.")
        };
    }
}
