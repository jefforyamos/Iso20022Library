﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GeneralBusinessOrError8Choice.  ISO2002 ID# _QrN5MXhdEeidzqjNEfehPg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Reports either on the business information or on a business error.
/// </summary>
[KnownType(typeof(GeneralBusinessOrError8Choice.BusinessError))]
[KnownType(typeof(GeneralBusinessOrError8Choice.GeneralBusiness))]
public abstract partial record GeneralBusinessOrError8Choice_ : IIsoXmlSerilizable<GeneralBusinessOrError8Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static GeneralBusinessOrError8Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "BizErr" => GeneralBusinessOrError8Choice.BusinessError.Deserialize(elementWithPayload),
             "GnlBiz" => GeneralBusinessOrError8Choice.GeneralBusiness.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid GeneralBusinessOrError8Choice choice.")
        };
    }
}
