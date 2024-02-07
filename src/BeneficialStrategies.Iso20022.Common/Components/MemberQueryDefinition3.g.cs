﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MemberQueryDefinition3.  ISO2002 ID# _tCLRIZlVEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the query criteria.
/// </summary>
public partial record MemberQueryDefinition3
     : IIsoXmlSerilizable<MemberQueryDefinition3>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    public QueryType2Code? QueryType { get; init; } 
    /// <summary>
    /// Defines the member query criteria.
    /// </summary>
    public MemberCriteriaDefinition1Choice_? MemberCriteria { get; init; } 
    
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
        if (MemberCriteria is MemberCriteriaDefinition1Choice_ MemberCriteriaValue)
        {
            writer.WriteStartElement(null, "MmbCrit", xmlNamespace );
            MemberCriteriaValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MemberQueryDefinition3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
