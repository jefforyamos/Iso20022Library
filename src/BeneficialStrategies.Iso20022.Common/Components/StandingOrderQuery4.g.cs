﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StandingOrderQuery4.  ISO2002 ID# _gawsAdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the query criteria.
/// </summary>
public partial record StandingOrderQuery4
     : IIsoXmlSerilizable<StandingOrderQuery4>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    public QueryType2Code? QueryType { get; init; } 
    /// <summary>
    /// Definition of the standing order query criteria.
    /// </summary>
    public StandingOrderCriteria4Choice_? StandingOrderCriteria { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (QueryType is QueryType2Code QueryTypeValue)
        {
            writer.WriteStartElement(null, "QryTp", xmlNamespace );
            writer.WriteValue(QueryTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (StandingOrderCriteria is StandingOrderCriteria4Choice_ StandingOrderCriteriaValue)
        {
            writer.WriteStartElement(null, "StgOrdrCrit", xmlNamespace );
            StandingOrderCriteriaValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static StandingOrderQuery4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
