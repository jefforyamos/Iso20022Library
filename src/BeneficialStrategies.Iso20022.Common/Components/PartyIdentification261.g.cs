﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification261.  ISO2002 ID# _YmhfccWyEeuhguwJmlgagQ.
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
public partial record PartyIdentification261
     : IIsoXmlSerilizable<PartyIdentification261>
{
    #nullable enable
    
    /// <summary>
    /// Contains an agency code or name.
    /// </summary>
    public IsoMax35Text? Code { get; init; } 
    /// <summary>
    /// Assigner of the code.
    /// </summary>
    public IsoMax35Text? Assigner { get; init; } 
    /// <summary>
    /// Contains the International Air Transport Association (IATA) code identifying the company that purchased the ticket. 
    /// </summary>
    public IsoMax35Text? IATACode { get; init; } 
    /// <summary>
    /// Name of the company.
    /// </summary>
    public IsoMax70Text? Name { get; init; } 
    /// <summary>
    /// Short name of the company.
    /// </summary>
    public IsoMax35Text? ShortName { get; init; } 
    /// <summary>
    /// Address of the customer.
    /// </summary>
    public Address2? Address { get; init; } 
    /// <summary>
    /// Contact information related to the customer.
    /// </summary>
    public Contact6? Contact { get; init; } 
    
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
        if (Code is IsoMax35Text CodeValue)
        {
            writer.WriteStartElement(null, "Cd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CodeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Assigner is IsoMax35Text AssignerValue)
        {
            writer.WriteStartElement(null, "Assgnr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AssignerValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (IATACode is IsoMax35Text IATACodeValue)
        {
            writer.WriteStartElement(null, "IATACd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(IATACodeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Name is IsoMax70Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(NameValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (ShortName is IsoMax35Text ShortNameValue)
        {
            writer.WriteStartElement(null, "ShrtNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ShortNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Address is Address2 AddressValue)
        {
            writer.WriteStartElement(null, "Adr", xmlNamespace );
            AddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Contact is Contact6 ContactValue)
        {
            writer.WriteStartElement(null, "Ctct", xmlNamespace );
            ContactValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PartyIdentification261 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
