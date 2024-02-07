﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IndividualPerson15.  ISO2002 ID# _QDdhsdp-Ed-ak6NoX_4Aeg_1034620131.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an 'artificial person').
/// </summary>
public partial record IndividualPerson15
     : IIsoXmlSerilizable<IndividualPerson15>
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public IsoMax350Text? Name { get; init; } 
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    public IsoISODate? BirthDate { get; init; } 
    /// <summary>
    /// Country and residential status of an individual, for example, non-permanent resident.
    /// </summary>
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 
    /// <summary>
    /// Information related to an identification, eg, party identification or account identification.
    /// </summary>
    public GenericIdentification12? OtherIdentification { get; init; } 
    /// <summary>
    /// Beneficial owner or its designated agent certifies that it complies with any holding or investment restrictions or requirements of the fund.
    /// </summary>
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; } 
    
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
        if (Name is IsoMax350Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(NameValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (BirthDate is IsoISODate BirthDateValue)
        {
            writer.WriteStartElement(null, "BirthDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(BirthDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (CountryAndResidentialStatus is CountryAndResidentialStatusType1 CountryAndResidentialStatusValue)
        {
            writer.WriteStartElement(null, "CtryAndResdtlSts", xmlNamespace );
            CountryAndResidentialStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherIdentification is GenericIdentification12 OtherIdentificationValue)
        {
            writer.WriteStartElement(null, "OthrId", xmlNamespace );
            OtherIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BeneficiaryCertificationCompletion is BeneficiaryCertificationCompletion1Code BeneficiaryCertificationCompletionValue)
        {
            writer.WriteStartElement(null, "BnfcryCertfctnCmpltn", xmlNamespace );
            writer.WriteValue(BeneficiaryCertificationCompletionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static IndividualPerson15 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
