﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GeneralBusinessInformationCriteriaDefinition1Choice.  ISO2002 ID# _1VwUF5lZEeeE1Ya-LgRsuQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
/// </summary>
[KnownType(typeof(GeneralBusinessInformationCriteriaDefinition1Choice.QueryName))]
[KnownType(typeof(GeneralBusinessInformationCriteriaDefinition1Choice.NewCriteria))]
public abstract partial record GeneralBusinessInformationCriteriaDefinition1Choice_ : IIsoXmlSerilizable<GeneralBusinessInformationCriteriaDefinition1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static GeneralBusinessInformationCriteriaDefinition1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "QryNm" => GeneralBusinessInformationCriteriaDefinition1Choice.QueryName.Deserialize(elementWithPayload),
             "NewCrit" => GeneralBusinessInformationCriteriaDefinition1Choice.NewCriteria.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid GeneralBusinessInformationCriteriaDefinition1Choice choice.")
        };
    }
}
