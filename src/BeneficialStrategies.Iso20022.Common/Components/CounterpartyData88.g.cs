﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CounterpartyData88.  ISO2002 ID# _zwwsHcg3EeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of information specific to the counterparty.
/// </summary>
public partial record CounterpartyData88
     : IIsoXmlSerilizable<CounterpartyData88>
{
    #nullable enable
    
    /// <summary>
    /// Date and time of submission of the report to the trade repository.
    /// </summary>
    public required IsoISODateTime ReportingDateTime { get; init; } 
    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    public required OrganisationIdentification15Choice_ ReportSubmittingEntity { get; init; } 
    /// <summary>
    /// Set of information specific to counterparties.
    /// </summary>
    public ValueList<CounterpartyData89> Counterparty { get; init; } = [];
    
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
        writer.WriteStartElement(null, "RptgDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(ReportingDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RptSubmitgNtty", xmlNamespace );
        ReportSubmittingEntity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CtrPty", xmlNamespace );
        Counterparty.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static CounterpartyData88 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
