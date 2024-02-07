﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuredMarketReport4Choice.  ISO2002 ID# _GQHsIcEREea7jLfvGi1PDw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a reason for no activity and the secured market segment transaction details.
/// </summary>
[KnownType(typeof(SecuredMarketReport4Choice.DataSetAction))]
[KnownType(typeof(SecuredMarketReport4Choice.Transaction))]
public abstract partial record SecuredMarketReport4Choice_ : IIsoXmlSerilizable<SecuredMarketReport4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SecuredMarketReport4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "DataSetActn" => SecuredMarketReport4Choice.DataSetAction.Deserialize(elementWithPayload),
             "Tx" => SecuredMarketReport4Choice.Transaction.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SecuredMarketReport4Choice choice.")
        };
    }
}
