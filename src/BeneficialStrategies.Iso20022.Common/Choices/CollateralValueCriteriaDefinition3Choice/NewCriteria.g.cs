﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NewCriteria.  ISO2002 ID# __xM6gzpsEemk2e6qGBk8IQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CollateralValueCriteriaDefinition3Choice;

/// <summary>
/// Explicitly defines the query criteria.
/// </summary>
public partial record NewCriteria : CollateralValueCriteriaDefinition3Choice_
     , IIsoXmlSerilizable<NewCriteria>
{
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    public IsoMax35Text? QueryName { get; init; } 
    /// <summary>
    /// Defines the criteria to be used to extract the account information.
    /// </summary>
    public CollateralValueSearchCriteria3? SearchCriteria { get; init; } 
    /// <summary>
    /// Defines the expected account report.
    /// </summary>
    public CollateralValueReturnCriteria1? ReturnCriteria { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (QueryName is IsoMax35Text QueryNameValue)
        {
            writer.WriteStartElement(null, "QryNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(QueryNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SearchCriteria is CollateralValueSearchCriteria3 SearchCriteriaValue)
        {
            writer.WriteStartElement(null, "SchCrit", xmlNamespace );
            SearchCriteriaValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReturnCriteria is CollateralValueReturnCriteria1 ReturnCriteriaValue)
        {
            writer.WriteStartElement(null, "RtrCrit", xmlNamespace );
            ReturnCriteriaValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new NewCriteria Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
