﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProductCategory1Choice.  ISO2002 ID# _RbrR1tp-Ed-ak6NoX_4Aeg_-1773751928.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies that the category of a product may be indicated by a code or by free text.
/// </summary>
[KnownType(typeof(ProductCategory1Choice.StructuredProductCategory))]
[KnownType(typeof(ProductCategory1Choice.OtherProductCategory))]
public abstract partial record ProductCategory1Choice_ : IIsoXmlSerilizable<ProductCategory1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ProductCategory1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "StrdPdctCtgy" => ProductCategory1Choice.StructuredProductCategory.Deserialize(elementWithPayload),
             "OthrPdctCtgy" => ProductCategory1Choice.OtherProductCategory.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ProductCategory1Choice choice.")
        };
    }
}
