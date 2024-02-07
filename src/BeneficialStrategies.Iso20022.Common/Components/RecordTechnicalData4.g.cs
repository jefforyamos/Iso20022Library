﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RecordTechnicalData4.  ISO2002 ID# _OwQysSX7EeigZbhgJcrASA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument specific technical data to support identification.
/// </summary>
public partial record RecordTechnicalData4
     : IIsoXmlSerilizable<RecordTechnicalData4>
{
    #nullable enable
    
    /// <summary>
    /// Flag to say if there is an inconsistency across all submitting entities records.
    /// </summary>
    public IsoTrueFalseIndicator? InconsistencyIndicator { get; init; } 
    /// <summary>
    /// Last date for which data was received for this instrument.
    /// </summary>
    public IsoISODateTime? LastUpdate { get; init; } 
    /// <summary>
    /// Defines the date and time when this instrument was originally received at the submission destination.
    /// </summary>
    public IsoISODateTime? SubmissionDateTime { get; init; } 
    /// <summary>
    /// Country code of the relevant competent authority of the instrument.
    /// </summary>
    public CountryCode? RelevantCompetentAuthority { get; init; } 
    /// <summary>
    /// Period for which the associated instrument has been publically available.
    /// </summary>
    public Period4Choice_? PublicationPeriod { get; init; } 
    /// <summary>
    /// Flag to say if the record has ever been published.
    /// </summary>
    public IsoTrueFalseIndicator? NeverPublished { get; init; } 
    /// <summary>
    /// Trading venue of the record used by the relevant competent authority to determine the reference data for the instrument.
    /// </summary>
    public IsoMICIdentifier? RelevantTradingVenue { get; init; } 
    
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
        if (InconsistencyIndicator is IsoTrueFalseIndicator InconsistencyIndicatorValue)
        {
            writer.WriteStartElement(null, "IncnsstncyInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(InconsistencyIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (LastUpdate is IsoISODateTime LastUpdateValue)
        {
            writer.WriteStartElement(null, "LastUpd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(LastUpdateValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (SubmissionDateTime is IsoISODateTime SubmissionDateTimeValue)
        {
            writer.WriteStartElement(null, "SubmissnDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(SubmissionDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (RelevantCompetentAuthority is CountryCode RelevantCompetentAuthorityValue)
        {
            writer.WriteStartElement(null, "RlvntCmptntAuthrty", xmlNamespace );
            writer.WriteValue(RelevantCompetentAuthorityValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PublicationPeriod is Period4Choice_ PublicationPeriodValue)
        {
            writer.WriteStartElement(null, "PblctnPrd", xmlNamespace );
            PublicationPeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NeverPublished is IsoTrueFalseIndicator NeverPublishedValue)
        {
            writer.WriteStartElement(null, "NvrPblshd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(NeverPublishedValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (RelevantTradingVenue is IsoMICIdentifier RelevantTradingVenueValue)
        {
            writer.WriteStartElement(null, "RlvntTradgVn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMICIdentifier(RelevantTradingVenueValue)); // data type MICIdentifier System.String
            writer.WriteEndElement();
        }
    }
    public static RecordTechnicalData4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
