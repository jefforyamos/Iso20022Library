﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NewBeneficiary.  ISO2002 ID# _-Eq_sXltEeG7BsjMvd1mEw_-1059783639.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AddressOrParty1Choice;

/// <summary>
/// New beneficiary.
/// </summary>
public partial record NewBeneficiary : AddressOrParty1Choice_
     , IIsoXmlSerilizable<NewBeneficiary>
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and is usually used to identify that party.
    /// </summary>
    public required IsoMax140Text Name { get; init; } 
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    public required PostalAddress6 Address { get; init; } 
    
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
        writer.WriteStartElement(null, "Nm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax140Text(Name)); // data type Max140Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Adr", xmlNamespace );
        Address.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new NewBeneficiary Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
