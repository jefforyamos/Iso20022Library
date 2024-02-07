﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VolumeMetrics6.  ISO2002 ID# _HPOrga5QEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numeric variables calculated on the number of transactions or on market exposures.
/// </summary>
public partial record VolumeMetrics6
     : IIsoXmlSerilizable<VolumeMetrics6>
{
    #nullable enable
    
    /// <summary>
    /// Aggregations of all positive values of the derivative for all derivatives pertaining to a position set.
    /// </summary>
    public ExposureMetrics5? Positive { get; init; } 
    /// <summary>
    /// Aggregations of all negative values of the derivative for all derivatives pertaining to a position set.
    /// </summary>
    public ExposureMetrics5? Negative { get; init; } 
    
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
        if (Positive is ExposureMetrics5 PositiveValue)
        {
            writer.WriteStartElement(null, "Postv", xmlNamespace );
            PositiveValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Negative is ExposureMetrics5 NegativeValue)
        {
            writer.WriteStartElement(null, "Neg", xmlNamespace );
            NegativeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static VolumeMetrics6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
