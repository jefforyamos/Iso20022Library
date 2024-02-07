﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateOccurrences2.  ISO2002 ID# _tyV98FkyEeGeoaLUQk__nA_-12295162.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to the duration of the mandate and the occurrence of the underlying transactions.
/// </summary>
public partial record MandateOccurrences2
     : IIsoXmlSerilizable<MandateOccurrences2>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the underlying transaction sequence as either recurring or one-off.
    /// </summary>
    public required SequenceType2Code SequenceType { get; init; } 
    /// <summary>
    /// Regularity with which instructions are to be created and processed.
    /// </summary>
    public Frequency6Code? Frequency { get; init; } 
    /// <summary>
    /// Length of time for which the mandate remains valid.
    /// </summary>
    public DatePeriodDetails1? Duration { get; init; } 
    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    public IsoISODate? FirstCollectionDate { get; init; } 
    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    public IsoISODate? FinalCollectionDate { get; init; } 
    
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
        writer.WriteStartElement(null, "SeqTp", xmlNamespace );
        writer.WriteValue(SequenceType.ToString()); // Enum value
        writer.WriteEndElement();
        if (Frequency is Frequency6Code FrequencyValue)
        {
            writer.WriteStartElement(null, "Frqcy", xmlNamespace );
            writer.WriteValue(FrequencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Duration is DatePeriodDetails1 DurationValue)
        {
            writer.WriteStartElement(null, "Drtn", xmlNamespace );
            DurationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FirstCollectionDate is IsoISODate FirstCollectionDateValue)
        {
            writer.WriteStartElement(null, "FrstColltnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(FirstCollectionDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (FinalCollectionDate is IsoISODate FinalCollectionDateValue)
        {
            writer.WriteStartElement(null, "FnlColltnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(FinalCollectionDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static MandateOccurrences2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
