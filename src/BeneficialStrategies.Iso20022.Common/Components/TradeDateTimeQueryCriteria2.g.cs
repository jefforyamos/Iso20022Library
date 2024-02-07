﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeDateTimeQueryCriteria2.  ISO2002 ID# _aPgSUdGREeaQk737TH1Fzw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and time query criteria.
/// </summary>
public partial record TradeDateTimeQueryCriteria2
     : IIsoXmlSerilizable<TradeDateTimeQueryCriteria2>
{
    #nullable enable
    
    /// <summary>
    /// Indicates the reporting date and full hour that transaction was reported.
    /// </summary>
    public DateTimePeriod1? ReportingDateTime { get; init; } 
    /// <summary>
    /// Indicates the date and full hour the trade was executed.
    /// </summary>
    public DateTimePeriod1? ExecutionDateTime { get; init; } 
    /// <summary>
    /// Indicates the date when the trade was matured.
    /// </summary>
    public DateOrBlankQuery2Choice_? MaturityDate { get; init; } 
    /// <summary>
    /// Indicates the date when the trade was terminated.
    /// </summary>
    public DateOrBlankQuery2Choice_? TerminationDate { get; init; } 
    
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
        if (ReportingDateTime is DateTimePeriod1 ReportingDateTimeValue)
        {
            writer.WriteStartElement(null, "RptgDtTm", xmlNamespace );
            ReportingDateTimeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExecutionDateTime is DateTimePeriod1 ExecutionDateTimeValue)
        {
            writer.WriteStartElement(null, "ExctnDtTm", xmlNamespace );
            ExecutionDateTimeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MaturityDate is DateOrBlankQuery2Choice_ MaturityDateValue)
        {
            writer.WriteStartElement(null, "MtrtyDt", xmlNamespace );
            MaturityDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TerminationDate is DateOrBlankQuery2Choice_ TerminationDateValue)
        {
            writer.WriteStartElement(null, "TermntnDt", xmlNamespace );
            TerminationDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TradeDateTimeQueryCriteria2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
