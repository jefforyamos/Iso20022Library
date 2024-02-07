﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTerminalParameters5.  ISO2002 ID# _wkqvcdqbEeearpaEPXv9UA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Manufacturer configuration parameters of the point of interaction (POI).
/// </summary>
public partial record PaymentTerminalParameters5
     : IIsoXmlSerilizable<PaymentTerminalParameters5>
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    public required TerminalManagementAction3Code ActionType { get; init; } 
    /// <summary>
    /// Identification of the vendor for the MTM, if the POI manages various subsets of terminal parameters.
    /// </summary>
    public IsoMax35Text? VendorIdentification { get; init; } 
    /// <summary>
    /// Version of the terminal parameters.
    /// </summary>
    public IsoMax256Text? Version { get; init; } 
    /// <summary>
    /// Parameters to synchronise the real time clock of the POI (Point Of Interaction).
    /// </summary>
    public ClockSynchronisation2? ClockSynchronisation { get; init; } 
    /// <summary>
    /// Time zone line to update in the time zone data base subset stored in the POI (Point Of Interaction). The format of the line is conform to the IANA (Internet Assigned Number Authority) time zone data base.
    /// </summary>
    public IsoMax70Text? TimeZoneLine { get; init; } 
    /// <summary>
    /// Local time offset to UTC (Coordinated Universal Time).
    /// </summary>
    public LocalDateTime1? LocalDateTime { get; init; } 
    /// <summary>
    /// Others manufacturer configuration parameters of the point of interaction.
    /// </summary>
    public IsoMax10000Binary? OtherParameters { get; init; } 
    
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
        writer.WriteStartElement(null, "ActnTp", xmlNamespace );
        writer.WriteValue(ActionType.ToString()); // Enum value
        writer.WriteEndElement();
        if (VendorIdentification is IsoMax35Text VendorIdentificationValue)
        {
            writer.WriteStartElement(null, "VndrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(VendorIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Version is IsoMax256Text VersionValue)
        {
            writer.WriteStartElement(null, "Vrsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax256Text(VersionValue)); // data type Max256Text System.String
            writer.WriteEndElement();
        }
        if (ClockSynchronisation is ClockSynchronisation2 ClockSynchronisationValue)
        {
            writer.WriteStartElement(null, "ClckSynctn", xmlNamespace );
            ClockSynchronisationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TimeZoneLine is IsoMax70Text TimeZoneLineValue)
        {
            writer.WriteStartElement(null, "TmZoneLine", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(TimeZoneLineValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (LocalDateTime is LocalDateTime1 LocalDateTimeValue)
        {
            writer.WriteStartElement(null, "LclDtTm", xmlNamespace );
            LocalDateTimeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherParameters is IsoMax10000Binary OtherParametersValue)
        {
            writer.WriteStartElement(null, "OthrParams", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10000Binary(OtherParametersValue)); // data type Max10000Binary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static PaymentTerminalParameters5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
