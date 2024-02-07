﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesReferenceDeltaStatusReport3Choice.  ISO2002 ID# _PXSKkSdoEei12pGEsJIAeQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice defining financial instruments that are either new or have been modified. 
/// </summary>
[KnownType(typeof(SecuritiesReferenceDeltaStatusReport3Choice.ModifiedRecord))]
[KnownType(typeof(SecuritiesReferenceDeltaStatusReport3Choice.NewRecord))]
[KnownType(typeof(SecuritiesReferenceDeltaStatusReport3Choice.TerminatedRecord))]
public abstract partial record SecuritiesReferenceDeltaStatusReport3Choice_ : IIsoXmlSerilizable<SecuritiesReferenceDeltaStatusReport3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SecuritiesReferenceDeltaStatusReport3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "ModfdRcrd" => SecuritiesReferenceDeltaStatusReport3Choice.ModifiedRecord.Deserialize(elementWithPayload),
             "NewRcrd" => SecuritiesReferenceDeltaStatusReport3Choice.NewRecord.Deserialize(elementWithPayload),
             "TermntdRcrd" => SecuritiesReferenceDeltaStatusReport3Choice.TerminatedRecord.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SecuritiesReferenceDeltaStatusReport3Choice choice.")
        };
    }
}
