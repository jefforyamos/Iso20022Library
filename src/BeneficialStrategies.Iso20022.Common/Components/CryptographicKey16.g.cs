﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CryptographicKey16.  ISO2002 ID# _ARVpYVFAEeyApZmLzm74zA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic Key.
/// </summary>
public partial record CryptographicKey16
     : IIsoXmlSerilizable<CryptographicKey16>
{
    #nullable enable
    
    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    public required IsoMax350Text Identification { get; init; } 
    /// <summary>
    /// Additional identification of the key.
    /// Usage
    /// For derived unique key per transaction (DUKPT) keys, the key serial number (KSN) with the 21 bits of the transaction counter set to zero.
    /// </summary>
    public IsoMax35Binary? AdditionalIdentification { get; init; } 
    /// <summary>
    /// Name of the Cryptographic Element.
    /// </summary>
    public IsoMax256Text? Name { get; init; } 
    /// <summary>
    /// Identification of the set of security elements to which this element belongs.
    /// </summary>
    public IsoMax35Text? SecurityProfile { get; init; } 
    /// <summary>
    /// Hierarchical identification of a key inside all the key system. It is composed of all item numbers of the upper level components, separated by the '.' character, ended by the item number of the current component.
    /// </summary>
    public IsoMax35Text? ItemNumber { get; init; } 
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    public required IsoMax256Text Version { get; init; } 
    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    public CryptographicKeyType3Code? Type { get; init; } 
    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    public KeyUsage1Code? Function { get; init; } 
    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    public IsoISODateTime? ActivationDate { get; init; } 
    /// <summary>
    /// Date and time on which the key must be deactivated.
    /// </summary>
    public IsoISODateTime? DeactivationDate { get; init; } 
    /// <summary>
    /// Encrypted cryptographic key.
    /// </summary>
    public ContentInformationType30? KeyValue { get; init; } 
    /// <summary>
    /// Value for checking a cryptographic key security parameter.
    /// </summary>
    public IsoMax35Binary? KeyCheckValue { get; init; } 
    /// <summary>
    /// Additional Information needed by the receiver to securely process the management of the security element.
    /// </summary>
    public GenericInformation1? AdditionalManagementInformation { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoMax350Text(Identification)); // data type Max350Text System.String
        writer.WriteEndElement();
        if (AdditionalIdentification is IsoMax35Binary AdditionalIdentificationValue)
        {
            writer.WriteStartElement(null, "AddtlId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Binary(AdditionalIdentificationValue)); // data type Max35Binary System.Byte[]
            writer.WriteEndElement();
        }
        if (Name is IsoMax256Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax256Text(NameValue)); // data type Max256Text System.String
            writer.WriteEndElement();
        }
        if (SecurityProfile is IsoMax35Text SecurityProfileValue)
        {
            writer.WriteStartElement(null, "SctyPrfl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SecurityProfileValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ItemNumber is IsoMax35Text ItemNumberValue)
        {
            writer.WriteStartElement(null, "ItmNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ItemNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Vrsn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax256Text(Version)); // data type Max256Text System.String
        writer.WriteEndElement();
        if (Type is CryptographicKeyType3Code TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            writer.WriteValue(TypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Function is KeyUsage1Code FunctionValue)
        {
            writer.WriteStartElement(null, "Fctn", xmlNamespace );
            writer.WriteValue(FunctionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ActivationDate is IsoISODateTime ActivationDateValue)
        {
            writer.WriteStartElement(null, "ActvtnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(ActivationDateValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (DeactivationDate is IsoISODateTime DeactivationDateValue)
        {
            writer.WriteStartElement(null, "DeactvtnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(DeactivationDateValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (KeyValue is ContentInformationType30 KeyValueValue)
        {
            writer.WriteStartElement(null, "KeyVal", xmlNamespace );
            KeyValueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (KeyCheckValue is IsoMax35Binary KeyCheckValueValue)
        {
            writer.WriteStartElement(null, "KeyChckVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Binary(KeyCheckValueValue)); // data type Max35Binary System.Byte[]
            writer.WriteEndElement();
        }
        if (AdditionalManagementInformation is GenericInformation1 AdditionalManagementInformationValue)
        {
            writer.WriteStartElement(null, "AddtlMgmtInf", xmlNamespace );
            AdditionalManagementInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CryptographicKey16 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
