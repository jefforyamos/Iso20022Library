﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FileActionDetails2.  ISO2002 ID# _4VL0wZb7Eeuc6pwKtqbEVQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the file action to be performed.
/// </summary>
public partial record FileActionDetails2
     : IIsoXmlSerilizable<FileActionDetails2>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the file.
    /// ISO 8583 bit 101
    /// </summary>
    public IsoMax140Text? FileName { get; init; } 
    /// <summary>
    /// File format code.
    /// </summary>
    public OutputFormat5Code? Format { get; init; } 
    /// <summary>
    /// Content of record to be added, updated, deleted or replaced.
    /// ISO 8583:93/2003 bit 72
    /// </summary>
    public required DataRecord1Choice_ DataRecord { get; init; } 
    /// <summary>
    /// Date when the file action should be performed.
    /// ISO 8583 bit 73.
    /// </summary>
    public IsoISODate? ActionDate { get; init; } 
    /// <summary>
    /// Indicates that the originator of the message is authorised to update the file.
    /// ISO 8583:87 bit 92
    /// </summary>
    public IsoMax35Text? FileSecurityCode { get; init; } 
    
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
        if (FileName is IsoMax140Text FileNameValue)
        {
            writer.WriteStartElement(null, "FileNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(FileNameValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (Format is OutputFormat5Code FormatValue)
        {
            writer.WriteStartElement(null, "Frmt", xmlNamespace );
            writer.WriteValue(FormatValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DataRcrd", xmlNamespace );
        DataRecord.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ActionDate is IsoISODate ActionDateValue)
        {
            writer.WriteStartElement(null, "ActnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ActionDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (FileSecurityCode is IsoMax35Text FileSecurityCodeValue)
        {
            writer.WriteStartElement(null, "FileSctyCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(FileSecurityCodeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static FileActionDetails2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
