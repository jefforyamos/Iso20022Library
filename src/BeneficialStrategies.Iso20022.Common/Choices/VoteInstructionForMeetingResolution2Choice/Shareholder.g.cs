﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Shareholder.  ISO2002 ID# _n3g1VV6-EeSjaerr_EM7AQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.VoteInstructionForMeetingResolution2Choice;

/// <summary>
/// Specifies the name and address of the shareholder to whom the rights to vote are transferred for resolutions added during the meeting.
/// </summary>
public partial record Shareholder : VoteInstructionForMeetingResolution2Choice_
     , IIsoXmlSerilizable<Shareholder>
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax350Text Name { get; init; } 
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    public LongPostalAddress2Choice_? Address { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoMax350Text(Name)); // data type Max350Text System.String
        writer.WriteEndElement();
        if (Address is LongPostalAddress2Choice_ AddressValue)
        {
            writer.WriteStartElement(null, "Adr", xmlNamespace );
            AddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new Shareholder Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
