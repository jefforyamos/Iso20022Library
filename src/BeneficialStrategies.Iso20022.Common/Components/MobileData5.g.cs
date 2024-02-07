﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MobileData5.  ISO2002 ID# _V4zFAXDdEe2MCaKO5AtGsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the mobile of stakeholder.
/// </summary>
public partial record MobileData5
     : IIsoXmlSerilizable<MobileData5>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the country of a mobile phone operator.
    /// </summary>
    public IsoMin2Max3AlphaText? MobileCountryCode { get; init; } 
    /// <summary>
    /// Identifies the mobile phone operator inside a country.
    /// </summary>
    public IsoMin2Max3NumericText? MobileNetworkCode { get; init; } 
    /// <summary>
    /// Masked Mobile Subscriber Integrated Service Digital Network.
    /// </summary>
    public IsoMax35Text? MobileMaskedMSISDN { get; init; } 
    /// <summary>
    /// Geographic location specified by geographic or UTM coordinates.
    /// </summary>
    public Geolocation1? Geolocation { get; init; } 
    /// <summary>
    /// Sensitive information related to the mobile phone.
    /// </summary>
    public SensitiveMobileData1? SensitiveMobileData { get; init; } 
    /// <summary>
    /// Sensitive information related to the mobile phone, protected by CMS.
    /// </summary>
    public ContentInformationType35? ProtectedMobileData { get; init; } 
    
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
        if (MobileCountryCode is IsoMin2Max3AlphaText MobileCountryCodeValue)
        {
            writer.WriteStartElement(null, "MobCtryCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMin2Max3AlphaText(MobileCountryCodeValue)); // data type Min2Max3AlphaText System.String
            writer.WriteEndElement();
        }
        if (MobileNetworkCode is IsoMin2Max3NumericText MobileNetworkCodeValue)
        {
            writer.WriteStartElement(null, "MobNtwkCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMin2Max3NumericText(MobileNetworkCodeValue)); // data type Min2Max3NumericText System.String
            writer.WriteEndElement();
        }
        if (MobileMaskedMSISDN is IsoMax35Text MobileMaskedMSISDNValue)
        {
            writer.WriteStartElement(null, "MobMskdMSISDN", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MobileMaskedMSISDNValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Geolocation is Geolocation1 GeolocationValue)
        {
            writer.WriteStartElement(null, "Glctn", xmlNamespace );
            GeolocationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SensitiveMobileData is SensitiveMobileData1 SensitiveMobileDataValue)
        {
            writer.WriteStartElement(null, "SnstvMobData", xmlNamespace );
            SensitiveMobileDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProtectedMobileData is ContentInformationType35 ProtectedMobileDataValue)
        {
            writer.WriteStartElement(null, "PrtctdMobData", xmlNamespace );
            ProtectedMobileDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MobileData5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
