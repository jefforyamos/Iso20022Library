﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesAccountModification1Choice.  ISO2002 ID# _hjLnamliEeGaMcKyqKNRfQ_-966924713.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Identifies which information are involved by a modification request for securities account reference data.
/// </summary>
[KnownType(typeof(SecuritiesAccountModification1Choice.SystemSecuritiesAccount))]
[KnownType(typeof(SecuritiesAccountModification1Choice.SystemRestriction))]
[KnownType(typeof(SecuritiesAccountModification1Choice.MarketSpecificAttribute))]
public abstract partial record SecuritiesAccountModification1Choice_ : IIsoXmlSerilizable<SecuritiesAccountModification1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SecuritiesAccountModification1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "SysSctiesAcct" => SecuritiesAccountModification1Choice.SystemSecuritiesAccount.Deserialize(elementWithPayload),
             "SysRstrctn" => SecuritiesAccountModification1Choice.SystemRestriction.Deserialize(elementWithPayload),
             "MktSpcfcAttr" => SecuritiesAccountModification1Choice.MarketSpecificAttribute.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SecuritiesAccountModification1Choice choice.")
        };
    }
}
