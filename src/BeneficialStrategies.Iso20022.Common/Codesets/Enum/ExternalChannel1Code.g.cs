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
    /// ??
    /// Encoded/decoded by serializers as "Courier".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uOZEXvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Courier,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Email".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uOi1UvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Email,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Fax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uOi1VfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Fax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Messenger".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uOi1WPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Messenger,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Post".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uOi1W_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Post,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegisteredMail".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uOi1XvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    RegisteredMail,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecureEmail".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uOsmUvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SecureEmail,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SWIFTNetFileAct".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uOsmVfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SWIFTNetFileAct,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SWIFTNetInterAct".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uOsmWPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SWIFTNetInterAct,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SWIFTMT".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uOsmW_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SWIFTMT,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SWIFTMX".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uO1wQvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SWIFTMX,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Telecommunication".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uO1wRfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Telecommunication,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WebUploadDownload".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uO_hQvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
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


