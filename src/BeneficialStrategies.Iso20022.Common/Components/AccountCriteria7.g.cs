﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountCriteria7.  ISO2002 ID# _PxA_l249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to search for an account and to report on the account. A name may be given to the new query.
/// </summary>
public partial record AccountCriteria7
     : IIsoXmlSerilizable<AccountCriteria7>
{
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    public IsoMax35Text? NewQueryName { get; init; } 
    /// <summary>
    /// Defines the criteria to be used to extract the account information.
    /// </summary>
    public CashAccountSearchCriteria7? SearchCriteria { get; init; } 
    /// <summary>
    /// Defines the expected account report.
    /// </summary>
    public CashAccountReturnCriteria5? ReturnCriteria { get; init; } 
    
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
        if (SearchCriteria is CashAccountSearchCriteria7 SearchCriteriaValue)
        {
            writer.WriteStartElement(null, "SchCrit", xmlNamespace );
            SearchCriteriaValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReturnCriteria is CashAccountReturnCriteria5 ReturnCriteriaValue)
        {
            writer.WriteStartElement(null, "RtrCrit", xmlNamespace );
            ReturnCriteriaValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AccountCriteria7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
