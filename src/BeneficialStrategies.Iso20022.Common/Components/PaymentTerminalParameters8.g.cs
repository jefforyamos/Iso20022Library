﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTerminalParameters8.  ISO2002 ID# _clS40TAaEeugIJ3Gvoevmg.
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
public partial record PaymentTerminalParameters8
     : IIsoXmlSerilizable<PaymentTerminalParameters8>
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
    /// Version of the parameters' format.
    /// </summary>
    public IsoMax8Text? ParameterFormatIdentifier { get; init; } 
    /// <summary>
    /// Parameters to synchronise the real time clock of the POI (Point Of Interaction).
    /// </summary>
    public ClockSynchronisation3? ClockSynchronisation { get; init; } 
    /// <summary>
    /// Time zone line to update in the time zone data base subset stored in the POI (Point Of Interaction). The format of the line is conform to the IANA (Internet Assigned Number Authority) time zone data base.
    /// </summary>
    public IsoMax70Text? TimeZoneLine { get; init; } 
    /// <summary>
    /// Local time offset to UTC (Coordinated Universal Time).
    /// </summary>
    public LocalDateTime1? LocalDateTime { get; init; } 
    /// <summary>
    /// Full length of other parameters.
    /// </summary>
    public IsoPositiveNumber? OtherParametersLength { get; init; } 
    /// <summary>
    /// Place of this  Block, beginning with 0, in the full other parameters.
    /// </summary>
    public IsoPositiveNumber? OffsetStart { get; init; } 
    /// <summary>
    /// Following place of this Block in the full other parameters.
    /// </summary>
    public IsoPositiveNumber? OffsetEnd { get; init; } 
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
        if (ParameterFormatIdentifier is IsoMax8Text ParameterFormatIdentifierValue)
        {
            writer.WriteStartElement(null, "ParamFrmtIdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax8Text(ParameterFormatIdentifierValue)); // data type Max8Text System.String
            writer.WriteEndElement();
        }
        if (ClockSynchronisation is ClockSynchronisation3 ClockSynchronisationValue)
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
        if (OtherParametersLength is IsoPositiveNumber OtherParametersLengthValue)
        {
            writer.WriteStartElement(null, "OthrParamsLngth", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPositiveNumber(OtherParametersLengthValue)); // data type PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (OffsetStart is IsoPositiveNumber OffsetStartValue)
        {
            writer.WriteStartElement(null, "OffsetStart", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPositiveNumber(OffsetStartValue)); // data type PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (OffsetEnd is IsoPositiveNumber OffsetEndValue)
        {
            writer.WriteStartElement(null, "OffsetEnd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPositiveNumber(OffsetEndValue)); // data type PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (OtherParameters is IsoMax10000Binary OtherParametersValue)
        {
            writer.WriteStartElement(null, "OthrParams", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10000Binary(OtherParametersValue)); // data type Max10000Binary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static PaymentTerminalParameters8 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
