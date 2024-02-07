﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NewCriteria.  ISO2002 ID# _U5qyVZlQEee-Zps0fZQaFQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TransactionCriteria4Choice;

/// <summary>
/// Explicitly defines the query criteria.
/// </summary>
public partial record NewCriteria : TransactionCriteria4Choice_
     , IIsoXmlSerilizable<NewCriteria>
{
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    public IsoMax35Text? NewQueryName { get; init; } 
    /// <summary>
    /// Defines the criteria on which the information is extracted.
    /// </summary>
    public TransactionSearchCriteria7? SearchCriteria { get; init; } 
    /// <summary>
    /// Indicates the format of the requested report.
    /// </summary>
    public ReportIndicator1Code? StatementReport { get; init; } 
    /// <summary>
    /// Defines the expected payment transaction report.
    /// </summary>
    public TransactionReturnCriteria5? ReturnCriteria { get; init; } 
    
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
        if (NewQueryName is IsoMax35Text NewQueryNameValue)
        {
            writer.WriteStartElement(null, "NewQryNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(NewQueryNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SearchCriteria is TransactionSearchCriteria7 SearchCriteriaValue)
        {
            writer.WriteStartElement(null, "SchCrit", xmlNamespace );
            SearchCriteriaValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StatementReport is ReportIndicator1Code StatementReportValue)
        {
            writer.WriteStartElement(null, "StmtRpt", xmlNamespace );
            writer.WriteValue(StatementReportValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ReturnCriteria is TransactionReturnCriteria5 ReturnCriteriaValue)
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
