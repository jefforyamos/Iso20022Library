﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LegalOrganisation2.  ISO2002 ID# _9DOo8dOdEeS75MhTUaTyUQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Legally constituted organization specified for this party.
/// </summary>
public partial record LegalOrganisation2
     : IIsoXmlSerilizable<LegalOrganisation2>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution.
    /// </summary>
    public IsoMax35Text? Identification { get; init; } 
    /// <summary>
    /// Specifies the short name of the organisation.
    /// </summary>
    public IsoMax140Text? Name { get; init; } 
    /// <summary>
    /// Date when the organisation was established.
    /// </summary>
    public IsoISODate? EstablishmentDate { get; init; } 
    /// <summary>
    /// Date when the organisation was registered.
    /// </summary>
    public IsoISODate? RegistrationDate { get; init; } 
    
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
        if (Identification is IsoMax35Text IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(IdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Name is IsoMax140Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(NameValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (EstablishmentDate is IsoISODate EstablishmentDateValue)
        {
            writer.WriteStartElement(null, "EstblishmtDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(EstablishmentDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (RegistrationDate is IsoISODate RegistrationDateValue)
        {
            writer.WriteStartElement(null, "RegnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(RegistrationDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static LegalOrganisation2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
