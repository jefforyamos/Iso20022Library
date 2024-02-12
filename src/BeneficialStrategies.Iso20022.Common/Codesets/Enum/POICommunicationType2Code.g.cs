﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for POICommunicationType2Code.  ISO2002 ID# _15SnYbCYEeapjPTKZHuM2w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Low level communication of the hardware or software component toward another component or an external entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_15SnYbCYEeapjPTKZHuM2w")]
[Description(@"Low level communication of the hardware or software component toward another component or an external entity.")]
[DerivedFrom(typeof(POICommunicationTypeCode))]
public enum POICommunicationType2Code
{
    /// <summary>
    /// Communication with a host using Bluetooth.
    /// Encoded/decoded by serializers as "BLTH".
    /// </summary>
    [EnumMember(Value = "BLTH")]
    [IsoId("_2Ix04bCYEeapjPTKZHuM2w")]
    [Description(@"Communication with a host using Bluetooth.")]
    Bluetooth = POICommunicationTypeCode.Bluetooth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ethernet port to communicate.
    /// Encoded/decoded by serializers as "ETHR".
    /// </summary>
    [EnumMember(Value = "ETHR")]
    [IsoId("_2Ix047CYEeapjPTKZHuM2w")]
    [Description(@"Ethernet port to communicate.")]
    Ethernet = POICommunicationTypeCode.Ethernet, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Communication with a host using GPRS.
    /// Encoded/decoded by serializers as "GPRS".
    /// </summary>
    [EnumMember(Value = "GPRS")]
    [IsoId("_2Ix05bCYEeapjPTKZHuM2w")]
    [Description(@"Communication with a host using GPRS.")]
    GPRS = POICommunicationTypeCode.GPRS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Communication with a host using GSM.
    /// Encoded/decoded by serializers as "GSMF".
    /// </summary>
    [EnumMember(Value = "GSMF")]
    [IsoId("_2Ix057CYEeapjPTKZHuM2w")]
    [Description(@"Communication with a host using GSM.")]
    GSM = POICommunicationTypeCode.GSM, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Communication with a host using Public Switching Telephone Network.
    /// Encoded/decoded by serializers as "PSTN".
    /// </summary>
    [EnumMember(Value = "PSTN")]
    [IsoId("_2Ix06bCYEeapjPTKZHuM2w")]
    [Description(@"Communication with a host using Public Switching Telephone Network.")]
    PSTN = POICommunicationTypeCode.PSTN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Serial port to communicate.
    /// Encoded/decoded by serializers as "RS23".
    /// </summary>
    [EnumMember(Value = "RS23")]
    [IsoId("_2Ix067CYEeapjPTKZHuM2w")]
    [Description(@"Serial port to communicate.")]
    RS232 = POICommunicationTypeCode.RS232, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Communication with a USB stick or any USB device.
    /// Encoded/decoded by serializers as "USBD".
    /// </summary>
    [EnumMember(Value = "USBD")]
    [IsoId("_2Ix07bCYEeapjPTKZHuM2w")]
    [Description(@"Communication with a USB stick or any USB device.")]
    USBDevice = POICommunicationTypeCode.USBDevice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Communication with a host from an USB port.
    /// Encoded/decoded by serializers as "USBH".
    /// </summary>
    [EnumMember(Value = "USBH")]
    [IsoId("_2Ix077CYEeapjPTKZHuM2w")]
    [Description(@"Communication with a host from an USB port.")]
    USBHost = POICommunicationTypeCode.USBHost, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Wifi communication with another component.
    /// Encoded/decoded by serializers as "WIFI".
    /// </summary>
    [EnumMember(Value = "WIFI")]
    [IsoId("_2Ix08bCYEeapjPTKZHuM2w")]
    [Description(@"Wifi communication with another component.")]
    Wifi = POICommunicationTypeCode.Wifi, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Includes all communication technologies which can be qualified as being part of the 2G technology (e.g EDGE or PDC).
    /// Encoded/decoded by serializers as "WT2G".
    /// </summary>
    [EnumMember(Value = "WT2G")]
    [IsoId("_5Q9GwbCYEeapjPTKZHuM2w")]
    [Description(@"Includes all communication technologies which can be qualified as being part of the 2G technology (e.g EDGE or PDC).")]
    WirelessTechnology2G = POICommunicationTypeCode.WirelessTechnology2G, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Includes all communication technologies which can be qualified as being part of the 3G technology.
    /// Encoded/decoded by serializers as "WT3G".
    /// </summary>
    [EnumMember(Value = "WT3G")]
    [IsoId("_5V6fQbCYEeapjPTKZHuM2w")]
    [Description(@"Includes all communication technologies which can be qualified as being part of the 3G technology.")]
    WirelessTechnology3G = POICommunicationTypeCode.WirelessTechnology3G, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Includes all communication technologies which can be qualified as being part of the 4G technology.
    /// Encoded/decoded by serializers as "WT4G".
    /// </summary>
    [EnumMember(Value = "WT4G")]
    [IsoId("_5a33wbCYEeapjPTKZHuM2w")]
    [Description(@"Includes all communication technologies which can be qualified as being part of the 4G technology.")]
    WirelessTechnology4G = POICommunicationTypeCode.WirelessTechnology4G, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Includes all communication technologies which can be qualified as being part of the 5G technology.
    /// Encoded/decoded by serializers as "WT5G".
    /// </summary>
    [EnumMember(Value = "WT5G")]
    [IsoId("_5gTxYbCYEeapjPTKZHuM2w")]
    [Description(@"Includes all communication technologies which can be qualified as being part of the 5G technology.")]
    WirelessTechnology5G = POICommunicationTypeCode.WirelessTechnology5G, // same ordinal as derivation source for type conversions
    
}
