﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PINData.  ISO2002 ID# _4EhKppaNEemfCcEf5rVTyg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.VerificationValue1Choice;

/// <summary>
/// Personal Identification Number data.
/// ISO 13492 and ISO 9564-1
/// ISO 8583:87 bit 52 & bit 53 or bit 110
/// ISO 8583:93 bit 52 & bit 53 or bit 111
/// ISO 8583:2003 bit 52 & bit 53 or bit 50
/// </summary>
public partial record PINData : VerificationValue1Choice_
     , IIsoXmlSerilizable<PINData>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the key management scheme and associated control field format.
    /// ISO 13492
    /// Binary, length of 1
    /// </summary>
    public IsoExact1HexBinaryText? Control { get; init; } 
    /// <summary>
    /// key-set identifier is a number that uniquely identifies a group of related keys that are all different but have certain characteristics in common.
    /// ISO 13492
    /// lengths of 6 or 8 
    /// </summary>
    public IsoMax8NumericText? KeySetIdentifier { get; init; } 
    /// <summary>
    /// Contains Derived Info or Device ID and Transaction Counter.
    /// ISO 13492
    /// Binary, lengths of 5, 8, 16 or 32 
    /// </summary>
    public IsoMax32HexBinaryText? DerivedInformation { get; init; } 
    /// <summary>
    /// Used to select the encryption algorithm to encipher the keys contained in the associated key management data element. 
    /// ISO 13492
    /// </summary>
    public IsoMax2NumericText? Algorithm { get; init; } 
    /// <summary>
    /// Specifies the length of the keys being transported, not the encrypting key.
    /// ISO 13492
    /// </summary>
    public IsoMax4NumericText? KeyLength { get; init; } 
    /// <summary>
    /// Mechanism used to provide key confidentiality and integrity. 
    /// ISO 13492
    /// </summary>
    public IsoMax2NumericText? KeyProtection { get; init; } 
    /// <summary>
    /// Identifies a unique key set when multiple keys with the same key set identifier are used (for example, key rotation).
    /// ISO 13492
    /// Length of 2 or 5
    /// </summary>
    public IsoMax5NumericText? KeyIndex { get; init; } 
    /// <summary>
    /// As defined in ISO 9564-1. 
    /// </summary>
    public required IsoMax2NumericText PINBlockFormat { get; init; } 
    /// <summary>
    /// As defined in ISO 9564-1. 
    /// Binary, length of 8 or 16
    /// </summary>
    public required IsoMax16HexBinaryText EncryptedPINBlock { get; init; } 
    
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
        if (Control is IsoExact1HexBinaryText ControlValue)
        {
            writer.WriteStartElement(null, "Ctrl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact1HexBinaryText(ControlValue)); // data type Exact1HexBinaryText System.String
            writer.WriteEndElement();
        }
        if (KeySetIdentifier is IsoMax8NumericText KeySetIdentifierValue)
        {
            writer.WriteStartElement(null, "KeySetIdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax8NumericText(KeySetIdentifierValue)); // data type Max8NumericText System.String
            writer.WriteEndElement();
        }
        if (DerivedInformation is IsoMax32HexBinaryText DerivedInformationValue)
        {
            writer.WriteStartElement(null, "DrvdInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax32HexBinaryText(DerivedInformationValue)); // data type Max32HexBinaryText System.String
            writer.WriteEndElement();
        }
        if (Algorithm is IsoMax2NumericText AlgorithmValue)
        {
            writer.WriteStartElement(null, "Algo", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax2NumericText(AlgorithmValue)); // data type Max2NumericText System.String
            writer.WriteEndElement();
        }
        if (KeyLength is IsoMax4NumericText KeyLengthValue)
        {
            writer.WriteStartElement(null, "KeyLngth", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax4NumericText(KeyLengthValue)); // data type Max4NumericText System.String
            writer.WriteEndElement();
        }
        if (KeyProtection is IsoMax2NumericText KeyProtectionValue)
        {
            writer.WriteStartElement(null, "KeyPrtcn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax2NumericText(KeyProtectionValue)); // data type Max2NumericText System.String
            writer.WriteEndElement();
        }
        if (KeyIndex is IsoMax5NumericText KeyIndexValue)
        {
            writer.WriteStartElement(null, "KeyIndx", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax5NumericText(KeyIndexValue)); // data type Max5NumericText System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PINBlckFrmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax2NumericText(PINBlockFormat)); // data type Max2NumericText System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "NcrptdPINBlck", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax16HexBinaryText(EncryptedPINBlock)); // data type Max16HexBinaryText System.String
        writer.WriteEndElement();
    }
    public static new PINData Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
