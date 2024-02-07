﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification210.  ISO2002 ID# _OIOBdPfUEei89sMSHxl1ew.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
public partial record PartyIdentification210
     : IIsoXmlSerilizable<PartyIdentification210>
{
    #nullable enable
    
    /// <summary>
    /// Contains the personal ID associated with the individual working in a temporary capacity.
    /// </summary>
    public IsoMax35Text? PersonalIdentification { get; init; } 
    /// <summary>
    /// Contains the company-provided ID associated with the individual working in a temporary capacity.
    /// </summary>
    public IsoPhoneNumber? EmployeeIdentification { get; init; } 
    /// <summary>
    /// Contains the name of the individual working in a temporary capacity.
    /// </summary>
    public IsoMax70Text? Name { get; init; } 
    /// <summary>
    /// Contains the professional level of the individual working in a temporary capacity.
    /// </summary>
    public IsoMax35Text? ProfessionalLevel { get; init; } 
    
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
        if (PersonalIdentification is IsoMax35Text PersonalIdentificationValue)
        {
            writer.WriteStartElement(null, "PrsnlId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PersonalIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (EmployeeIdentification is IsoPhoneNumber EmployeeIdentificationValue)
        {
            writer.WriteStartElement(null, "MplyeeId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPhoneNumber(EmployeeIdentificationValue)); // data type PhoneNumber System.String
            writer.WriteEndElement();
        }
        if (Name is IsoMax70Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(NameValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (ProfessionalLevel is IsoMax35Text ProfessionalLevelValue)
        {
            writer.WriteStartElement(null, "PrfssnlLvl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProfessionalLevelValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static PartyIdentification210 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
