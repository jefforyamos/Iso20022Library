﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceInitialisationCardReaderResponse1.  ISO2002 ID# _4gUzkN7HEeiwsev40qZGEQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Device Initialisation Card Reader Response message.
/// </summary>
public partial record DeviceInitialisationCardReaderResponse1
     : IIsoXmlSerilizable<DeviceInitialisationCardReaderResponse1>
{
    #nullable enable
    
    /// <summary>
    /// Payment instrument entry mode requested by the Sale System.
    /// </summary>
    public CardDataReading6Code? CardEntryMode { get; init; } 
    /// <summary>
    /// Data of a Chip Card related to the reset of the chip.
    /// </summary>
    public ICCResetData1? ICCResetData { get; init; } 
    /// <summary>
    /// Additional information about the Device Initialisation Card Reader Response.
    /// </summary>
    public IsoMax10000Binary? AdditionalInformation { get; init; } 
    
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
        if (CardEntryMode is CardDataReading6Code CardEntryModeValue)
        {
            writer.WriteStartElement(null, "CardNtryMd", xmlNamespace );
            writer.WriteValue(CardEntryModeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ICCResetData is ICCResetData1 ICCResetDataValue)
        {
            writer.WriteStartElement(null, "ICCRstData", xmlNamespace );
            ICCResetDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalInformation is IsoMax10000Binary AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10000Binary(AdditionalInformationValue)); // data type Max10000Binary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static DeviceInitialisationCardReaderResponse1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
