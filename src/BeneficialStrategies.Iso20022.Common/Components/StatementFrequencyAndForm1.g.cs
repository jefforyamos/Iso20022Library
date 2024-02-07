﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatementFrequencyAndForm1.  ISO2002 ID# _Xr9A8A1gEeKGXqvMN6jpiw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a frequency, format and delivery address for statements.
/// </summary>
public partial record StatementFrequencyAndForm1
     : IIsoXmlSerilizable<StatementFrequencyAndForm1>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the frequency for sending statements.
    /// </summary>
    public required Frequency7Code Frequency { get; init; } 
    /// <summary>
    /// Specifies the communication method for statements.
    /// </summary>
    public required CommunicationMethod2Choice_ CommunicationMethod { get; init; } 
    /// <summary>
    /// Specifies the delivery address for statements.
    /// </summary>
    public required IsoMax350Text DeliveryAddress { get; init; } 
    /// <summary>
    /// Specifies the format for statements.
    /// </summary>
    public required CommunicationFormat1Choice_ Format { get; init; } 
    
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
        writer.WriteStartElement(null, "Frqcy", xmlNamespace );
        writer.WriteValue(Frequency.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ComMtd", xmlNamespace );
        CommunicationMethod.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DlvryAdr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(DeliveryAddress)); // data type Max350Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Frmt", xmlNamespace );
        Format.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static StatementFrequencyAndForm1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
