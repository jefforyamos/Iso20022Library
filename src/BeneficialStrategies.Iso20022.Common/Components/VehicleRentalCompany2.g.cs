﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VehicleRentalCompany2.  ISO2002 ID# _mU3xscWlEeuhguwJmlgagQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Company in charge of a vehicle rental service.
/// </summary>
public partial record VehicleRentalCompany2
     : IIsoXmlSerilizable<VehicleRentalCompany2>
{
    #nullable enable
    
    /// <summary>
    /// Name of the vehicle rental company.
    /// </summary>
    public IsoMax70Text? Name { get; init; } 
    /// <summary>
    /// Identification of the vehicle rental company.
    /// </summary>
    public PartyIdentification258? Identification { get; init; } 
    /// <summary>
    /// Address of the vehicle rental company.
    /// </summary>
    public Address2? Address { get; init; } 
    /// <summary>
    /// Contact details at vehicle rental company location.
    /// </summary>
    public Contact3? Contact { get; init; } 
    /// <summary>
    /// Country of the vehicle rental company.
    /// ISO 3166
    /// </summary>
    public ISOMax3ACountryCode? Country { get; init; } 
    /// <summary>
    /// Type of vehicle rental activity.
    /// </summary>
    public CarRentalActivity1Code? Type { get; init; } 
    /// <summary>
    /// Other type of vehicle rental activity. 
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    
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
        if (Name is IsoMax70Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(NameValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (Identification is PartyIdentification258 IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            IdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Address is Address2 AddressValue)
        {
            writer.WriteStartElement(null, "Adr", xmlNamespace );
            AddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Contact is Contact3 ContactValue)
        {
            writer.WriteStartElement(null, "Ctct", xmlNamespace );
            ContactValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Country is ISOMax3ACountryCode CountryValue)
        {
            writer.WriteStartElement(null, "Ctry", xmlNamespace );
            writer.WriteValue(CountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Type is CarRentalActivity1Code TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            writer.WriteValue(TypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OtherType is IsoMax35Text OtherTypeValue)
        {
            writer.WriteStartElement(null, "OthrTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static VehicleRentalCompany2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
