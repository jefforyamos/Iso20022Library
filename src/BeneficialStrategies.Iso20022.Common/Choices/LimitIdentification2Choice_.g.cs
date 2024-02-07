﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for LimitIdentification2Choice.  ISO2002 ID# _A_hEt24-EeiU9cctagi5ow.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Limit details of one particular limit set by the member and managed by the transaction administrator.
/// </summary>
[KnownType(typeof(LimitIdentification2Choice.Current))]
[KnownType(typeof(LimitIdentification2Choice.Default))]
[KnownType(typeof(LimitIdentification2Choice.AllCurrent))]
[KnownType(typeof(LimitIdentification2Choice.AllDefault))]
public abstract partial record LimitIdentification2Choice_ : IIsoXmlSerilizable<LimitIdentification2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static LimitIdentification2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cur" => LimitIdentification2Choice.Current.Deserialize(elementWithPayload),
             "Dflt" => LimitIdentification2Choice.Default.Deserialize(elementWithPayload),
             "AllCur" => LimitIdentification2Choice.AllCurrent.Deserialize(elementWithPayload),
             "AllDflt" => LimitIdentification2Choice.AllDefault.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid LimitIdentification2Choice choice.")
        };
    }
}
