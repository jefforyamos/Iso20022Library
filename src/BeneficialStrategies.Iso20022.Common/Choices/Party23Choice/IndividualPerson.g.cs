﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndividualPerson.  ISO2002 ID# _Bkkfc2W8EeSHcOWXSsMhqw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Party23Choice;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an 'artificial person').
/// </summary>
public partial record IndividualPerson : Party23Choice_
     , IIsoXmlSerilizable<IndividualPerson>
{
    #nullable enable
    
    /// <summary>
    /// Term used to address a person.
    /// </summary>
    public NamePrefix1Choice_? NamePrefix { get; init; } 
    /// <summary>
    /// First name of a person.
    /// </summary>
    public required IsoMax35Text GivenName { get; init; } 
    /// <summary>
    /// Second name of a person.
    /// </summary>
    public IsoMax35Text? MiddleName { get; init; } 
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax350Text Name { get; init; } 
    /// <summary>
    /// Additional information about a person that follows a person's name, for example, qualification such as Doctor of Philosophy (PhD).
    /// </summary>
    public IsoMax35Text? NameSuffix { get; init; } 
    /// <summary>
    /// Specifies the gender of the person.
    /// </summary>
    public GenderCode? Gender { get; init; } 
    /// <summary>
    /// Language in which a person communicates.
    /// </summary>
    public LanguageCode? Language { get; init; } 
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    public required IsoISODate BirthDate { get; init; } 
    /// <summary>
    /// Country where a person was born.
    /// </summary>
    public CountryCode? CountryOfBirth { get; init; } 
    /// <summary>
    /// Province where a person was born.
    /// </summary>
    public IsoMax35Text? ProvinceOfBirth { get; init; } 
    /// <summary>
    /// City where a person was born.
    /// </summary>
    public IsoMax35Text? CityOfBirth { get; init; } 
    /// <summary>
    /// Name of the occupation or job of a person.
    /// </summary>
    public IsoMax35Text? Profession { get; init; } 
    /// <summary>
    /// Country of taxation of an individual person.
    /// </summary>
    public CountryCode? TaxationCountry { get; init; } 
    /// <summary>
    /// Country and residential status of an individual, for example, non-permanent resident.
    /// </summary>
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    public ValueList<PostalAddress3> PostalAddress { get; init; } = [];
    /// <summary>
    /// Nationality and legal status (minor or major) or rights that an individual may possess.
    /// </summary>
    public ValueList<CitizenshipInformation> Citizenship { get; init; } = [];
    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    public IsoMax140Text? EmployingCompany { get; init; } 
    /// <summary>
    /// Title of the function.
    /// </summary>
    public IsoMax35Text? BusinessFunction { get; init; } 
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    /// <summary>
    /// Alternative identification, for example, national registration identification number, passport number, or an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    public ValueList<GenericIdentification55> OtherIdentification { get; init; } = [];
    /// <summary>
    /// Additional regulatory information about the investor that is required in some markets to support anti-money laundering laws.
    /// </summary>
    public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; } 
    /// <summary>
    /// Specifies if due diligence checks on the political exposure of the investor have been carried out and whether these checks are national or foreign. (A politically exposed person is someone who has been entrusted with a prominent public function, or an individual who is closely related to such a person.).
    /// </summary>
    public PoliticalExposureType1Choice_? PoliticallyExposedPersonType { get; init; } 
    
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
        if (NamePrefix is NamePrefix1Choice_ NamePrefixValue)
        {
            writer.WriteStartElement(null, "NmPrfx", xmlNamespace );
            NamePrefixValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "GvnNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(GivenName)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (MiddleName is IsoMax35Text MiddleNameValue)
        {
            writer.WriteStartElement(null, "MddlNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MiddleNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Nm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(Name)); // data type Max350Text System.String
        writer.WriteEndElement();
        if (NameSuffix is IsoMax35Text NameSuffixValue)
        {
            writer.WriteStartElement(null, "NmSfx", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(NameSuffixValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Gender is GenderCode GenderValue)
        {
            writer.WriteStartElement(null, "Gndr", xmlNamespace );
            writer.WriteValue(GenderValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Language is LanguageCode LanguageValue)
        {
            writer.WriteStartElement(null, "Lang", xmlNamespace );
            writer.WriteValue(LanguageValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "BirthDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(BirthDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (CountryOfBirth is CountryCode CountryOfBirthValue)
        {
            writer.WriteStartElement(null, "CtryOfBirth", xmlNamespace );
            writer.WriteValue(CountryOfBirthValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ProvinceOfBirth is IsoMax35Text ProvinceOfBirthValue)
        {
            writer.WriteStartElement(null, "PrvcOfBirth", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProvinceOfBirthValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CityOfBirth is IsoMax35Text CityOfBirthValue)
        {
            writer.WriteStartElement(null, "CityOfBirth", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CityOfBirthValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Profession is IsoMax35Text ProfessionValue)
        {
            writer.WriteStartElement(null, "Prfssn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProfessionValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TaxationCountry is CountryCode TaxationCountryValue)
        {
            writer.WriteStartElement(null, "TaxtnCtry", xmlNamespace );
            writer.WriteValue(TaxationCountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CountryAndResidentialStatus is CountryAndResidentialStatusType1 CountryAndResidentialStatusValue)
        {
            writer.WriteStartElement(null, "CtryAndResdtlSts", xmlNamespace );
            CountryAndResidentialStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PstlAdr", xmlNamespace );
        PostalAddress.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Ctznsh", xmlNamespace );
        Citizenship.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (EmployingCompany is IsoMax140Text EmployingCompanyValue)
        {
            writer.WriteStartElement(null, "EmplngCpny", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(EmployingCompanyValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (BusinessFunction is IsoMax35Text BusinessFunctionValue)
        {
            writer.WriteStartElement(null, "BizFctn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(BusinessFunctionValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PrimaryCommunicationAddress is CommunicationAddress3 PrimaryCommunicationAddressValue)
        {
            writer.WriteStartElement(null, "PmryComAdr", xmlNamespace );
            PrimaryCommunicationAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecondaryCommunicationAddress is CommunicationAddress3 SecondaryCommunicationAddressValue)
        {
            writer.WriteStartElement(null, "ScndryComAdr", xmlNamespace );
            SecondaryCommunicationAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OthrId", xmlNamespace );
        OtherIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalRegulatoryInformation is RegulatoryInformation1 AdditionalRegulatoryInformationValue)
        {
            writer.WriteStartElement(null, "AddtlRgltryInf", xmlNamespace );
            AdditionalRegulatoryInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PoliticallyExposedPersonType is PoliticalExposureType1Choice_ PoliticallyExposedPersonTypeValue)
        {
            writer.WriteStartElement(null, "PltclyXpsdPrsnTp", xmlNamespace );
            PoliticallyExposedPersonTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new IndividualPerson Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
