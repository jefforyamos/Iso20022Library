﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProcessTiming5.  ISO2002 ID# _aZLdATAOEeugIJ3Gvoevmg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters defining the timing conditions to process an action.
/// </summary>
public partial record ProcessTiming5
     : IIsoXmlSerilizable<ProcessTiming5>
{
    #nullable enable
    
    /// <summary>
    /// Waiting time after the previous action in months, days, hours and minutes, leading zeros could be omitted.
    /// </summary>
    public IsoMax9NumericText? WaitingTime { get; init; } 
    /// <summary>
    /// Date and time to start the action.
    /// </summary>
    public IsoISODateTime? StartTime { get; init; } 
    /// <summary>
    /// Date and time after which the action cannot be processed.
    /// </summary>
    public IsoISODateTime? EndTime { get; init; } 
    /// <summary>
    /// Period delay between cyclic action activation in months, days, hours and minutes, leading zeros could be omitted.
    /// </summary>
    public IsoMax9NumericText? Period { get; init; } 
    /// <summary>
    /// Maximum number of cyclic calls.
    /// </summary>
    public IsoNumber? MaximumNumber { get; init; } 
    /// <summary>
    /// Identification of the minimum unit of time used by time configuration parameters.
    /// </summary>
    public TimeUnit1Code? UnitOfTime { get; init; } 
    
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
        if (WaitingTime is IsoMax9NumericText WaitingTimeValue)
        {
            writer.WriteStartElement(null, "WtgTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax9NumericText(WaitingTimeValue)); // data type Max9NumericText System.String
            writer.WriteEndElement();
        }
        if (StartTime is IsoISODateTime StartTimeValue)
        {
            writer.WriteStartElement(null, "StartTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(StartTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (EndTime is IsoISODateTime EndTimeValue)
        {
            writer.WriteStartElement(null, "EndTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(EndTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (Period is IsoMax9NumericText PeriodValue)
        {
            writer.WriteStartElement(null, "Prd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax9NumericText(PeriodValue)); // data type Max9NumericText System.String
            writer.WriteEndElement();
        }
        if (MaximumNumber is IsoNumber MaximumNumberValue)
        {
            writer.WriteStartElement(null, "MaxNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(MaximumNumberValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (UnitOfTime is TimeUnit1Code UnitOfTimeValue)
        {
            writer.WriteStartElement(null, "UnitOfTm", xmlNamespace );
            writer.WriteValue(UnitOfTimeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static ProcessTiming5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
