﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CitizenshipInformation1.  ISO2002 ID# _hRQnYQ2bEeSNWNtJlXOAhg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the the status of a legally recognized subject or national of a particular country.
/// </summary>
public partial record CitizenshipInformation1
     : IIsoXmlSerilizable<CitizenshipInformation1>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the country where a person was born or is legally accepted as belonging to the country.
    /// </summary>
    public required NationalityCode Nationality { get; init; } 
    /// <summary>
    /// Indicates whether the person is a legal minor. It may depend on the nationality, the domicile country or the transaction in which the person is involved.
    /// </summary>
    public IsoYesNoIndicator? MinorIndicator { get; init; } 
    /// <summary>
    /// Date of the commencement of citizenship.
    /// </summary>
    public IsoISODate? StartDate { get; init; } 
    /// <summary>
    /// Date of the end of citizenship.
    /// </summary>
    public IsoISODate? EndDate { get; init; } 
    
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
        writer.WriteStartElement(null, "Ntlty", xmlNamespace );
        writer.WriteValue(Nationality.ToString()); // Enum value
        writer.WriteEndElement();
        if (MinorIndicator is IsoYesNoIndicator MinorIndicatorValue)
        {
            writer.WriteStartElement(null, "MnrInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(MinorIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (StartDate is IsoISODate StartDateValue)
        {
            writer.WriteStartElement(null, "StartDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(StartDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (EndDate is IsoISODate EndDateValue)
        {
            writer.WriteStartElement(null, "EndDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(EndDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static CitizenshipInformation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
