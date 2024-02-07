﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StandingOrderCriteria2.  ISO2002 ID# _i8ykRZlPEee-Zps0fZQaFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to search for a standing order and to report on standing orders. A name may be given to the new query.
/// </summary>
public partial record StandingOrderCriteria2
     : IIsoXmlSerilizable<StandingOrderCriteria2>
{
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    public IsoMax35Text? NewQueryName { get; init; } 
    /// <summary>
    /// Defines the criteria to be used to extract the standing order information.
    /// </summary>
    public StandingOrderSearchCriteria2? SearchCriteria { get; init; } 
    /// <summary>
    /// Defines the expected standing order report.
    /// </summary>
    public StandingOrderReturnCriteria1? ReturnCriteria { get; init; } 
    
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
        if (NewQueryName is IsoMax35Text NewQueryNameValue)
        {
            writer.WriteStartElement(null, "NewQryNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(NewQueryNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SearchCriteria is StandingOrderSearchCriteria2 SearchCriteriaValue)
        {
            writer.WriteStartElement(null, "SchCrit", xmlNamespace );
            SearchCriteriaValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReturnCriteria is StandingOrderReturnCriteria1 ReturnCriteriaValue)
        {
            writer.WriteStartElement(null, "RtrCrit", xmlNamespace );
            ReturnCriteriaValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static StandingOrderCriteria2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
