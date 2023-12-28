﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalChannel1Code.  ISO2002 ID# _-MOeEG7iEeKo25nLKvGr8w_689018111.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external submission or presentation channel code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MOeEG7iEeKo25nLKvGr8w_689018111")]
[Description(@"Specifies the external submission or presentation channel code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalChannelCode))]
public enum ExternalChannel1Code
{
    /// <summary>
    /// Delivery by courier.
    /// Encoded/decoded by serializers as "Courier".
    /// </summary>
    [EnumMember(Value = "COUR")]
    [IsoId("_uOZEXvRYEeuLhpyIdtJzwg")]
    [Description(@"Delivery by courier.")]
    Courier,
    
    /// <summary>
    /// Transmission by e-mail.
    /// Encoded/decoded by serializers as "Email".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_uOi1UvRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by e-mail.")]
    Email,
    
    /// <summary>
    /// Transmission by fax.
    /// Encoded/decoded by serializers as "Fax".
    /// </summary>
    [EnumMember(Value = "FAXI")]
    [IsoId("_uOi1VfRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by fax.")]
    Fax,
    
    /// <summary>
    /// Delivery by messenger.
    /// Encoded/decoded by serializers as "Messenger".
    /// </summary>
    [EnumMember(Value = "MESS")]
    [IsoId("_uOi1WPRYEeuLhpyIdtJzwg")]
    [Description(@"Delivery by messenger.")]
    Messenger,
    
    /// <summary>
    /// Delivery by postal service.
    /// Encoded/decoded by serializers as "Post".
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_uOi1W_RYEeuLhpyIdtJzwg")]
    [Description(@"Delivery by postal service.")]
    Post,
    
    /// <summary>
    /// Delivery by registered mail services.
    /// Encoded/decoded by serializers as "RegisteredMail".
    /// </summary>
    [EnumMember(Value = "REGM")]
    [IsoId("_uOi1XvRYEeuLhpyIdtJzwg")]
    [Description(@"Delivery by registered mail services.")]
    RegisteredMail,
    
    /// <summary>
    /// Transfer via secure e-mail.
    /// Encoded/decoded by serializers as "SecureEmail".
    /// </summary>
    [EnumMember(Value = "SEMA")]
    [IsoId("_uOsmUvRYEeuLhpyIdtJzwg")]
    [Description(@"Transfer via secure e-mail.")]
    SecureEmail,
    
    /// <summary>
    /// Transmission by SWIFTNet FileAct.
    /// Encoded/decoded by serializers as "SWIFTNetFileAct".
    /// </summary>
    [EnumMember(Value = "SWFA")]
    [IsoId("_uOsmVfRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by SWIFTNet FileAct.")]
    SWIFTNetFileAct,
    
    /// <summary>
    /// Transmission by SWIFTNet InterAct. 
    /// Encoded/decoded by serializers as "SWIFTNetInterAct".
    /// </summary>
    [EnumMember(Value = "SWIA")]
    [IsoId("_uOsmWPRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by SWIFTNet InterAct. ")]
    SWIFTNetInterAct,
    
    /// <summary>
    /// Transmission by SWIFT (FIN).
    /// Encoded/decoded by serializers as "SWIFTMT".
    /// </summary>
    [EnumMember(Value = "SWMT")]
    [IsoId("_uOsmW_RYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by SWIFT (FIN).")]
    SWIFTMT,
    
    /// <summary>
    /// Transmission by SWIFTNet.
    /// Encoded/decoded by serializers as "SWIFTMX".
    /// </summary>
    [EnumMember(Value = "SWMX")]
    [IsoId("_uO1wQvRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by SWIFTNet.")]
    SWIFTMX,
    
    /// <summary>
    /// Transmission by telecommunications service.
    /// Encoded/decoded by serializers as "Telecommunication".
    /// </summary>
    [EnumMember(Value = "TELE")]
    [IsoId("_uO1wRfRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by telecommunications service.")]
    Telecommunication,
    
    /// <summary>
    /// Available via Web upload/download
    /// Encoded/decoded by serializers as "WebUploadDownload".
    /// </summary>
    [EnumMember(Value = "WEBM")]
    [IsoId("_uO_hQvRYEeuLhpyIdtJzwg")]
    [Description(@"Available via Web upload/download")]
    WebUploadDownload,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalChannel1CodeMetadataExtensions
{
    private static readonly ExternalChannel1CodeDropdownSource _dropdownSource = new ExternalChannel1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalChannel1CodeDropdownRow GetMetadata(this ExternalChannel1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


