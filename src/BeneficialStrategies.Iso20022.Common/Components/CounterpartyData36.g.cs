﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CounterpartyData36.  ISO2002 ID# _77_r0Xd5EeerYuOTCu2Zqg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data specific to counterparties and related fields.
/// </summary>
public partial record CounterpartyData36
     : IIsoXmlSerilizable<CounterpartyData36>
{
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    public required IsoLEIIdentifier ReportSubmittingEntity { get; init; } 
    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    public required IsoLEIIdentifier ReportingCounterparty { get; init; } 
    
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
        writer.WriteStartElement(null, "RptSubmitgNtty", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(ReportSubmittingEntity)); // data type LEIIdentifier System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RptgCtrPty", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(ReportingCounterparty)); // data type LEIIdentifier System.String
        writer.WriteEndElement();
    }
    public static CounterpartyData36 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
