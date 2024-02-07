﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ReferredDocumentType3Choice.  ISO2002 ID# _XxL1Jx77EeSxevWRRWxNAg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the type of the document referred in the remittance information.
/// </summary>
[KnownType(typeof(ReferredDocumentType3Choice.Code))]
[KnownType(typeof(ReferredDocumentType3Choice.Proprietary))]
public abstract partial record ReferredDocumentType3Choice_ : IIsoXmlSerilizable<ReferredDocumentType3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ReferredDocumentType3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => ReferredDocumentType3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => ReferredDocumentType3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ReferredDocumentType3Choice choice.")
        };
    }
}
