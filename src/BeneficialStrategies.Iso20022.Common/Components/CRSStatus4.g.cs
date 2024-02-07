﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CRSStatus4.  ISO2002 ID# _uRVacUNeEeamLdeYEZm56w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Common Reporting Standard (CRS) status information.
/// </summary>
public partial record CRSStatus4
     : IIsoXmlSerilizable<CRSStatus4>
{
    #nullable enable
    
    /// <summary>
    /// Common Reporting Standard (CRS) status.
    /// </summary>
    public required CRSStatus3Choice_ Type { get; init; } 
    /// <summary>
    /// Source of the Common Reporting Standard (CRS) status.
    /// </summary>
    public CRSSource1Choice_? Source { get; init; } 
    /// <summary>
    /// Reporting country for the CRS status when there is an exception at the country level.
    /// </summary>
    public CountryCode? ExceptionalReportingCountry { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        Type.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Source is CRSSource1Choice_ SourceValue)
        {
            writer.WriteStartElement(null, "Src", xmlNamespace );
            SourceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExceptionalReportingCountry is CountryCode ExceptionalReportingCountryValue)
        {
            writer.WriteStartElement(null, "XcptnlRptgCtry", xmlNamespace );
            writer.WriteValue(ExceptionalReportingCountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static CRSStatus4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
