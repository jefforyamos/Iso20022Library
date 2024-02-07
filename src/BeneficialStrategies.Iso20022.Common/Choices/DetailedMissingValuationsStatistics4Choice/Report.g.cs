﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Report.  ISO2002 ID# _x1GY41yGEe24CqbZJK5XxA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.DetailedMissingValuationsStatistics4Choice;

/// <summary>
/// Detailed information on statistics per combination of counterparties.
/// </summary>
public partial record Report : DetailedMissingValuationsStatistics4Choice_
     , IIsoXmlSerilizable<Report>
{
    #nullable enable
    
    /// <summary>
    /// Number of outstanding derivatives. 
    /// </summary>
    public required IsoNumber NumberOfOutstandingDerivatives { get; init; } 
    /// <summary>
    /// Number of outstanding derivatives for which valuation amount was never reported.
    /// </summary>
    public required IsoNumber NumberOfOutstandingDerivativesWithNoValuation { get; init; } 
    /// <summary>
    /// Number of outstanding derivatives with outdated valuation.
    /// </summary>
    public required IsoNumber NumberOfOutstandingDerivativesWithOutdatedValuation { get; init; } 
    /// <summary>
    /// Details of outstanding derivatives for which the valuation was not reported or the valuation reported is more than fourteen calendar days earlier than the date for which the report was generated shall be included in the report of missing valuations at the end of the day.
    /// </summary>
    public MissingValuationsData2? Warnings { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _x2DbJlyGEe24CqbZJK5XxA
    
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
        writer.WriteStartElement(null, "NbOfOutsdngDerivs", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoNumber(NumberOfOutstandingDerivatives)); // data type Number System.UInt64
        writer.WriteEndElement();
        writer.WriteStartElement(null, "NbOfOutsdngDerivsWthNoValtn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoNumber(NumberOfOutstandingDerivativesWithNoValuation)); // data type Number System.UInt64
        writer.WriteEndElement();
        writer.WriteStartElement(null, "NbOfOutsdngDerivsWthOutdtdValtn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoNumber(NumberOfOutstandingDerivativesWithOutdatedValuation)); // data type Number System.UInt64
        writer.WriteEndElement();
        // Not sure how to serialize Warnings, multiplicity Unknown
    }
    public static new Report Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
