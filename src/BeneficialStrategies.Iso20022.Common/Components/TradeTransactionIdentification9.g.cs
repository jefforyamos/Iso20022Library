﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeTransactionIdentification9.  ISO2002 ID# _mdZxga7MEemZxoEFHjN-AQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on transaction and conducting counterparty.
/// </summary>
public partial record TradeTransactionIdentification9
     : IIsoXmlSerilizable<TradeTransactionIdentification9>
{
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    public required OrganisationIdentification9Choice_ ReportingCounterparty { get; init; } 
    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    public required OrganisationIdentification9Choice_ ReportSubmittingEntity { get; init; } 
    
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
        writer.WriteStartElement(null, "RptgCtrPty", xmlNamespace );
        ReportingCounterparty.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RptSubmitgNtty", xmlNamespace );
        ReportSubmittingEntity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static TradeTransactionIdentification9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
