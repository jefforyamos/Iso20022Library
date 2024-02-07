﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CollateralValueCriteriaDefinition1Choice.  ISO2002 ID# _jJgDo-5NEeCisYr99QEiWA_-333364953.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Definition of the collateral value query criteria.
/// </summary>
[KnownType(typeof(CollateralValueCriteriaDefinition1Choice.QueryName))]
[KnownType(typeof(CollateralValueCriteriaDefinition1Choice.NewCriteria))]
public abstract partial record CollateralValueCriteriaDefinition1Choice_ : IIsoXmlSerilizable<CollateralValueCriteriaDefinition1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CollateralValueCriteriaDefinition1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "QryNm" => CollateralValueCriteriaDefinition1Choice.QueryName.Deserialize(elementWithPayload),
             "NewCrit" => CollateralValueCriteriaDefinition1Choice.NewCriteria.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CollateralValueCriteriaDefinition1Choice choice.")
        };
    }
}
