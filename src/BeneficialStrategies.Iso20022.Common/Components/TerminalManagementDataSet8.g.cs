﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TerminalManagementDataSet8.  ISO2002 ID# _BS2goTV8EeODSIIQsYYKhw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of requested data set.
/// </summary>
public partial record TerminalManagementDataSet8
     : IIsoXmlSerilizable<TerminalManagementDataSet8>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the required data set.
    /// </summary>
    public required DataSetIdentification3 Identification { get; init; } 
    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    public IsoMax140Binary? POIChallenge { get; init; } 
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    public IsoMax140Binary? TMChallenge { get; init; } 
    /// <summary>
    /// Transport key encrypted by the TM (Terminal manager) key encryption RSA key.
    /// </summary>
    public ContentInformationType7? EncryptedKey { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (POIChallenge is IsoMax140Binary POIChallengeValue)
        {
            writer.WriteStartElement(null, "POIChllng", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Binary(POIChallengeValue)); // data type Max140Binary System.Byte[]
            writer.WriteEndElement();
        }
        if (TMChallenge is IsoMax140Binary TMChallengeValue)
        {
            writer.WriteStartElement(null, "TMChllng", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Binary(TMChallengeValue)); // data type Max140Binary System.Byte[]
            writer.WriteEndElement();
        }
        if (EncryptedKey is ContentInformationType7 EncryptedKeyValue)
        {
            writer.WriteStartElement(null, "NcrptdKey", xmlNamespace );
            EncryptedKeyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TerminalManagementDataSet8 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
