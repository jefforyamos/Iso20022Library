﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OnLinePIN1.  ISO2002 ID# _SqIIwQEcEeCQm6a_G2yO_w_-1593466438.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted personal identification number (PIN) and related information.
/// </summary>
public partial record OnLinePIN1
     : IIsoXmlSerilizable<OnLinePIN1>
{
    #nullable enable
    
    /// <summary>
    /// Encrypted PIN (Personal Identification Number).
    /// </summary>
    public required ContentInformationType2 EncryptedPINBlock { get; init; } 
    /// <summary>
    /// PIN format before encryption.
    /// </summary>
    public required PINFormat1Code PINFormat { get; init; } 
    /// <summary>
    /// Additional information required to verify the PIN.
    /// </summary>
    public IsoMax35Text? AdditionalInput { get; init; } 
    
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
        writer.WriteStartElement(null, "NcrptdPINBlck", xmlNamespace );
        EncryptedPINBlock.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PINFrmt", xmlNamespace );
        writer.WriteValue(PINFormat.ToString()); // Enum value
        writer.WriteEndElement();
        if (AdditionalInput is IsoMax35Text AdditionalInputValue)
        {
            writer.WriteStartElement(null, "AddtlInpt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AdditionalInputValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static OnLinePIN1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
